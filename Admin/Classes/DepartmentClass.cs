using Grifindo_Sample_LMS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Sample_LMS.Admin.Classes
{
    internal class DepartmentClass : DBCommon
    {
        internal int Department_ID { get; set; }
        internal string Department_Name { get; set; }
        internal DataGridView DeptView { get; set; }

        internal void Insert()
        {
            string sql = "INSERT INTO Department(Department) VALUES('" + Department_Name + "')";
            ExecuteQuery(sql, funnctionTypes.register);
            View();
        }

        internal void Delete()
        {
            string sql = "DELETE FROM Department WHERE Dep_ID = "+Department_ID+" ";
            ExecuteQuery(sql, funnctionTypes.remove);
            View();
        }

        internal void View()
        {
            string sql = "SELECT * FROM Department";
            LoadDataFromDB(sql, DeptView);
        }
    }
}
