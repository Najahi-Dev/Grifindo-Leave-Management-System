namespace Grifindo_Sample_LMS.Employee
{
    partial class LeaveStatusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveStatusForm));
            this.dgvLeaveStatus = new System.Windows.Forms.DataGridView();
            this.btnPrint = new FontAwesome.Sharp.IconButton();
            this.btnViewStatus = new FontAwesome.Sharp.IconButton();
            this.dtpfromDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dtptoDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLeaveType = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLeaveStatus
            // 
            this.dgvLeaveStatus.AllowUserToAddRows = false;
            this.dgvLeaveStatus.AllowUserToDeleteRows = false;
            this.dgvLeaveStatus.AllowUserToResizeColumns = false;
            this.dgvLeaveStatus.AllowUserToResizeRows = false;
            this.dgvLeaveStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLeaveStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaveStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.dgvLeaveStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeaveStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLeaveStatus.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeaveStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLeaveStatus.EnableHeadersVisualStyles = false;
            this.dgvLeaveStatus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.dgvLeaveStatus.Location = new System.Drawing.Point(12, 174);
            this.dgvLeaveStatus.Name = "dgvLeaveStatus";
            this.dgvLeaveStatus.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeaveStatus.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLeaveStatus.RowHeadersVisible = false;
            this.dgvLeaveStatus.RowHeadersWidth = 51;
            this.dgvLeaveStatus.RowTemplate.Height = 24;
            this.dgvLeaveStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaveStatus.Size = new System.Drawing.Size(1292, 365);
            this.dgvLeaveStatus.TabIndex = 162;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPrint.IconColor = System.Drawing.Color.White;
            this.btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrint.IconSize = 30;
            this.btnPrint.Location = new System.Drawing.Point(752, 569);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(55, 39);
            this.btnPrint.TabIndex = 156;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnViewStatus
            // 
            this.btnViewStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.btnViewStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewStatus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewStatus.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btnViewStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btnViewStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btnViewStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStatus.ForeColor = System.Drawing.Color.White;
            this.btnViewStatus.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.btnViewStatus.IconColor = System.Drawing.Color.White;
            this.btnViewStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewStatus.IconSize = 30;
            this.btnViewStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewStatus.Location = new System.Drawing.Point(577, 569);
            this.btnViewStatus.Name = "btnViewStatus";
            this.btnViewStatus.Size = new System.Drawing.Size(155, 39);
            this.btnViewStatus.TabIndex = 157;
            this.btnViewStatus.Text = "View Status";
            this.btnViewStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewStatus.UseVisualStyleBackColor = false;
            this.btnViewStatus.Click += new System.EventHandler(this.btnViewStatus_Click);
            // 
            // dtpfromDate
            // 
            this.dtpfromDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpfromDate.BorderRadius = 10;
            this.dtpfromDate.Color = System.Drawing.Color.Silver;
            this.dtpfromDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpfromDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpfromDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpfromDate.DisabledColor = System.Drawing.Color.Gray;
            this.dtpfromDate.DisplayWeekNumbers = false;
            this.dtpfromDate.DPHeight = 0;
            this.dtpfromDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpfromDate.FillDatePicker = false;
            this.dtpfromDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfromDate.ForeColor = System.Drawing.Color.White;
            this.dtpfromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfromDate.Icon = ((System.Drawing.Image)(resources.GetObject("dtpfromDate.Icon")));
            this.dtpfromDate.IconColor = System.Drawing.Color.White;
            this.dtpfromDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpfromDate.LeftTextMargin = 5;
            this.dtpfromDate.Location = new System.Drawing.Point(282, 103);
            this.dtpfromDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpfromDate.Name = "dtpfromDate";
            this.dtpfromDate.Size = new System.Drawing.Size(185, 32);
            this.dtpfromDate.TabIndex = 154;
            this.dtpfromDate.Value = new System.DateTime(2024, 11, 29, 0, 0, 0, 0);
            // 
            // dtptoDate
            // 
            this.dtptoDate.BackColor = System.Drawing.Color.Transparent;
            this.dtptoDate.BorderRadius = 10;
            this.dtptoDate.Color = System.Drawing.Color.Silver;
            this.dtptoDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtptoDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtptoDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtptoDate.DisabledColor = System.Drawing.Color.Gray;
            this.dtptoDate.DisplayWeekNumbers = false;
            this.dtptoDate.DPHeight = 0;
            this.dtptoDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtptoDate.FillDatePicker = false;
            this.dtptoDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtptoDate.ForeColor = System.Drawing.Color.White;
            this.dtptoDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptoDate.Icon = ((System.Drawing.Image)(resources.GetObject("dtptoDate.Icon")));
            this.dtptoDate.IconColor = System.Drawing.Color.White;
            this.dtptoDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtptoDate.LeftTextMargin = 5;
            this.dtptoDate.Location = new System.Drawing.Point(515, 103);
            this.dtptoDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtptoDate.Name = "dtptoDate";
            this.dtptoDate.Size = new System.Drawing.Size(185, 32);
            this.dtptoDate.TabIndex = 155;
            this.dtptoDate.Value = new System.DateTime(2024, 11, 29, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 161;
            this.label1.Text = "LEAVE STATUS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(511, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 159;
            this.label6.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(278, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 158;
            this.label4.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 159;
            this.label3.Text = "Leave Type";
            // 
            // cmbLeaveType
            // 
            this.cmbLeaveType.BackColor = System.Drawing.Color.Transparent;
            this.cmbLeaveType.BorderRadius = 10;
            this.cmbLeaveType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLeaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeaveType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.cmbLeaveType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLeaveType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLeaveType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.cmbLeaveType.ForeColor = System.Drawing.Color.White;
            this.cmbLeaveType.ItemHeight = 30;
            this.cmbLeaveType.Items.AddRange(new object[] {
            "All",
            "Annual",
            "Casual",
            "Short",
            "HalfDay"});
            this.cmbLeaveType.Location = new System.Drawing.Point(32, 99);
            this.cmbLeaveType.Name = "cmbLeaveType";
            this.cmbLeaveType.Size = new System.Drawing.Size(199, 36);
            this.cmbLeaveType.TabIndex = 164;
            // 
            // LeaveStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(1316, 653);
            this.Controls.Add(this.cmbLeaveType);
            this.Controls.Add(this.dgvLeaveStatus);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnViewStatus);
            this.Controls.Add(this.dtpfromDate);
            this.Controls.Add(this.dtptoDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeaveStatusForm";
            this.Text = "LeaveStatusForm";
            this.Load += new System.EventHandler(this.LeaveStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLeaveStatus;
        private FontAwesome.Sharp.IconButton btnPrint;
        private FontAwesome.Sharp.IconButton btnViewStatus;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpfromDate;
        private Bunifu.UI.WinForms.BunifuDatePicker dtptoDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLeaveType;
    }
}