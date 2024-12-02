using Grifindo_Sample_LMS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Sample_LMS.Admin.Classes
{
    internal class LoginApprovalClass : DBCommon
    {
        internal int UserID { get; set; }
        internal string Username { get; set; }
        internal string Password { get; set; }
        internal string Role { get; set; }
        internal DataGridView DGVUsers { get; set; }

        internal void Approve()
        {
            string sql = "INSERT INTO User_Login(Username,Password,Role) VALUES('" + Username + "','" + Password + "','" + Role + "')";

            if (ExecuteQuery(sql, funnctionTypes.approve))
            {
                View();
            }
        }

        internal void Remove()
        {
            string sql = "DELETE FROM User_Login WHERE Username = '" + Username + "'";

            if (ExecuteQuery(sql, funnctionTypes.remove))
            {
                View();
            }
        }

        internal void View()
        {
            String sql = "SELECT * FROM User_Login";
            LoadDataFromDB(sql, DGVUsers);
        }
    }
}
