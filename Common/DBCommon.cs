using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Printing;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Grifindo_Sample_LMS.Common
{

    enum funnctionTypes
    {
        assign,
        update,
        delete,
        register,
        remove,
        approve
    }

    internal class DBCommon
    {
        internal SqlConnection con = new SqlConnection("Data Source=ANGRYBIRD\\SQLEXPRESS;Initial Catalog=Grifindo_Leave_System;Integrated Security=True;Encrypt=False");

        //=========================================================================================================================================
        internal string EmployeeID { get; set; }


        //==========================================================================================================================================
        internal interface LeaveStrategy
        {
            bool ApproveLeave(int dayRequested, int availableLeaves);
            int CalculateLeaveDays(DateTime startDate, DateTime endDate);
        }

        internal bool ExecuteQuery(string sql, funnctionTypes funtype)
        {
            bool functionRunStatus = false;
            string msg = "";
            bool functionStatus = false;

            try
            {
                //==================================================================== INSERT =============================================================================
                if (funtype == funnctionTypes.assign)
                {
                    if (MessageBox.Show("Do you want to  insert this data ?", "INSERT CONFIRMATION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        functionRunStatus = true;
                        msg = "Insert Successfully";
                    }
                }
                
                if (funtype == funnctionTypes.approve)
                {
                    if (MessageBox.Show("Do you want to  Approve this data ?", "APPROVED CONFIRMATION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        functionRunStatus = true;
                        msg = "Apporved Successfully";
                    }
                }
                //================================================================= UPDATE =============================================================================
                else if (funtype == funnctionTypes.update)
                {
                    if (MessageBox.Show("Do you want to  update this data ?", "UPDATE CONFIRMATION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        functionRunStatus = true;
                        msg = "Update Successfully";
                    }
                }
                
                else if (funtype == funnctionTypes.remove)
                {
                    if (MessageBox.Show("Do you want to  Remove this data ?", "REMOVE CONFIRMATION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        functionRunStatus = true;
                        msg = "Remove Successfully";
                    }
                }
                //================================================================= DELETE =============================================================================
                else if (funtype == funnctionTypes.delete)
                {
                    if (MessageBox.Show("Do you want to  delete this data ?", "DELETE CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        functionRunStatus = true;
                        msg = "Deleted Successfully";
                    }
                }
                //================================================================= REGISTER =============================================================================
                else if (funtype == funnctionTypes.register)
                {
                    if (MessageBox.Show("Do you want to  Register this data ?", "REGISTER CONFIRMATION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        functionRunStatus = true;
                        msg = "Register Successfully";
                    }
                }
                //========================================================== Main Functions ==============================================================================
                if (functionRunStatus)
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(sql, con);
                    int rowcount = cmd.ExecuteNonQuery();
                    if (rowcount > 0)
                    {
                        MessageBox.Show(msg);
                        functionStatus = true;
                    }
                    else
                        MessageBox.Show("Error");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                con.Close();
            }
            return functionStatus;
        }

        //======================================================================================================================================
        internal void LoadDataFromDB(string sql, DataGridView LoadTable) // ======== Grid View Load Functions ================ 
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                LoadTable.DataSource = dt;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //===========================================================================================================================================

        internal static DataTable GetData(string sql)
        {
            SqlConnection con = new SqlConnection("Data Source=ANGRYBIRD\\SQLEXPRESS;Initial Catalog=Grifindo_Leave_System;Integrated Security=True;Encrypt=False");
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Grifindo LMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return dt;
        }
    }
}
