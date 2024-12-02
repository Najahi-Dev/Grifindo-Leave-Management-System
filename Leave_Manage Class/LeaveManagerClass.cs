using Grifindo_Sample_LMS.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Sample_LMS.Leave_Manage_Class
{
    internal class LeaveManagerClass : commonTools
    {
        DBCommon db = new DBCommon();

        internal DataGridView dgvLeave {  get; set; }

        //============================================================== Annual Leave =================================================

        private string HandleAnnualLeave(DataTable employeeLeaveData, DateTime leaveDate)
        {
            int annualLeaveBalance = Convert.ToInt32(employeeLeaveData.Rows[0]["AnnualLeave"]);
            if (annualLeaveBalance <= 0)
                return "Insufficient Annual Leaves Balance.";
            if ((leaveDate - DateTime.Today).TotalDays < 7)
                return "Annual Leave must be applied at least 7 days in advance.";
            return "Success";
        }

        //============================================================= Casual Leave ==================================================

        private string HandleCasualLeave(DataTable employeeLeaveData, DateTime leaveDate, DataTable rosterData)
        {
            int casualLeaveBalance = Convert.ToInt32(employeeLeaveData.Rows[0]["CasualLeave"]);
            if (casualLeaveBalance <= 0)
                return "Insufficient Casual Leaves Balance.";
            if (rosterData.Rows.Count > 0)
            {
                TimeSpan rosterStartTime = TimeSpan.Parse(rosterData.Rows[0]["StartTime"].ToString());
                if (DateTime.Now.TimeOfDay >= rosterStartTime)
                    return "Casual leaves must be applied before the rostered start time.";
            }
            return "Success";
        }

        //=========================================================== Short Leave ======================================================

        private string HandleShortLeave(DataTable employeeLeaveData, DateTime leaveDate, TimeSpan? shortLeaveTime, DataTable rosterData)
        {
            int shortLeaveBalance = Convert.ToInt32(employeeLeaveData.Rows[0]["ShortLeave"]);
            if (shortLeaveBalance <= 0)
                return "Insufficient Short Leaves Balance.";
            if (shortLeaveTime.HasValue && shortLeaveTime.Value <= DateTime.Now.TimeOfDay)
                return "Short leaves can only be applied for upcoming time slots.";
            TimeSpan shortLeaveDuration = TimeSpan.FromMinutes(90);
            if (shortLeaveTime.HasValue)
            {
                TimeSpan rosterEndTime = TimeSpan.Parse(rosterData.Rows[0]["EndTime"].ToString());
                if (shortLeaveTime.Value.Add(shortLeaveDuration) > rosterEndTime)
                    return "Short leave exceeds the roster end time.";
            }
            return "Success";
        }

        //======================================================== Halfday Leave =======================================================

        private string HandleHalfday(DataTable employeeLeaveData,DateTime leaveDate,DataTable rosterData)
        {
            if (rosterData.Rows.Count > 0)
            {
                TimeSpan rosterStartTime = TimeSpan.Parse(rosterData.Rows[0]["StartTime"].ToString());
                TimeSpan rosterEndTime = TimeSpan.Parse(rosterData.Rows[0]["EndTime"].ToString());
                TimeSpan halfDayDuration = TimeSpan.FromHours((rosterEndTime - rosterStartTime).TotalHours / 2);

                if ((leaveDate.TimeOfDay - rosterStartTime).Duration() < halfDayDuration)
                    return "Half-day leave does not align with roster timings.";
            }
            return "Success";
        }

        //======================================================== Apply Leave =========================================================

        internal string ApplyLeave(string empID, string leaveType, DateTime leaveDate,  TimeSpan? shortLeaveTime, string reason)
        {
            string sql = " SELECT * FROM tblEmployeeLeave WHERE EmployeeID = @empid ";
            SqlParameter[] parameters = { new SqlParameter("@empid", empID) };
            DataTable employeeLeaveData = ExecuteQuery(sql, parameters);

            if (employeeLeaveData.Rows.Count == 0)
            {
                return "Employee Leave Not Found.";
            }

            sql = "SELECT * FROM tblRoster WHERE Employee_ID = @empid";
            DataTable rosterData = ExecuteQuery(sql, parameters);

            string result;
            switch (leaveType)
            {
                case "Annual":
                    result = HandleAnnualLeave(employeeLeaveData, leaveDate);
                    break;

                case "Casual":
                    result = HandleCasualLeave(employeeLeaveData, leaveDate, rosterData);
                    break;

                case "Short":
                    result = HandleShortLeave(employeeLeaveData, leaveDate, shortLeaveTime, rosterData);
                    break;

                case "HalfDay":
                    result = HandleHalfday(employeeLeaveData,leaveDate, rosterData);
                    break;

                default:
                    result = "Invalid Leave Type";
                    break;
            }
            if (result != "Success")
                return result;

            sql = "INSERT INTO tblLeave (EmployeeID, LeaveType, Date, TimeSlot, Reason, Status) " +
                              "VALUES (@empId, @type, @date, @timeSlot, @reason, 'Pending') ";
            SqlParameter[] leaveParams =
            {
                new SqlParameter("@empId", empID),
                new SqlParameter("@type",leaveType),
                new SqlParameter("@date", leaveDate),
                new SqlParameter("@timeSlot", shortLeaveTime?.ToString() ?? DBNull.Value.ToString()),
                new SqlParameter("@reason", reason)
            };

            ExecuteNonQuery(sql, leaveParams);
            return "Leave Application Submit Successfully";
        }
        //============================================================================================================================

        //===================================================== Cancel Applied Leave ===================================================
        public string cancelpendingleave(int leaveID, string empid)
        {
            string sql = " SELECT * FROM tblLeave WHERE LeaveID = @leaveid AND EmployeeID = @empId AND Status = 'Pending' ";
            SqlParameter[] parameters =
            {
                new SqlParameter("@leaveid",leaveID),
                new SqlParameter("@empId",empid)
            };

            DataTable leaveData = ExecuteQuery(sql, parameters);

            if (leaveData.Rows.Count == 0)
            {
                return "Cannot cancel leave. Leave not found or already processed.";
            }

            sql = " DELETE FROM tblLeave WHERE LeaveID = @leaveid AND EmployeeID = @empId AND Status = 'Pending' ";
            int rowaffected = ExecuteNonQuery(sql, parameters);

            if (rowaffected > 0)
                return "Leave Successfully Canceled.";

            else
                return "Failed to Cancel Leave. Please try again";
        }
        
        //====================================================== Load Data in Gridview =================================================

        internal void LoadLeaveData(string EmpID)
        {
            string sql = "SELECT LeaveID, LeaveType as [Leave Type], Date, TimeSlot as [Time Slot], Reason, Status, AdminComment as [Admin Note] FROM tblLeave WHERE EmployeeID = '"+EmpID+"' ";
            db.LoadDataFromDB(sql, dgvLeave);
        }

        internal void LoadLeaveRequest()
        {
            string sql = " SELECT LeaveID,EmployeeID as [Employee ID], LeaveType as [Leave Type], Date, TimeSlot as [Time Slot], Reason, Status, AppliedDate,AdminComment as [Admin Note] FROM tblLeave WHERE Status = 'Pending' ";
            db.LoadDataFromDB (sql, dgvLeave);
        }
        //===========================================================================================================================

        //====================================================== Deduct Leave Count and Approve ========================================
        internal void DeductLeaveBalance(string empid, string leaveType)
        {
            string column = null;
            switch (leaveType)
            {
                case "Annual":
                    column = "AnnualLeave";
                    break;

                case "Casual":
                    column = "CasualLeave";
                    break;

                case "Short":
                    column = "ShortLeave";
                    break;

                case "HalfDay":
                    column = "HalfDayLeave";
                    break;

                default:
                    column = null;
                    break;
            }

            if (column == null)
            {
                throw new ArgumentException("Invalid Leave Type Provided.");
            }

            string sql = $" UPDATE tblEmployeeLeave SET {column} = {column} - 1 WHERE EmployeeID = @empID "; //Calculation
            SqlParameter[] parameters = { new SqlParameter("@empID", empid) };

            int rowAffected = ExecuteNonQuery(sql, parameters);

            if (rowAffected == 0)
            {
                throw new Exception($"Failed to deduct leave for Employee ID {empid}. Make sure the record exists.");
            }
        }
        //===============================================================================================================================================
        public bool IsHoliday(DateTime leaveDate) // Holiday calculate
        {
            string sql = " SELECT COUNT(*) FROM tblHoliday WHERE HolidayDate = @leavedate ";
            SqlParameter[] parameters =
            {
                new SqlParameter("@leavedate",leaveDate)
            };

            int count = Convert.ToInt32(ExecuteScaler(sql, parameters));
            return count > 0;
        }

        public bool IsOffTime(DateTime leaveDate, string empID) //Offtime Calculate
        {
            string sql = "SELECT OffDay FROM tblEmployeeLeave WHERE EmployeeID =@empid";
            SqlParameter[] parameters =
            {
                new SqlParameter("@empid",empID)
            };

            string offDay = ExecuteScaler(sql, parameters)?.ToString();

            if (string.IsNullOrEmpty(offDay)) return false;
           

            DayOfWeek leaveDayofWeek = leaveDate.DayOfWeek;
            return offDay.Contains(leaveDayofWeek.ToString());
        }

        //======================================================== Validate Off and Half Time ==========================================================
        internal bool ValidateOffandHalfDays(DateTime leaveDate, string employeeID)
        {
            bool myret = true;
            if (IsHoliday(leaveDate))
            {
                MessageBox.Show("The selected date is holiday. Leave cannot be applied.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                myret = false;
            }

            if (IsOffTime(leaveDate,employeeID))
            {
                MessageBox.Show("The selected date falls on your off time. Leave cannot be applied", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                myret = false;
            }
            return myret;
        }
    }
}
