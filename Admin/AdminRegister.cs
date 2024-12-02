using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grifindo_Sample_LMS.Admin.Classes;
using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using System.Data.SqlClient;
using Grifindo_Sample_LMS.Common;

namespace Grifindo_Sample_LMS.Admin
{
    public partial class AdminRegister : Form
    {
        commonTools tool = new commonTools();
        AdminRegisterClass adm = new AdminRegisterClass();
        DBCommon db = new DBCommon();

        public AdminRegister()
        {
            InitializeComponent();
        }

        internal void ColumnAssign() // Assign Column name in COntrols(textbox, combo box and Date Time Picker)
        {
            txtadmID.Tag = "Admin_ID";
            txtfirstName.Tag = "First_Name";
            txtlastname.Tag = "Last_Name";
            txtaddress.Tag = "Address";
            dtpDOB.Tag = "Date_of_Birth";
            txtemail.Tag = "Email";
            txtphonenumber.Tag = "Phone_Number";
            txtpassword.Tag = "Password";
            cmbGender.Tag = "Gender";
            cmbDept.Tag = "Department";

        }

        private void AdminRegister_Load(object sender, EventArgs e)
        {
            txtadmID.Focus();
            adm.Admin_Register_GView = dgvAdm;
            adm.ViewAdmin();
            ColumnAssign();
            tool.ComboBox("SELECT Department FROM Department", cmbDept);
            tool.autocompletetext("Select Admin_ID From Admin_Details", txtsearch, "Admin_ID");
        }

        private void dgvAdm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvAdm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tool.LoadDatatoBoxes(dgvAdm, e.RowIndex, new Control[]
           {
                 txtadmID, txtfirstName, txtlastname, txtaddress, dtpDOB, txtemail, txtphonenumber, txtpassword,cmbGender,cmbDept
           });
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            adm.AdminReg();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            adm.AdminEdit();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            adm.AdminRemove();
        }

        private void txtadmID_TextChanged(object sender, EventArgs e)
        {
            adm.Admin_ID = txtadmID.Text;
        }

        private void txtfirstName_TextChanged(object sender, EventArgs e)
        {
            adm.First_Name = txtfirstName.Text;
        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {
            adm.Last_Name = txtlastname.Text;
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            adm.Date_of_Birth = dtpDOB.Value;
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            adm.Email = txtemail.Text;
        }

        private void txtphonenumber_TextChanged(object sender, EventArgs e)
        {
            adm.Phone_Number = int.Parse(txtphonenumber.Text);
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            adm.Password = txtpassword.Text;
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            adm.Gender = cmbGender.Text;
        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {
            adm.Address = txtaddress.Text;
        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            adm.Department = cmbDept.Text;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            tool.Search("Select * From Admin_Details WHERE Admin_ID = '"+txtsearch.Text+"'",dgvAdm);
        }
    }
}
