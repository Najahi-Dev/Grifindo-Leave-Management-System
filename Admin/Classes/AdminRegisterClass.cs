using Grifindo_Sample_LMS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Sample_LMS.Admin.Classes
{
    internal class AdminRegisterClass : DBCommon
    {
        internal string Admin_ID { get; set; }
        internal string First_Name { get; set; }
        internal string Last_Name { get; set; }
        internal string Address { get; set; }
        internal DateTime Date_of_Birth { get; set; }
        internal string Email { get; set; }
        internal int Phone_Number { get; set; }
        internal string Password { get; set; }
        internal string Gender { get; set; }
        internal string Department { get; set; }
        internal DataGridView Admin_Register_GView { get; set; }

        internal void AdminReg()
        {
            string sql = "Insert Into Admin_Details (Admin_ID,First_Name,Last_Name,Address,Date_of_Birth,Email,Phone_Number,Password,Gender,Department) " +
                "Values('" + Admin_ID + "','" + First_Name + "','" + Last_Name + "','" + Address + "','" + Date_of_Birth + "','" + Email + "'," + Phone_Number + ",'" + Password + "','" + Gender + "','"+Department+"')";


            if (ExecuteQuery(sql, funnctionTypes.register))
            {
                ViewAdmin();
            }
        }

        internal void AdminEdit()
        {
            string sql = "Update Admin_Details SET Admin_ID = '" + Admin_ID + "',First_Name='" + First_Name + "',Last_Name='" + Last_Name + "',Address='" + Address + "',Date_of_Birth='" + Date_of_Birth + "',Email='" + Email + "',Phone_Number=" + Phone_Number + ",Password='" + Password + "',Gender='" + Gender + "' ,Department = '"+Department+"' " +
                "WHERE Admin_ID = '" + Admin_ID + "'";

            if (ExecuteQuery(sql, funnctionTypes.update))
            {
                ViewAdmin();
            }
        }

        internal void AdminRemove()
        {
            string sql = "Delete from Admin_Details Where Admin_ID ='" + Admin_ID + "'";

            if (ExecuteQuery(sql, funnctionTypes.delete))
            {
                ViewAdmin();
            }
        }

        internal void ViewAdmin()
        {
            string sql = "Select * From Admin_Details";
            LoadDataFromDB(sql, Admin_Register_GView);
        }
    }
}
