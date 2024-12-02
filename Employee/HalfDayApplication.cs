using Grifindo_Sample_LMS.Leave_Manage_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Sample_LMS.Employee
{
    public partial class HalfDayApplication : Form
    {
        HalfDayLeave half = new HalfDayLeave();
        commonTools tool = new commonTools();

        public HalfDayApplication(string user)
        {
            InitializeComponent();
            lblempID.Text = user;
        }

        private void HalfDayApplication_Load(object sender, EventArgs e)
        {
            half.dgvHalfDay = dgvHalfDay;
            half.ViewHalfDay(lblempID.Text);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string empId = lblempID.Text;
            DateTime leaveDate = dtpDate.Value;
            string timeSlot = rbtnMorning.Checked ? "Morning" : "Afternoon";
            string reason = txtReson.Text;

            if (string.IsNullOrEmpty(empId))
            {
                MessageBox.Show("Please enter Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Please enter a reason for leave.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (half.ApplyHalfDayLeave(empId,leaveDate,timeSlot,reason))
            {
                txtReson.Clear();
                rbtnMorning.Checked = false;
                rbtnAfternoon.Checked = false;
                dtpDate.Value = DateTime.Now;
            }
        }
    }
}
