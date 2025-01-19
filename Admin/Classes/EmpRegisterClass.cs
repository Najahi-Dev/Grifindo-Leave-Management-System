using Grifindo_Sample_LMS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Sample_LMS.Admin.Classes
{
    internal class EmpRegisterClass : DBCommon
    {
        internal string Employee_ID { get; set; }
        internal string First_Name { get; set; }
        internal string Last_Name { get; set; }
        internal string Gender { get; set; }
        internal DateTime Date_of_Birth { get; set; }
        internal string Address { get; set; }
        internal string Email { get; set; }
        internal int Phone_Number { get; set; }
        internal int Password { get; set; }
        internal string Employee_Status { get; set; }
        internal DateTime Join_Date { get; set; }
        internal string Job_Title { get; set; }
        internal string Role { get; set; }
        internal string Department { get; set; }
        internal DataGridView Employee_Register_GView { get; set; }


        internal void EmployeeReg()
        {
            string sql = "Insert Into Add_Employee(Employee_ID,First_Name, Last_Name,Address,Date_of_Birth,Email,Phone_Number,Password,Employee_Status,Date_of_Joining,Gender,Role,Job_Title,Department) " +
                "Values('" + Employee_ID + "','" + First_Name + "','" + Last_Name + "','" + Address + "','" + Date_of_Birth + "','" + Email + "'," + Phone_Number + ",'" + Password + "'," +
                "'" + Employee_Status + "','" + Join_Date + "','" + Gender + "','" + Role + "','" + Job_Title + "','" + Department + "')";

            if (ExecuteQuery(sql, funnctionTypes.register))
            {
                ViewEmployee();
            }
        }

        internal void EmployeeEdit()
        {
            string sql = "UPDATE Add_Employee SET Employee_ID = '" + Employee_ID + "', First_Name = '" + First_Name + "', Last_Name = '" + Last_Name + "', Address = '" + Address + "'," +
                " Date_of_Birth = '" + Date_of_Birth + "', Email = '" + Email + "', Phone_Number = " + Phone_Number + ", Password = " + Password + ", Employee_Status = '" + Employee_Status + "', " +
                "Date_of_Joining = '" + Join_Date + "', Gender = '" + Gender + "',Role = '" + Role + "', Job_Title = '" + Job_Title + "', Department = '" + Department + "' WHERE Employee_ID = '" + Employee_ID + "'";

            if (ExecuteQuery(sql, funnctionTypes.update))
            {
                ViewEmployee();
            }
        }

        internal void EmployeeRemove()
        {
            string sql = "DELETE FROM Add_Employee  WHERE Employee_ID ='" + Employee_ID + "'";

            if (ExecuteQuery(sql, funnctionTypes.remove))
            {
                ViewEmployee();
            }
        }

        internal void ViewEmployee()
        {
            string sql = "Select * from Add_Employee";
            LoadDataFromDB(sql, Employee_Register_GView);
        }
    }
}
