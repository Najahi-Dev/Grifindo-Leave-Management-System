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
using Grifindo_Sample_LMS.Common;
using Grifindo_Sample_LMS.Leave_Manage_Class;
using Org.BouncyCastle.Asn1.Cmp;

namespace Grifindo_Sample_LMS.Admin
{
    public partial class RosterManage : Form
    {
        RosterClass roster = new RosterClass();
        commonTools tool = new commonTools();
        DBCommon db = new DBCommon();

        public RosterManage()
        {
            InitializeComponent();
        }

        internal void ColumnAssign()
        {
            txtempID.Tag = "Employee_ID";
            dtpStartTime.Tag = "StartTime";
            dtpEndTime.Tag = "EndTime";
        }


        private void btnAssign_Click(object sender, EventArgs e)
        {
            string empId = txtempID.Text;
            TimeSpan startTime = dtpStartTime.Value.TimeOfDay;
            TimeSpan endTime = dtpEndTime.Value.TimeOfDay;

            roster.DefineRoster(empId,startTime,endTime);
        }

        private void RosterManage_Load(object sender, EventArgs e)
        {
            tool.ComboBox("SELECT Employee_ID FROM Add_Employee",txtempID);
            tool.autocompletetext("SELECT Employee_ID FROM tblRoster",txtsearch,"Employee_ID");
            ColumnAssign();
            roster.RosterDGV = dgvRoster;
            roster.ViewRoster();
        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tool.LoadDatatoBoxes(dgvRoster, e.RowIndex, new Control[]
            {
                txtempID, dtpStartTime, dtpEndTime
            });
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RosterMangeCLass rostercls = new RosterMangeCLass();
            string employeeId = txtempID.Text;

            if (string.IsNullOrEmpty(employeeId))
            {
                MessageBox.Show("Please enter a valid Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                rostercls.DeleteRoster(employeeId);
                roster.ViewRoster();
            }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            tool.Search("Select tblRoster.Employee_ID as [Employee ID], Add_Employee.Last_Name as [Name] ,tblRoster.StartTime as [Roster Start], tblRoster.EndTime as [Roster End] from tblRoster " +
                "JOIN Add_Employee " +
                "ON tblRoster.Employee_ID = Add_Employee.Employee_ID WHERE tblRoster.Employee_ID= '" + txtsearch.Text + "'", dgvRoster);
            try
            {
                db.con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [tblRoster] WHERE (Employee_ID = '" + txtsearch.Text + "')", db.con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtempID.Text = rdr.GetValue(1).ToString();
                    dtpStartTime.Value = Convert.ToDateTime(rdr.GetValue(2).ToString());
                    dtpEndTime.Value = Convert.ToDateTime(rdr.GetValue(3).ToString());
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RosterMangeCLass rostercls = new RosterMangeCLass();
            string employeeId = txtsearch.Text;
            TimeSpan newstart = dtpStartTime.Value.TimeOfDay;
            TimeSpan newend = dtpEndTime.Value.TimeOfDay;

            if (string.IsNullOrEmpty(employeeId))
            {
                MessageBox.Show("Please enter a valid Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            rostercls.UpdateRoster(employeeId, newstart, newend);
            roster.ViewRoster();
        }
    }
}
