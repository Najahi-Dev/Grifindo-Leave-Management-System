using Grifindo_Sample_LMS.Common;
using Grifindo_Sample_LMS.Leave_Manage_Class;
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

namespace Grifindo_Sample_LMS.Employee
{
    public partial class LeaveApplication : Form
    {
        LeaveManagerClass leave = new LeaveManagerClass();
        commonTools tool = new commonTools();
        DBCommon db = new DBCommon();
        public string username = "";

        public LeaveApplication(string user)
        {
            InitializeComponent();
            lblempID.Text = user;
            username = user;
        }

        private void ClearFun()
        {
            lblempID.Text = username;
            cmbLeaveType.SelectedItem = string.Empty;
            dtpLeaveDate.Value = DateTime.Now;
            txtTimeSlot.Clear();
            txtReson.Clear();
        }

        private void btnapply_Click(object sender, EventArgs e)
        {
            DateTime leaveDate = dtpLeaveDate.Value;
            TimeSpan? shortLeaveTime = null;
            string employeeID = lblempID.Text;

            //====================================== Off Time and Half Day Validate =======================================================================
           
            if (leave.ValidateOffandHalfDays(leaveDate, employeeID))
            {
                string leaveType = cmbLeaveType.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(leaveType))
                {
                    MessageBox.Show("Please select a leave type");
                    return;
                }
                if (leaveType == "Short")
                {
                    if (!TimeSpan.TryParse(txtTimeSlot.Text, out TimeSpan parsedTime))
                    {
                        MessageBox.Show("Please enter a valid time slot (HH:mm format).");
                        return;
                    }
                    shortLeaveTime = parsedTime;
                }

                string reason = txtReson.Text;
                string result = leave.ApplyLeave(lblempID.Text, leaveType, leaveDate, shortLeaveTime, reason);

                MessageBox.Show(result);
                leave.LoadLeaveData(lblempID.Text);
            }
            ClearFun();

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            int leaveID = Convert.ToInt32(dgvLeaveApply.SelectedRows[0].Cells["LeaveID"].Value);
            string empID = lblempID.Text;

            string result = leave.cancelpendingleave(leaveID, empID);
            MessageBox.Show(result);
            leave.LoadLeaveData(lblempID.Text);
            ClearFun();
        }

        private void LeaveApplication_Load(object sender, EventArgs e)
        {
            tool.autocompletetext("SELECT LeaveID FROM tblLeave WHERE EmployeeID = '"+lblempID.Text+"' ", txtsearch, "LeaveID");
            leave.dgvLeave = dgvLeaveApply;
            leave.LoadLeaveData(lblempID.Text);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                db.con.Open();
                SqlCommand cmd = new SqlCommand("SELECT LeaveType,Date,TimeSlot,Reason FROM [tblLeave] WHERE (LeaveID = '" + txtsearch.Text + "')", db.con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbLeaveType.Text = rdr["LeaveType"].ToString();
                    dtpLeaveDate.Value = DateTime.Parse(rdr["Date"].ToString());
                    txtTimeSlot.Text = rdr["TimeSlot"].ToString();
                    txtReson.Text = rdr["Reason"].ToString();
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
    }
}
