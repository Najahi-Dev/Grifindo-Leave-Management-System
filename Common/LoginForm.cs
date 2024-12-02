using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grifindo_Sample_LMS.Admin.Classes;
using Grifindo_Sample_LMS.Employee;

namespace Grifindo_Sample_LMS.Common
{
    public partial class LoginForm : Form
    {
        UserLoginClass log = new UserLoginClass();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtuserID.Focus();
            txtpassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtuserID.Text.Trim();
            string password = txtpassword.Text.Trim();

            if (log.ValidateAdminLogin(username,password))
            {
                //MessageBox.Show($"Login Successfully, Welcome Back {username}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminWelcomeForm welcome = new AdminWelcomeForm(username);
                welcome.Show();
                this.Hide();
                //AdminNav nav = new AdminNav(username);
                //nav.Show();
                //this.Hide();
            }
            else if (log.ValidateEmployeeLogin(username,password))
            {
                //MessageBox.Show($"Login Successfully, Welcome Back {username}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //EmployeeNav nav = new EmployeeNav(username);
                //nav.Show();
                //this.Hide();

                EmployeeWelcomeForm wel = new EmployeeWelcomeForm(username);
                wel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password; Please Check and Try Again", "Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txtuserID_Leave(object sender, EventArgs e)
        {
            if (txtuserID.Text.Length == 0)
            {
                txtuserID.ForeColor = Color.Red;
                txtuserID.Text = "Enter Your Username";
                //txtuserID.UseSystemPasswordChar = false;
                SelectNextControl(txtuserID, true, true, false, true);
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text.Length == 0)
            {
                txtpassword.ForeColor = Color.Red;
                txtpassword.Text = "Enter Your Password";
                txtpassword.UseSystemPasswordChar = false;
                SelectNextControl(txtpassword, true, true, false, true);
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            //txtpassword.Text = "";
            //txtpassword.ForeColor = Color.White;
            //txtpassword.UseSystemPasswordChar = true;
        }
    }
}
