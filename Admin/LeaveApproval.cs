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

namespace Grifindo_Sample_LMS.Admin
{
    public partial class LeaveApproval : Form
    {
        commonTools tools = new commonTools();
        LeaveManagerClass managerClass = new LeaveManagerClass();
        DBCommon db = new DBCommon();

        public LeaveApproval()
        {
            InitializeComponent();
        }

        private void LeaveApproval_Load(object sender, EventArgs e)
        {
            tools.autocompletetext("SELECT LeaveID FROM tblLeave WHERE Status = 'Pending'", txtsearch, "LeaveID");
            managerClass.dgvLeave = dgvLeaveRequest;
            managerClass.LoadLeaveRequest();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvLeaveRequest.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a leave request to approve or reject.","INFORMATION");
                return;
            }
            
            int leaveID = Convert.ToInt32(dgvLeaveRequest.SelectedRows[0].Cells["LeaveID"].Value);
            string empID = dgvLeaveRequest.SelectedRows[0].Cells["Employee ID"].Value.ToString();
            string leaveType = dgvLeaveRequest.SelectedRows[0].Cells["Leave Type"].Value.ToString();

            string sql = " UPDATE tblLeave SET Status = 'Approved', AdminComment = '"+txtNote.Text+"' WHERE LeaveID = @leaveID ";
            SqlParameter[] parameters = { new SqlParameter("@leaveID", leaveID) };

            int result = tools.ExecuteNonQuery(sql, parameters);

            if (result > 0)
            {
                managerClass.DeductLeaveBalance(empID, leaveType);
                managerClass.LoadLeaveRequest();
                MessageBox.Show("Leave apporved and Balance updated successfully");
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                db.con.Open();
                SqlCommand cmd = new SqlCommand("SELECT LeaveID,EmployeeID,LeaveType,Date,TimeSlot FROM [tblLeave] WHERE (LeaveID = '" + txtsearch.Text + "')", db.con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lblLeaveID.Text = rdr["LeaveID"].ToString();
                    lblEmployeeID.Text = rdr["EmployeeID"].ToString();
                    cmbLeaveType.Text = rdr["LeaveType"].ToString();
                    dtpLeaveDate.Value = DateTime.Parse(rdr["Date"].ToString());
                    txtTimeSlot.Text = rdr["TimeSlot"].ToString();
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvLeaveRequest.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a leave request to approve or reject.", "INFORMATION");
                return;
            }

            int leaveID = Convert.ToInt32(dgvLeaveRequest.SelectedRows[0].Cells["LeaveID"].Value);

            string sql = " UPDATE tblLeave SET Status = 'Rejected', AdminComment = '" + txtNote.Text + "' WHERE LeaveID = @leaveID ";
            SqlParameter[] parameters = { new SqlParameter("@leaveID", leaveID) };

            int result = tools.ExecuteNonQuery(sql, parameters);

            if (result > 0)
            {
                managerClass.LoadLeaveRequest();
                MessageBox.Show("Leave rejected and Balance updated successfully");
            }
        }
    }
}
