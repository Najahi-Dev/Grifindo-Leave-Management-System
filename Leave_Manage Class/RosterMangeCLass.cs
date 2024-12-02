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
    internal class RosterMangeCLass : commonTools
    {
        DBCommon db = new DBCommon();

        internal void DeleteRoster(string employeeId)
        {
            try
            {
                string query = "DELETE FROM tblRoster WHERE Employee_ID = @empId";
                SqlParameter[] parameters = { new SqlParameter("@empId", employeeId) };

                int rowsAffected = ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Roster deleted successfully for the employee.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No roster found for the given Employee ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the roster: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        internal void UpdateRoster(string empID, TimeSpan newstart, TimeSpan newend)
        {
            try
            {
                // Validate the input
                if (newstart >= newend)
                {
                    MessageBox.Show("Start time must be earlier than end time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "UPDATE tblRoster SET StartTime = @start, EndTime = @end WHERE Employee_ID = @empId";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@empId", empID),
                    new SqlParameter("@start", newstart),
                    new SqlParameter("@end", newend)
                };

                int rowsAffected = ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Roster updated successfully for the employee.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No roster found for the given Employee ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the roster: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
