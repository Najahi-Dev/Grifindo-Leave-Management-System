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
    public partial class AssignHoliday : Form
    {
        commonTools tool = new commonTools();
        DBCommon db = new DBCommon();

        public AssignHoliday()
        {
            InitializeComponent();
        }

        private void AssignHoliday_Load(object sender, EventArgs e)
        {
            LoadHoliday();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DateTime holidayDate = dtpHoliday.Value;
            string holidayDescription = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(holidayDescription))
            {
                MessageBox.Show("Please enter a description for the holiday");
                return;
            }

            string sql = " INSERT INTO tblHoliday(HolidayDate,Description) VALUES(@holidaydate,@descrip) ";
            SqlParameter[] parameters =
            {
                new SqlParameter("@holidaydate",holidayDate),
                new SqlParameter("@descrip",holidayDescription)
            };

            try
            {
                int result = tool.ExecuteNonQuery(sql, parameters);
                if (result > 0)
                {
                    MessageBox.Show("Holiday added successfully!", "Success");
                    LoadHoliday();
                }
                else
                {
                    MessageBox.Show("Failed to add holiday. Please try again.", "Error");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        internal void LoadHoliday()
        {
            string sql = "SELECT HolidayDate as [Holiday Date],Description FROM tblHoliday";
            db.LoadDataFromDB(sql,dgvHoliday);
        }
    }
}
