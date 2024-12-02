using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Grifindo_Sample_LMS.Leave_Manage_Class
{
    internal class RosterClass : commonTools
    {
        internal DataGridView RosterDGV { get; set; }

        public void DefineRoster(string employeeID, TimeSpan startTime, TimeSpan endTime) //  ========= Assign Roster=======================
        {
            try
            {
                string sql = " INSERT INTO tblRoster(Employee_ID,StartTime,EndTime) VALUES(@empID,@start,@end) ";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@empID", employeeID),
                    new SqlParameter("@start", startTime),
                    new SqlParameter("@end", endTime)
                };

                ExecuteNonQuery(sql, parameters);
                Console.WriteLine("Roster defined successfully for the employee.", "Success");
                ViewRoster();
            }
            catch(SqlException sql)
            {
                Console.WriteLine(sql.Message);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        //===================================== View Roster ============================
        internal void ViewRoster()
        {
            string sql = "Select tblRoster.Employee_ID as [Employee ID], Add_Employee.Last_Name as [Name] ," +
                "tblRoster.StartTime as [Roster Start], tblRoster.EndTime as [Roster End] from tblRoster " +
                "JOIN Add_Employee ON tblRoster.Employee_ID = Add_Employee.Employee_ID";
            LoadDataFromDB(sql, RosterDGV);
        }

        //============================ Delete Roter =====================================
        //public void DeleteRoster(string employeeId)
        //{
        //    try
        //    {
        //        string query = "DELETE FROM tblRoster WHERE Employee_ID = @empId";
        //        SqlParameter[] parameters = { new SqlParameter("@empId", employeeId) };

        //        int rowsAffected = ExecuteNonQuery(query, parameters);

        //        if (rowsAffected > 0)
        //        {
        //            Console.WriteLine("Roster deleted successfully for the employee.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            Console.WriteLine("No roster found for the given Employee ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"An error occurred while deleting the roster: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


    }
}
