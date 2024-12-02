using Grifindo_Sample_LMS.Admin.Classes;
using Grifindo_Sample_LMS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Sample_LMS.Admin
{
    public partial class LoginApproval : Form
    {
        DBCommon db = new DBCommon();
        LoginApprovalClass approvalClass = new LoginApprovalClass();
        commonTools tools = new commonTools();

        public LoginApproval()
        {
            InitializeComponent();
        }

        internal void clearfunction()
        {
            //cmbUsername.Items.Clear();
            //cmbRole.Items.Clear();
            //cmbpassword.Items.Clear();
            txtuser.Text = string.Empty;
        }

       


        //===================================================== COMBO BOX ======================================================================
        internal void usernameCombo()
        {
            try
            {
                db.con.Open();

                DataSet ds = new DataSet();
                string sql = "SELECT Employee_ID FROM Add_Employee UNION SELECT Admin_ID FROM Admin_Details"; //This qry is Call Different table datas
                SqlDataAdapter da = new SqlDataAdapter(sql, db.con);
                da.Fill(ds);
                cmbUsername.DataSource = ds.Tables[0];
                cmbUsername.DisplayMember = ds.Tables[0].Columns[0].ToString();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                db.con.Close();
            }
        }
         
        internal void passswordCombo()
        {
            try
            {
                db.con.Open();

                DataSet ds = new DataSet();
                string sql = "SELECT Password FROM Add_Employee";
                SqlDataAdapter da = new SqlDataAdapter(sql, db.con);
                da.Fill(ds);
                cmbpassword.DataSource = ds.Tables[0];
                cmbpassword.DisplayMember = ds.Tables[0].Columns[0].ToString();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                db.con.Close();
            }
        } 
       
        //======================================================================================================================================
        private void LoginApproval_Load(object sender, EventArgs e)
        {
            approvalClass.DGVUsers = dgvUserLogin;
            approvalClass.View();
            dgvUserLogin.Columns[0].Visible = false;
            usernameCombo();
            passswordCombo();
            tools.autocompletetext("SELECT Username FROM User_Login",txtuser,"Username");
            //====================================================================================================================================
            try
            {
                string sql = "SELECT Employee_ID as [Emp ID], Password, Last_Name as Name FROM Add_Employee";
                db.LoadDataFromDB(sql, dgvEmp);

                if (dgvEmp.Columns.Count > 0)
                {
                    //dgvEmp.Columns[0].Width = 120;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            try
            {
                string sql = "SELECT Admin_ID as  [Admin ID], Password, Last_Name as Name FROM Admin_Details;";
                db.LoadDataFromDB(sql, dgvAdmin);

                if (dgvAdmin.Columns.Count > 0)
                {
                    //dgvAdmin.Columns[0].Width = 120;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            //=====================================================================================================================================

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            approvalClass.Approve();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            approvalClass.Remove();
        }

        private void cmbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            approvalClass.Username = cmbUsername.Text;
        }

        private void cmbpassword_SelectedIndexChanged(object sender, EventArgs e)
        {
            approvalClass.Password = cmbpassword.Text;
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            approvalClass.Role = cmbRole.Text;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string Username = txtuser.Text;

            try
            {
                db.con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [User_Login] WHERE Username = '" + Username + "'", db.con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbUsername.Text = rdr.GetValue(1).ToString();
                    cmbpassword.Text = rdr.GetValue(2).ToString();
                    cmbRole.Text = rdr.GetValue(3).ToString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                db.con.Close();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearfunction();
        }
    }
}
