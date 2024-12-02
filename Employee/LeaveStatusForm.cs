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
    public partial class LeaveStatusForm : Form
    {
        commonTools tool = new commonTools();

        public string EmployeeID = "";

        public LeaveStatusForm(string user)
        {
            InitializeComponent();
            EmployeeID = user;
        }

        private void btnViewStatus_Click(object sender, EventArgs e)
        {
            string leaveType = cmbLeaveType.SelectedItem?.ToString();
            DateTime fromdate = dtpfromDate.Value.Date;
            DateTime todate = dtptoDate.Value.Date;

            if (todate < fromdate)
            {
                MessageBox.Show("Start date can not be after end date.", "Validation Error");
                return;
            }

            string sql = " SELECT LeaveID as [Leave ID], LeaveType as [Leave Type], Date, Status, AdminComment as [Note],AppliedDate as [Applied Date] " +
                "FROM tblLeave WHERE EmployeeID = @empid AND Date >= @fromdate AND Date <= @todate ";

            if (!string.IsNullOrEmpty(leaveType) && leaveType != "All")
            {
                sql += "AND LeaveType = @leavetype";
            }

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@empid",EmployeeID),
                new SqlParameter("@fromdate",fromdate),
                new SqlParameter("@todate",todate)
            };

            if (!string.IsNullOrEmpty(leaveType) && leaveType != "All")
            {
                parameters.Add(new SqlParameter("@leavetype", leaveType));
            }

            try
            {
                DataTable dt = tool.ExecuteQuery(sql, parameters.ToArray());
                dgvLeaveStatus.DataSource = dt;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void LeaveStatusForm_Load(object sender, EventArgs e)
        {

        }
    }
}
