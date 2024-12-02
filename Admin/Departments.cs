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
using Grifindo_Sample_LMS.Admin.Classes;
using Grifindo_Sample_LMS.Common;
using Org.BouncyCastle.Asn1.Cmp;
using static Guna.UI2.Native.WinApi;

namespace Grifindo_Sample_LMS.Admin
{
    public partial class Departments : Form
    {
        DepartmentClass dept = new DepartmentClass();
        DBCommon db = new DBCommon();
        commonTools tool = new commonTools();

        public Departments()
        {
            InitializeComponent();
        }

        private void Departments_Load(object sender, EventArgs e)
        {
            txtdept.Focus();
            dept.DeptView = dgvDept;
            dept.View();
            tool.autocompletetext("SELECT Dep_ID FROM Department", txtsearch, "Dep_ID");

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            dept.Insert();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            dept.Delete();
        }

        private void txtdept_TextChanged(object sender, EventArgs e)
        {
            dept.Department_Name = txtdept.Text;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            tool.Search("SELECT * FROM Add_Employee WHERE Employee_ID = '" + txtsearch.Text + "'", dgvDept);
            try
            {
                db.con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Department] WHERE (Dep_ID = '" + txtsearch.Text + "')", db.con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtdept.Text = rdr.GetValue(1).ToString();
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
