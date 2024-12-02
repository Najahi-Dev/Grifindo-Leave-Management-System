using Grifindo_Sample_LMS.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Grifindo_Sample_LMS.Admin.Classes
{
    internal class UserLoginClass : DBCommon
    {
        internal string ID { get; set; }
        internal string Pass { get; set; }


        internal bool ValidateAdminLogin(string username, string password)
        {
            try
            {
                string sql = "SELECT COUNT(1) FROM Admin_Details WHERE Admin_ID = @ID AND Password = @pass ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", username);
                cmd.Parameters.AddWithValue("@pass", password);
                con.Open();
                return (int)cmd.ExecuteScalar() == 1;
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Login Error");
                return false;
            }
            finally
            {
                con.Close();
            }

        }

        internal bool ValidateEmployeeLogin(string username, string password)
        {
            try
            {
                string sql = "SELECT COUNT(1) FROM Add_Employee WHERE Employee_ID = @ID AND Password = @pass ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", username);
                cmd.Parameters.AddWithValue("@pass", password);
                con.Open();
                return (int)cmd.ExecuteScalar() == 1;
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Login Error");
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
