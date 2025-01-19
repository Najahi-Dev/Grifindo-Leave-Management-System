using Grifindo_Sample_LMS.Admin.Classes;
using Grifindo_Sample_LMS.Common;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class LeaveManage : Form
    {
        EmployeeLeaveClass leaveClass = new EmployeeLeaveClass();
        commonTools tool = new commonTools();
        DBCommon db = new DBCommon();

        public LeaveManage()
        {
            InitializeComponent();
        }

        internal void ColumnAssign()
        {
            cmbEmpID.Tag = "EmployeeID";
            txtAnnual.Tag = "AnnualLeave";
            txtCasual.Tag = "CasualLeave";
            txtShort.Tag = "ShortLeave";
        }

        private void LeaveManage_Load(object sender, EventArgs e)
        {
            tool.autocompletetext("SELECT EmployeeID FROM tblEmployeeLeave",txtsearch,"EmployeeID");
            leaveClass.dgvLeave = dgvLeaveType;
            leaveClass.ViewLeave();
            tool.ComboBox("SELECT Employee_ID FROM Add_Employee",cmbEmpID);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string employeeID = cmbEmpID.Text;
            int annual = int.Parse(txtAnnual.Text);
            int casual = int.Parse(txtCasual.Text);
            int shortleave = int.Parse(txtShort.Text);
            string offday = cmbOffDay.Text;
            int halfday = int.Parse(txtHalfDay.Text);

            leaveClass.AssignLeave(employeeID, annual, casual, shortleave,offday,halfday);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAnnual.Clear();
            txtCasual.Clear();
            txtShort.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string employeeID = cmbEmpID.Text;
            int annual = int.Parse(txtAnnual.Text);
            int casual = int.Parse(txtCasual.Text);
            int shortleave = int.Parse(txtShort.Text);
            string offday = cmbOffDay.Text;
            int halfday = int.Parse(txtHalfDay.Text);

            leaveClass.UpdateLeave(employeeID,annual, casual, shortleave, offday,halfday);
        }

        private void dgvLeaveType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ColumnAssign();
            tool.LoadDatatoBoxes(dgvLeaveType, e.RowIndex, new Control[]
            {
                cmbEmpID,txtAnnual, txtCasual, txtShort
            });
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            tool.Search(" SELECT tblEmployeeLeave.EmployeeID as [Employee ID], Add_Employee.Last_Name as [Name], tblEmployeeLeave.AnnualLeave as [Annual Count], tblEmployeeLeave.CasualLeave as [Casual Count], " +
                "tblEmployeeLeave.ShortLeave as [Short Count], tblEmployeeLeave.OffDay as [Off Day],tblEmployeeLeave.HalfDayLeave as [Half Day] FROM tblEmployeeLeave " +
                "JOIN Add_Employee ON tblEmployeeLeave.EmployeeID = Add_Employee.Employee_ID WHERE tblEmployeeLeave.EmployeeID = '"+txtsearch.Text+"' ", dgvLeaveType);

            try
            {
                db.con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [tblEmployeeLeave] WHERE (EmployeeID = '" + txtsearch.Text + "')", db.con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbEmpID.Text = rdr.GetValue(1).ToString();
                    txtAnnual.Text = rdr.GetValue(2).ToString();
                    txtCasual.Text = rdr.GetValue(3).ToString();
                    txtShort.Text = rdr.GetValue(4).ToString();
                    cmbOffDay.Text = rdr.GetValue(6).ToString();
                    txtHalfDay.Text = rdr.GetValue(7).ToString();
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
            leaveClass.DeleteLeave(cmbEmpID.Text);
        }
    }
}
