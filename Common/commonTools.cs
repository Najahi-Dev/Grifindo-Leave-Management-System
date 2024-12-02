using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Grifindo_Sample_LMS.Common;
using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
using System.Windows.Interop;

namespace Grifindo_Sample_LMS
{
    internal class commonTools : DBCommon
    {
        //=================Form Load Function ================================
        internal void navigate(Form form, Panel panel)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.Show();
        }

        //=================================================================== PDF Generator =====================================================================
        internal void PdfGenerate(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf) |*.pdf";
                save.FileName = "Result.pdf";
                bool errorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception exp)
                        {
                            errorMessage = true;
                            MessageBox.Show("Error" + exp.Message);
                        }
                    }
                    if (!errorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(column.HeaderText));
                                pTable.AddCell(pCell);

                            }
                            foreach (DataGridViewRow row in dataGridView.Rows)
                            {
                                foreach (DataGridViewCell cells in row.Cells)
                                {
                                    pTable.AddCell(cells.Value.ToString());
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                PdfWriter pdfWriter = PdfWriter.GetInstance(document, fileStream);

                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "INFORMATION");

                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show("Error While exporting data" + exp.Message);
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("No record found", "INFORMATION");
            }
        }
        //=======================================================================================================================================


        //==================================================================== Search Function ===================================================
        internal void Search(string qry, DataGridView dataGridView) //Data Gridview Search
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);

                if (dt.Rows.Count > 0)
                {
                    dataGridView.DataSource = dt;
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
        }
        //====================================================================================================================================

        internal void autocompletetext(string qry, BunifuTextBox textbox, string name) //Serach box Auto complete
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    autoCompleteCollection.Add(rdr[name].ToString());
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

            textbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textbox.AutoCompleteCustomSource = autoCompleteCollection;

        }
        //========================================================= Cell Click Data Load =================================================================

        internal void LoadDatatoBoxes(DataGridView dataGrid, int rowIndex, Control[] controls)
        {
            try
            {
                if (rowIndex >= 0 && rowIndex < dataGrid.Rows.Count)
                {
                    foreach (Control control in controls)
                    {
                        string columnName = control.Tag?.ToString();

                        if (!string.IsNullOrEmpty(columnName) && dataGrid.Columns.Contains(columnName))
                        {
                            object cellValue = dataGrid.Rows[rowIndex].Cells[columnName].Value;

                            switch (control)
                            {
                                case BunifuTextBox textBox:
                                    textBox.Text = cellValue?.ToString();
                                    break;

                                case Guna2ComboBox comboBox:
                                    comboBox.SelectedItem = cellValue?.ToString();
                                    break;

                                case BunifuDatePicker dtPicker:
                                    if (DateTime.TryParse(cellValue?.ToString(), out DateTime dateValue))
                                    {
                                        dtPicker.Value = dateValue;
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Data Load Error");
            }
        }

        //=============================================================== Combo Box Code ========================================================
        internal void ComboBox(string sql, Guna2ComboBox comboBox)
        {
            try
            {
                con.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(ds);
                comboBox.DataSource = ds.Tables[0];
                comboBox.DisplayMember = ds.Tables[0].Columns[0].ToString();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                con.Close();
            }
        }
        //=======================================================================================================================================

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteNonQuery();
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
            return 0;
        }

        //============================================================================================================================
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters2 = null)
        {
            using(SqlConnection conn = new SqlConnection("Data Source=ANGRYBIRD\\SQLEXPRESS;Initial Catalog=Grifindo_Leave_System;Integrated Security=True;Encrypt=False"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters2 != null)
                    {
                        foreach (var param in parameters2)
                        {
                            cmd.Parameters.Add(new SqlParameter(param.ParameterName, param.Value));
                        }
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }

        }

        //=================================================================================================================================
        public object ExecuteScaler(string sql, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=ANGRYBIRD\\SQLEXPRESS;Initial Catalog=Grifindo_Leave_System;Integrated Security=True;Encrypt=False"))
            {
                using( SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        //===================================================================================================================================
        internal object ExecuteScalerWithoutPara(string sql)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=ANGRYBIRD\\SQLEXPRESS;Initial Catalog=Grifindo_Leave_System;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

    }
}
