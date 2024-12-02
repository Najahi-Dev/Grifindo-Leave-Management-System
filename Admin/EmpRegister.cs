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

namespace Grifindo_Sample_LMS.Admin
{
    public partial class EmpRegister : Form
    {
        EmpRegisterClass emp = new EmpRegisterClass();
        commonTools tool = new commonTools();
        DBCommon db = new DBCommon();

        public EmpRegister()
        {
            InitializeComponent();
        }

        internal void ColumnAssign()
        {
            txtempID.Tag = "Emloyee_ID";
            txtfirstName.Tag = "First_Name";
            txtlastname.Tag = "Last_Name";
            txtaddress.Tag = "Address";
            dtpDOB.Tag = "Date_of_Birth";
            txtemail.Tag = "Email";
            txtphonenumber.Tag = "Phone_Number";
            txtpassword.Tag = "Password";
            cmbstatus.Tag = "Employee_Status";
            dtpJoinDate.Tag = "Date_of_Joining";
            cmbGender.Tag = "Gender";
            txtrole.Tag = "Role";
            txtjobTitle.Tag = "Job_Title";
            cmbDept.Tag = "Department";

        }

        private void EmpRegister_Load(object sender, EventArgs e)
        {
            tool.ComboBox("SELECT Department FROM Department",cmbDept);
            ColumnAssign();
            txtempID.Focus();
            emp.Employee_Register_GView = dgvEmp;
            emp.ViewEmployee();
            tool.autocompletetext("SELECT Employee_ID FROM Add_Employee",txtsearch,"Employee_ID");
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            tool.Search("SELECT * FROM Add_Employee WHERE Employee_ID = '"+txtsearch.Text+"'", dgvEmp);
            try
            {
                db.con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Add_Employee] WHERE (Employee_ID = '" + txtsearch.Text + "')", db.con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtempID.Text = rdr.GetValue(0).ToString();
                    txtfirstName.Text = rdr.GetValue(1).ToString();
                    txtlastname.Text = rdr.GetValue(2).ToString();
                    txtaddress.Text = rdr.GetValue(3).ToString();
                    dtpDOB.Value = Convert.ToDateTime(rdr.GetValue(4).ToString());
                    txtemail.Text = rdr.GetValue(5).ToString();
                    txtphonenumber.Text = rdr.GetValue(6).ToString();
                    txtpassword.Text = rdr.GetValue(7).ToString();
                    cmbstatus.Text = rdr.GetValue(8).ToString();
                    dtpJoinDate.Value = Convert.ToDateTime(rdr.GetValue(9).ToString());
                    cmbGender.Text = rdr.GetValue(10).ToString();
                    txtrole.Text = rdr.GetValue(11).ToString();
                    txtjobTitle.Text = rdr.GetValue(12).ToString();
                    cmbDept.Text = rdr.GetValue(13).ToString();
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

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tool.LoadDatatoBoxes(dgvEmp, e.RowIndex, new Control[]
            {
                txtempID, txtfirstName, txtlastname, txtaddress, dtpDOB, txtemail, txtphonenumber, txtpassword, cmbstatus, dtpJoinDate, cmbGender, txtrole, txtjobTitle, cmbDept
            });
        }

        private void txtempID_TextChanged(object sender, EventArgs e)
        {
            emp.Employee_ID = txtempID.Text;
        }

        private void txtfirstName_TextChanged(object sender, EventArgs e)
        {
            emp.First_Name = txtfirstName.Text;
        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {
            emp.Last_Name = txtlastname.Text;
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            emp.Date_of_Birth = dtpDOB.Value;
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            emp.Email = txtemail.Text;
        }

        private void txtphonenumber_TextChanged(object sender, EventArgs e)
        {
            emp.Phone_Number = int.Parse(txtphonenumber.Text);
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            emp.Password = int.Parse(txtpassword.Text);
        }

        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            emp.Employee_Status = cmbstatus.Text;
        }

        private void dtpJoinDate_ValueChanged(object sender, EventArgs e)
        {
            emp.Join_Date = dtpJoinDate.Value;
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            emp.Gender = cmbGender.Text;
        }

        private void txtjobTitle_TextChanged(object sender, EventArgs e)
        {
            emp.Job_Title = txtjobTitle.Text;
        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            emp.Department = cmbDept.Text;
        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {
            emp.Address = txtaddress.Text;
        }

        private void txtrole_TextChanged(object sender, EventArgs e)
        {
            emp.Role = txtrole.Text;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            emp.EmployeeReg();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            emp.EmployeeEdit();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            emp.EmployeeRemove();
        }
    }
}
