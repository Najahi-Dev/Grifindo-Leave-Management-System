using Grifindo_Sample_LMS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Grifindo_Sample_LMS.Employee
{
    public partial class EmployeeNav : Form
    {
        public string emp_ID = "";
        commonTools tool = new commonTools();

        public EmployeeNav(string username)
        {
            InitializeComponent();
            btnuser.Text = username;
            emp_ID = username;
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm log = new LoginForm();
            log.Show();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            LeaveApplication leave = new LeaveApplication(emp_ID);
            tool.navigate(leave,centralpanel);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePageEmp home = new HomePageEmp(emp_ID);
            tool.navigate(home,centralpanel);
        }

        private void EmployeeNav_Load(object sender, EventArgs e)
        {
            HomePageEmp home = new HomePageEmp(emp_ID);
            tool.navigate(home,centralpanel);
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            LeaveStatusForm leaveStatus = new LeaveStatusForm(emp_ID);
            tool.navigate(leaveStatus,centralpanel);
        }

        private void btnuser_MouseHover(object sender, EventArgs e)
        {
            btnuser.Text = "Logout";
            btnuser.IconChar = FontAwesome.Sharp.IconChar.SignOut;
        }

        private void btnuser_MouseLeave(object sender, EventArgs e)
        {
            btnuser.Text = emp_ID;
            btnuser.IconChar = FontAwesome.Sharp.IconChar.User;
        }
    }
}
