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
using System.Windows.Forms.DataVisualization.Charting;
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Grifindo_Sample_LMS
{
    public partial class homePage : Form
    {
        DBCommon db = new DBCommon();
        commonTools tools = new commonTools();
        string username = "";

        public homePage(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void LoadAdmDetails()
        {
            string sql = "SELECT Admin_ID as [Admin ID],Last_Name as [Name],Password,Department FROM Admin_Details WHERE Admin_ID = '"+username+"' ";
            db.LoadDataFromDB(sql, dgvAdm);
        }

        private void ApproveLeaveSummary()
        {
            string sql = "SELECT  YEAR(Date) AS Year, DATENAME(MONTH, Date) AS [Month Name], COUNT(*) AS [Approved Count] " +
                "FROM tblLeave " +
                "GROUP BY  YEAR(Date), DATENAME(MONTH, Date), MONTH(Date) " +
                "ORDER BY YEAR(Date), MONTH(Date);";
            db.LoadDataFromDB(sql,dgvLeaveRequest);
        }


        //============================================= Employee Count Function ==================================================================
       
        internal int EmployeeCount()
        {
            string sql = "SELECT COUNT(*) FROM Add_Employee";
            try
            {
                object result = tools.ExecuteScalerWithoutPara(sql);

                return Convert.ToInt32(result);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return 0;
            }
        }

        internal void UpdateEmpCountProg()
        {
            int EmpCount = EmployeeCount();
            proEmpCount.Value = EmpCount;
            proEmpCount.Maximum = EmpCount;
        }


        //============================================ Admin Count Functions =====================================================================
       
        internal int AdminCount()
        {
            string sql = "SELECT COUNT(*) FROM  Admin_Details";
            try
            {
                object result = tools.ExecuteScalerWithoutPara(sql);

                return Convert.ToInt32(result);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return 0;
            }
        }

        internal void UpdateAdmCountProg()
        {
            int AdmCount = AdminCount();
            proAdmCount.Value = AdmCount;
            proAdmCount.Maximum = AdmCount;
        }
        //======================================================================================================================================

        //============================================ Admin Count Functions =====================================================================

        internal int LeaveRquestCount()
        {
            string sql = "SELECT COUNT(*) FROM tblLeave WHERE Status = 'Pending'";
            try
            {
                object result = tools.ExecuteScalerWithoutPara(sql);

                return Convert.ToInt32(result);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return 0;
            }
        }

        internal void UpdateRequestCountProg()
        {
            int ReqCount = LeaveRquestCount();
            proLeaveRequest.Value = ReqCount;
            proLeaveRequest.Maximum = ReqCount;
        }
        //======================================================================================================================================

        private void homePage_Load(object sender, EventArgs e)
        {
            UpdateEmpCountProg();
            UpdateAdmCountProg();
            UpdateRequestCountProg();
            ApproveLeaveSummary();
            LoadAdmDetails();
        }
    }
}
