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
    public partial class ReportForm : Form
    {
        DBCommon db = new DBCommon();
        commonTools tool = new commonTools();

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            tool.autocompletetext("SELECT EmployeeID FROM tblLeave", txtEmpID, "EmployeeID");
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            string employeeID = txtEmpID.Text.Trim();
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date can not be after end date.", "Validation Error");
                return;
            }

            string sql;
            SqlParameter[] parameters;
            if (string.IsNullOrEmpty(employeeID))
            {
                sql = " SELECT tblLeave.LeaveID as [Leave ID], tblLeave.EmployeeID as [Employee ID], " +
                    "Add_Employee.Last_Name as [Name], tblLeave.LeaveType as [Type], tblLeave.Date as [Leave Date], tblLeave.Status as[Status], tblLeave.AdminComment as [Note] " +
                    "FROM tblLeave JOIN Add_Employee ON tblLeave.EmployeeID = Add_Employee.Employee_ID WHERE tblLeave.Date BETWEEN @startDate AND @endDate; ";

                parameters = new SqlParameter[]
                {
                    new SqlParameter("@startDate",startDate),
                    new SqlParameter("@endDate",endDate)
                };
            }

            else
            {
                sql = " SELECT tblLeave.LeaveID as [Leave ID], tblLeave.EmployeeID as [Employee ID], " +
                    "Add_Employee.Last_Name as [Name], tblLeave.LeaveType as [Type], tblLeave.Date as [Leave Date], tblLeave.Status as[Status], tblLeave.AdminComment as [Note] " +
                    "FROM tblLeave JOIN Add_Employee ON tblLeave.EmployeeID = Add_Employee.Employee_ID WHERE  tblLeave.EmployeeID = @empid AND tblLeave.Date BETWEEN @startDate AND @endDate; ";

                parameters = new SqlParameter[]
                {
                    new SqlParameter("@startDate",startDate),
                    new SqlParameter("@endDate",endDate),
                    new SqlParameter("@empid",employeeID)
                };
            }

            try
            {
                DataTable dt = tool.ExecuteQuery(sql, parameters);
                dgvLeaveReport.DataSource = dt;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            tool.PdfGenerate(dgvLeaveReport);
        }
    }
}
