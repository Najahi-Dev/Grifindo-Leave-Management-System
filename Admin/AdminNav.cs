using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grifindo_Sample_LMS.Admin;
using Grifindo_Sample_LMS.Common;

namespace Grifindo_Sample_LMS
{
    public partial class AdminNav : Form
    {
        commonTools tool = new commonTools();

        public AdminNav(string username)
        {
            InitializeComponent();
            btnuserIcon.Text = username;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            homePage home = new homePage(btnuserIcon.Text);
            tool.navigate(home,centralpanel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            homePage home = new homePage(btnuserIcon.Text);
            tool.navigate(home, centralpanel);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminRegister register = new AdminRegister();
            tool.navigate(register,centralpanel);
        }

        private void btnloginApprove_Click(object sender, EventArgs e)
        {
            AssignHoliday holi = new AssignHoliday();
            tool.navigate(holi,centralpanel);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmpRegister empRegister = new EmpRegister();
            tool.navigate(empRegister,centralpanel);
        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            Departments dept = new Departments();
            tool.navigate(dept,centralpanel);
        }

        private void btnuserIcon_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm log = new LoginForm();
            log.Show();
        }

        private void btnRoster_Click_1(object sender, EventArgs e)
        {
            RosterManage roster = new RosterManage();
            tool.navigate(roster, centralpanel);
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            LeaveManage leave = new LeaveManage();
            tool.navigate(leave,centralpanel);
        }

        private void btnApproval_Click(object sender, EventArgs e)
        {
            LeaveApproval approval=new LeaveApproval();
            tool.navigate(approval,centralpanel);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            tool.navigate(report,centralpanel);
        }
    }
}
