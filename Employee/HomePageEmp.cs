using Grifindo_Sample_LMS.Common;
using iTextSharp.text;
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
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Markup;

namespace Grifindo_Sample_LMS.Employee
{
    public partial class HomePageEmp : Form
    {
        DBCommon db = new DBCommon();
        commonTools tool = new commonTools();

        public string username = "";

        public HomePageEmp(string user)
        {
            InitializeComponent();
            username = user;
        }

        internal void LoadEmpDetails()
        {
            string sql = " SELECT Employee_ID as [Emp ID],Last_Name as [Name],Password,Role,Job_Title as [Job Title], Department FROM Add_Employee WHERE Employee_ID = '" + username + "' ";
            db.LoadDataFromDB(sql, dgvEmp);
        }

        internal void LoadHoliday()
        {
            string sql = "SELECT HolidayDate as [Holiday Date],Description FROM tblHoliday";
            db.LoadDataFromDB(sql, dgvHolidays);
        }

        internal void LoadRosterTime()
        {
            string sql = " SELECT StartTime as [Start], EndTime as [End] FROM tblRoster WHERE Employee_ID = '" + username + "' ";
            db.LoadDataFromDB(sql, dgvRoster);
        }

        internal void labelLoad()
        {
            string sql = " SELECT OffDay FROM tblEmployeeLeave WHERE EmployeeID = '" + username + "' ";
            db.con.Open();
            SqlCommand cmd = new SqlCommand(sql, db.con);
            string offday = (string)cmd.ExecuteScalar();
            lbloffday.Text = offday.ToString();
            db.con.Close();
        }

        //================================================================= Balance Leave Count ========================================================================
        public void LoadLeaveProgress(string employeeID)
        {
            string sql = " SELECT AnnualLeave, CasualLeave, ShortLeave,HalfDayLeave FROM tblEmployeeLeave WHERE EmployeeID = @empid ";
            SqlParameter[] parameters =
            {
                new SqlParameter("@empid",employeeID)
            };

            try
            {
                DataTable dt  = tool.ExecuteQuery(sql, parameters);

                if (dt.Rows.Count > 0)
                {
                    int annualLeave = Convert.ToInt32(dt.Rows[0]["AnnualLeave"]);
                    int casualLeave = Convert.ToInt32(dt.Rows[0]["CasualLeave"]);
                    int shortLeave = Convert.ToInt32(dt.Rows[0]["ShortLeave"]);
                    int halfdayLeave = Convert.ToInt32(dt.Rows[0]["HalfDayLeave"]);

                    proAnnual.Value = annualLeave;
                    proCasual.Value = casualLeave;
                    proShort.Value = shortLeave;
                    proHalfDay.Value = halfdayLeave;

                    proAnnual.Maximum = 14;
                    proCasual.Maximum = 7;
                    proShort.Maximum = 2;
                    proHalfDay.Maximum = 5;
                }
                else
                {
                    MessageBox.Show("No data found for the specified employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        //================================================================== Applied Half Day Count =====================================================================
        //internal int AppliedHalfDayCount(string empID)
        //{
        //    string sql = "SELECT COUNT(*) FROM tblLeave WHERE LeaveType = 'HalfDay' AND EmployeeID = @empid ";
        //    SqlParameter[] parameters =
        //    {
        //        new SqlParameter("@empid",empID)
        //    };

        //    try
        //    {
        //        object result = tool.ExecuteScaler(sql, parameters);

        //        return Convert.ToInt32(result);
        //    }
        //    catch (Exception exp)
        //    {
        //        MessageBox.Show(exp.Message);
        //        return 0;
        //    }

        //}

        //internal void UpdateHalfDayProg(string empID)
        //{
        //    int HalfDayCount = AppliedHalfDayCount(username);
        //    proHalfDay.Value = HalfDayCount;
        //    proHalfDay.Maximum = HalfDayCount;
        //}
        //===========================================================================================================================================================

        private void HomePageEmp_Load(object sender, EventArgs e)
        {
            LoadLeaveProgress(username);
            //UpdateHalfDayProg(username);
            LoadHoliday();
            labelLoad();
            LoadRosterTime();
            LoadEmpDetails();
        }
    }
}
