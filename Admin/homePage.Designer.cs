namespace Grifindo_Sample_LMS
{
    partial class homePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.proEmpCount = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.proAdmCount = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.proLeaveRequest = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLeaveRequest = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvAdm = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdm)).BeginInit();
            this.SuspendLayout();
            // 
            // proEmpCount
            // 
            this.proEmpCount.Animated = false;
            this.proEmpCount.AnimationInterval = 1;
            this.proEmpCount.AnimationSpeed = 1;
            this.proEmpCount.BackColor = System.Drawing.Color.Transparent;
            this.proEmpCount.CircleMargin = 10;
            this.proEmpCount.Font = new System.Drawing.Font("Trebuchet MS", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proEmpCount.ForeColor = System.Drawing.Color.White;
            this.proEmpCount.IsPercentage = false;
            this.proEmpCount.LineProgressThickness = 10;
            this.proEmpCount.LineThickness = 10;
            this.proEmpCount.Location = new System.Drawing.Point(111, 61);
            this.proEmpCount.Maximum = 1000;
            this.proEmpCount.Name = "proEmpCount";
            this.proEmpCount.ProgressAnimationSpeed = 200;
            this.proEmpCount.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.proEmpCount.ProgressColor = System.Drawing.SystemColors.Highlight;
            this.proEmpCount.ProgressColor2 = System.Drawing.Color.DarkViolet;
            this.proEmpCount.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.proEmpCount.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Gradient;
            this.proEmpCount.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.proEmpCount.SecondaryFont = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proEmpCount.Size = new System.Drawing.Size(188, 188);
            this.proEmpCount.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.proEmpCount.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.proEmpCount.SubScriptText = "Employee";
            this.proEmpCount.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.proEmpCount.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.proEmpCount.SuperScriptText = "";
            this.proEmpCount.TabIndex = 17;
            this.proEmpCount.Text = "30";
            this.proEmpCount.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.proEmpCount.Value = 30;
            this.proEmpCount.ValueByTransition = 30;
            this.proEmpCount.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // proAdmCount
            // 
            this.proAdmCount.Animated = false;
            this.proAdmCount.AnimationInterval = 1;
            this.proAdmCount.AnimationSpeed = 1;
            this.proAdmCount.BackColor = System.Drawing.Color.Transparent;
            this.proAdmCount.CircleMargin = 10;
            this.proAdmCount.Font = new System.Drawing.Font("Trebuchet MS", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proAdmCount.ForeColor = System.Drawing.Color.White;
            this.proAdmCount.IsPercentage = false;
            this.proAdmCount.LineProgressThickness = 10;
            this.proAdmCount.LineThickness = 10;
            this.proAdmCount.Location = new System.Drawing.Point(565, 61);
            this.proAdmCount.Name = "proAdmCount";
            this.proAdmCount.ProgressAnimationSpeed = 200;
            this.proAdmCount.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.proAdmCount.ProgressColor = System.Drawing.Color.BurlyWood;
            this.proAdmCount.ProgressColor2 = System.Drawing.Color.BlueViolet;
            this.proAdmCount.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.proAdmCount.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Gradient;
            this.proAdmCount.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.proAdmCount.SecondaryFont = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proAdmCount.Size = new System.Drawing.Size(188, 188);
            this.proAdmCount.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.proAdmCount.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.proAdmCount.SubScriptText = "Admin";
            this.proAdmCount.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.proAdmCount.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.proAdmCount.SuperScriptText = "";
            this.proAdmCount.TabIndex = 18;
            this.proAdmCount.Text = "30";
            this.proAdmCount.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.proAdmCount.Value = 30;
            this.proAdmCount.ValueByTransition = 30;
            this.proAdmCount.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // proLeaveRequest
            // 
            this.proLeaveRequest.Animated = false;
            this.proLeaveRequest.AnimationInterval = 1;
            this.proLeaveRequest.AnimationSpeed = 1;
            this.proLeaveRequest.BackColor = System.Drawing.Color.Transparent;
            this.proLeaveRequest.CircleMargin = 10;
            this.proLeaveRequest.Font = new System.Drawing.Font("Trebuchet MS", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proLeaveRequest.ForeColor = System.Drawing.Color.White;
            this.proLeaveRequest.IsPercentage = false;
            this.proLeaveRequest.LineProgressThickness = 10;
            this.proLeaveRequest.LineThickness = 10;
            this.proLeaveRequest.Location = new System.Drawing.Point(1013, 61);
            this.proLeaveRequest.Name = "proLeaveRequest";
            this.proLeaveRequest.ProgressAnimationSpeed = 200;
            this.proLeaveRequest.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.proLeaveRequest.ProgressColor = System.Drawing.Color.IndianRed;
            this.proLeaveRequest.ProgressColor2 = System.Drawing.Color.Violet;
            this.proLeaveRequest.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.proLeaveRequest.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Gradient;
            this.proLeaveRequest.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.proLeaveRequest.SecondaryFont = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proLeaveRequest.Size = new System.Drawing.Size(188, 188);
            this.proLeaveRequest.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.proLeaveRequest.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.proLeaveRequest.SubScriptText = "Requests";
            this.proLeaveRequest.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.proLeaveRequest.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.proLeaveRequest.SuperScriptText = "";
            this.proLeaveRequest.TabIndex = 19;
            this.proLeaveRequest.Text = "30";
            this.proLeaveRequest.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.proLeaveRequest.Value = 30;
            this.proLeaveRequest.ValueByTransition = 30;
            this.proLeaveRequest.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(145, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 120;
            this.label1.Text = "Toatal Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(604, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 120;
            this.label2.Text = "Toatal Admins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(1044, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 120;
            this.label3.Text = "Leave Requests";
            // 
            // dgvLeaveRequest
            // 
            this.dgvLeaveRequest.AllowUserToAddRows = false;
            this.dgvLeaveRequest.AllowUserToDeleteRows = false;
            this.dgvLeaveRequest.AllowUserToResizeColumns = false;
            this.dgvLeaveRequest.AllowUserToResizeRows = false;
            this.dgvLeaveRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLeaveRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaveRequest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.dgvLeaveRequest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeaveRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLeaveRequest.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeaveRequest.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLeaveRequest.EnableHeadersVisualStyles = false;
            this.dgvLeaveRequest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.dgvLeaveRequest.Location = new System.Drawing.Point(424, 464);
            this.dgvLeaveRequest.Name = "dgvLeaveRequest";
            this.dgvLeaveRequest.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeaveRequest.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLeaveRequest.RowHeadersVisible = false;
            this.dgvLeaveRequest.RowHeadersWidth = 51;
            this.dgvLeaveRequest.RowTemplate.Height = 24;
            this.dgvLeaveRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaveRequest.Size = new System.Drawing.Size(479, 157);
            this.dgvLeaveRequest.TabIndex = 165;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(511, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 21);
            this.label5.TabIndex = 164;
            this.label5.Text = "Approved Leave Request Summary";
            // 
            // dgvAdm
            // 
            this.dgvAdm.AllowUserToAddRows = false;
            this.dgvAdm.AllowUserToDeleteRows = false;
            this.dgvAdm.AllowUserToResizeColumns = false;
            this.dgvAdm.AllowUserToResizeRows = false;
            this.dgvAdm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.dgvAdm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAdm.ColumnHeadersHeight = 35;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdm.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAdm.EnableHeadersVisualStyles = false;
            this.dgvAdm.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.dgvAdm.Location = new System.Drawing.Point(12, 320);
            this.dgvAdm.Name = "dgvAdm";
            this.dgvAdm.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdm.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAdm.RowHeadersVisible = false;
            this.dgvAdm.RowHeadersWidth = 51;
            this.dgvAdm.RowTemplate.Height = 24;
            this.dgvAdm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdm.Size = new System.Drawing.Size(1292, 67);
            this.dgvAdm.TabIndex = 167;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(590, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 21);
            this.label7.TabIndex = 166;
            this.label7.Text = "Personal Details";
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(1316, 653);
            this.Controls.Add(this.dgvAdm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvLeaveRequest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proLeaveRequest);
            this.Controls.Add(this.proAdmCount);
            this.Controls.Add(this.proEmpCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "homePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homePage";
            this.Load += new System.EventHandler(this.homePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuCircleProgress proEmpCount;
        private Bunifu.UI.WinForms.BunifuCircleProgress proAdmCount;
        private Bunifu.UI.WinForms.BunifuCircleProgress proLeaveRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLeaveRequest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvAdm;
        private System.Windows.Forms.Label label7;
    }
}