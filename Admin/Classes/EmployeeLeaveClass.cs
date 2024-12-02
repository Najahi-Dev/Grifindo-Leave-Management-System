using iTextSharp.text.pdf.parser.clipper;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Grifindo_Sample_LMS.Admin.Classes
{
    internal class EmployeeLeaveClass : commonTools
    {
        public DataGridView dgvLeave {  get; set; }

        internal void AssignLeave(string employeeID, int Annual,int Casual, int Short,string offday,int Halfday)
        {
            try
            {
                string sql = " INSERT INTO tblEmployeeLeave(EmployeeID,AnnualLeave,CasualLeave,ShortLeave,OffDay,HalfDayLeave) VALUES(@empID,@annual,@casual,@short,@offday,@halfday) ";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@empID", employeeID),
                    new SqlParameter("@annual", Annual),
                    new SqlParameter("@casual", Casual),
                    new SqlParameter("@short",Short),
                    new SqlParameter("@offday",offday),
                    new SqlParameter("@halfday",Halfday)
                };

                ExecuteNonQuery(sql, parameters);
                MessageBox.Show("Leave assigned successfully for the employee.", "Success");
                ViewLeave();
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        internal void UpdateLeave(string employeeID, int Annual, int Casual, int Short,string OffDay,int Halfday)
        {
            try
            {
                string sql = " UPDATE tblEmployeeLeave SET AnnualLeave = @annual, CasualLeave = @casual, ShortLeave = @short, OffDay = @offday, HalfDayLeave = @halfday WHERE EmployeeID = @empid ";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@annual",Annual),
                    new SqlParameter("@casual",Casual),
                    new SqlParameter("@short",Short),
                    new SqlParameter("empid",employeeID),
                    new SqlParameter("@offday",OffDay),
                    new SqlParameter("@halfday",Halfday)
                };

                ExecuteNonQuery (sql, parameters);
                MessageBox.Show("Leave updated successfully for the employee", "Updated");
                ViewLeave();
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        internal void DeleteLeave(string empID)
        {
            try
            {
                string sql = " DELETE FROM tblEmployeeLeave WHERE EmployeeID = @empid ";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@empid",empID),
                };

                ExecuteNonQuery(sql, parameters);
                MessageBox.Show("Leave removed successfully for the employee", "Updated");
                ViewLeave();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        internal void ViewLeave()
        {
            string sql = " SELECT tblEmployeeLeave.EmployeeID as [Employee ID], Add_Employee.Last_Name as [Name], tblEmployeeLeave.AnnualLeave as [Annual Count], tblEmployeeLeave.CasualLeave as [Casual Count], tblEmployeeLeave.ShortLeave as [Short Count], tblEmployeeLeave.OffDay as [Off Day], tblEmployeeLeave.HalfDayLeave as [Half Day] FROM tblEmployeeLeave " +
                "JOIN Add_Employee ON tblEmployeeLeave.EmployeeID = Add_Employee.Employee_ID";
            LoadDataFromDB(sql, dgvLeave);
        }
    }
}
