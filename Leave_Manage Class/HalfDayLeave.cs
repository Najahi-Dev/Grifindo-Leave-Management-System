using Grifindo_Sample_LMS.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Sample_LMS.Leave_Manage_Class
{
    internal class HalfDayLeave : commonTools
    {
        DBCommon db = new DBCommon();

        public DataGridView dgvHalfDay {  get; set; }

        public bool ApplyHalfDayLeave(string employeeId, DateTime leaveDate, string timeslot, string reason)
        {
            try
            {
                // Validate time slot input
                if (timeslot != "Morning" && timeslot != "Afternoon")
                {
                    MessageBox.Show("Invalid time slot selected. Choose either 'Morning' or 'Afternoon'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Prepare the query
                string query = "INSERT INTO tblLeave (EmployeeID, LeaveType, Date, TimeSlot, Reason, Status) " +
                               "VALUES (@empId, 'HalfDay', @date, @timeSlot, @reason, 'Pending')";

                // Prepare the parameters
                SqlParameter[] parameters =
                {
                    new SqlParameter("@empId", employeeId),
                    new SqlParameter("@date", leaveDate),
                    new SqlParameter("@timeSlot", timeslot == "Morning" ? "08:00-12:00" : "13:00-17:30"),
                    new SqlParameter("@reason", reason)
                };

                // Execute the query
                ExecuteNonQuery(query, parameters);

                // Notify the user
                MessageBox.Show($"Half-day leave for {timeslot} applied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                // Handle errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal void ViewHalfDay(string empid)
        {
            string sql = "SELECT LeaveType as [Leave Type],Date as [Applied Leave Date], TimeSlot as [Time Slot],Reason, Status, AppliedDate as [Applied Date] FROM tblLeave WHERE EmployeeID = '"+empid+"' ";
            db.LoadDataFromDB(sql,dgvHalfDay);
        }


    }
}
