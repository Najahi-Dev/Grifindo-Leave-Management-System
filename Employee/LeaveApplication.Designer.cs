namespace Grifindo_Sample_LMS.Employee
{
    partial class LeaveApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveApplication));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.dgvLeaveApply = new System.Windows.Forms.DataGridView();
            this.cmbLeaveType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimeSlot = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtReson = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btncancel = new FontAwesome.Sharp.IconButton();
            this.btnapply = new FontAwesome.Sharp.IconButton();
            this.btnsearch = new FontAwesome.Sharp.IconButton();
            this.txtsearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dtpLeaveDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.lblempID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveApply)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLeaveApply
            // 
            this.dgvLeaveApply.AllowUserToAddRows = false;
            this.dgvLeaveApply.AllowUserToDeleteRows = false;
            this.dgvLeaveApply.AllowUserToResizeColumns = false;
            this.dgvLeaveApply.AllowUserToResizeRows = false;
            this.dgvLeaveApply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLeaveApply.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaveApply.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.dgvLeaveApply.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeaveApply.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLeaveApply.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeaveApply.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLeaveApply.EnableHeadersVisualStyles = false;
            this.dgvLeaveApply.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.dgvLeaveApply.Location = new System.Drawing.Point(12, 304);
            this.dgvLeaveApply.Name = "dgvLeaveApply";
            this.dgvLeaveApply.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeaveApply.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLeaveApply.RowHeadersVisible = false;
            this.dgvLeaveApply.RowHeadersWidth = 51;
            this.dgvLeaveApply.RowTemplate.Height = 24;
            this.dgvLeaveApply.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaveApply.Size = new System.Drawing.Size(1292, 337);
            this.dgvLeaveApply.TabIndex = 136;
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
            "Annual",
            "Casual",
            "Short",
            "HalfDay"});
            this.cmbLeaveType.Location = new System.Drawing.Point(229, 99);
            this.cmbLeaveType.Name = "cmbLeaveType";
            this.cmbLeaveType.Size = new System.Drawing.Size(199, 36);
            this.cmbLeaveType.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 135;
            this.label1.Text = "LEAVE REQUEST";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(720, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 125;
            this.label7.Text = "Time Slot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(473, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 131;
            this.label6.Text = "Leave Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(225, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 130;
            this.label4.Text = "Leave Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 134;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 139;
            this.label3.Text = "Reason";
            // 
            // txtTimeSlot
            // 
            this.txtTimeSlot.AcceptsReturn = false;
            this.txtTimeSlot.AcceptsTab = false;
            this.txtTimeSlot.AnimationSpeed = 200;
            this.txtTimeSlot.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTimeSlot.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTimeSlot.BackColor = System.Drawing.Color.Transparent;
            this.txtTimeSlot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTimeSlot.BackgroundImage")));
            this.txtTimeSlot.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTimeSlot.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTimeSlot.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTimeSlot.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTimeSlot.BorderRadius = 15;
            this.txtTimeSlot.BorderThickness = 1;
            this.txtTimeSlot.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimeSlot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeSlot.DefaultFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeSlot.DefaultText = "";
            this.txtTimeSlot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.txtTimeSlot.ForeColor = System.Drawing.Color.White;
            this.txtTimeSlot.HideSelection = true;
            this.txtTimeSlot.IconLeft = null;
            this.txtTimeSlot.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeSlot.IconPadding = 10;
            this.txtTimeSlot.IconRight = null;
            this.txtTimeSlot.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeSlot.Lines = new string[0];
            this.txtTimeSlot.Location = new System.Drawing.Point(724, 103);
            this.txtTimeSlot.MaxLength = 32767;
            this.txtTimeSlot.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTimeSlot.Modified = false;
            this.txtTimeSlot.Multiline = false;
            this.txtTimeSlot.Name = "txtTimeSlot";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimeSlot.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTimeSlot.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimeSlot.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimeSlot.OnIdleState = stateProperties4;
            this.txtTimeSlot.Padding = new System.Windows.Forms.Padding(3);
            this.txtTimeSlot.PasswordChar = '\0';
            this.txtTimeSlot.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTimeSlot.PlaceholderText = "Enter text";
            this.txtTimeSlot.ReadOnly = false;
            this.txtTimeSlot.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimeSlot.SelectedText = "";
            this.txtTimeSlot.SelectionLength = 0;
            this.txtTimeSlot.SelectionStart = 0;
            this.txtTimeSlot.ShortcutsEnabled = true;
            this.txtTimeSlot.Size = new System.Drawing.Size(199, 36);
            this.txtTimeSlot.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTimeSlot.TabIndex = 138;
            this.txtTimeSlot.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimeSlot.TextMarginBottom = 0;
            this.txtTimeSlot.TextMarginLeft = 3;
            this.txtTimeSlot.TextMarginTop = 0;
            this.txtTimeSlot.TextPlaceholder = "Enter text";
            this.txtTimeSlot.UseSystemPasswordChar = false;
            this.txtTimeSlot.WordWrap = true;
            // 
            // txtReson
            // 
            this.txtReson.AcceptsReturn = false;
            this.txtReson.AcceptsTab = false;
            this.txtReson.AnimationSpeed = 200;
            this.txtReson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtReson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtReson.BackColor = System.Drawing.Color.Transparent;
            this.txtReson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtReson.BackgroundImage")));
            this.txtReson.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtReson.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtReson.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtReson.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtReson.BorderRadius = 15;
            this.txtReson.BorderThickness = 1;
            this.txtReson.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtReson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReson.DefaultFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReson.DefaultText = "";
            this.txtReson.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.txtReson.ForeColor = System.Drawing.Color.White;
            this.txtReson.HideSelection = true;
            this.txtReson.IconLeft = null;
            this.txtReson.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReson.IconPadding = 10;
            this.txtReson.IconRight = null;
            this.txtReson.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReson.Lines = new string[0];
            this.txtReson.Location = new System.Drawing.Point(133, 155);
            this.txtReson.MaxLength = 32767;
            this.txtReson.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtReson.Modified = false;
            this.txtReson.Multiline = false;
            this.txtReson.Name = "txtReson";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtReson.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtReson.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtReson.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtReson.OnIdleState = stateProperties8;
            this.txtReson.Padding = new System.Windows.Forms.Padding(3);
            this.txtReson.PasswordChar = '\0';
            this.txtReson.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtReson.PlaceholderText = "Enter text";
            this.txtReson.ReadOnly = false;
            this.txtReson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReson.SelectedText = "";
            this.txtReson.SelectionLength = 0;
            this.txtReson.SelectionStart = 0;
            this.txtReson.ShortcutsEnabled = true;
            this.txtReson.Size = new System.Drawing.Size(444, 39);
            this.txtReson.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtReson.TabIndex = 138;
            this.txtReson.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReson.TextMarginBottom = 0;
            this.txtReson.TextMarginLeft = 3;
            this.txtReson.TextMarginTop = 0;
            this.txtReson.TextPlaceholder = "Enter text";
            this.txtReson.UseSystemPasswordChar = false;
            this.txtReson.WordWrap = true;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btncancel.IconColor = System.Drawing.Color.White;
            this.btncancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancel.IconSize = 30;
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(539, 226);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(123, 39);
            this.btncancel.TabIndex = 121;
            this.btncancel.Text = "Cancel";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnapply
            // 
            this.btnapply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.btnapply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnapply.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnapply.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btnapply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btnapply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btnapply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnapply.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapply.ForeColor = System.Drawing.Color.White;
            this.btnapply.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnapply.IconColor = System.Drawing.Color.White;
            this.btnapply.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnapply.IconSize = 30;
            this.btnapply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnapply.Location = new System.Drawing.Point(367, 226);
            this.btnapply.Name = "btnapply";
            this.btnapply.Size = new System.Drawing.Size(123, 39);
            this.btnapply.TabIndex = 120;
            this.btnapply.Text = "Apply";
            this.btnapply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnapply.UseVisualStyleBackColor = false;
            this.btnapply.Click += new System.EventHandler(this.btnapply_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnsearch.IconColor = System.Drawing.Color.White;
            this.btnsearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsearch.IconSize = 30;
            this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearch.Location = new System.Drawing.Point(1133, 14);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(40, 30);
            this.btnsearch.TabIndex = 124;
            this.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.AcceptsReturn = false;
            this.txtsearch.AcceptsTab = false;
            this.txtsearch.AnimationSpeed = 200;
            this.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtsearch.BackColor = System.Drawing.Color.Transparent;
            this.txtsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtsearch.BackgroundImage")));
            this.txtsearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtsearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtsearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtsearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtsearch.BorderRadius = 20;
            this.txtsearch.BorderThickness = 1;
            this.txtsearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.DefaultFont = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.DefaultText = "";
            this.txtsearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.txtsearch.ForeColor = System.Drawing.Color.White;
            this.txtsearch.HideSelection = true;
            this.txtsearch.IconLeft = null;
            this.txtsearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.IconPadding = 10;
            this.txtsearch.IconRight = null;
            this.txtsearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.Lines = new string[0];
            this.txtsearch.Location = new System.Drawing.Point(884, 12);
            this.txtsearch.MaxLength = 32767;
            this.txtsearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtsearch.Modified = false;
            this.txtsearch.Multiline = false;
            this.txtsearch.Name = "txtsearch";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtsearch.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtsearch.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtsearch.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            stateProperties12.ForeColor = System.Drawing.Color.White;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtsearch.OnIdleState = stateProperties12;
            this.txtsearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtsearch.PlaceholderText = "Enter text";
            this.txtsearch.ReadOnly = false;
            this.txtsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsearch.SelectedText = "";
            this.txtsearch.SelectionLength = 0;
            this.txtsearch.SelectionStart = 0;
            this.txtsearch.ShortcutsEnabled = true;
            this.txtsearch.Size = new System.Drawing.Size(300, 36);
            this.txtsearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtsearch.TabIndex = 123;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsearch.TextMarginBottom = 0;
            this.txtsearch.TextMarginLeft = 3;
            this.txtsearch.TextMarginTop = 0;
            this.txtsearch.TextPlaceholder = "Enter text";
            this.txtsearch.UseSystemPasswordChar = false;
            this.txtsearch.WordWrap = true;
            // 
            // dtpLeaveDate
            // 
            this.dtpLeaveDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpLeaveDate.BorderRadius = 10;
            this.dtpLeaveDate.Color = System.Drawing.Color.Silver;
            this.dtpLeaveDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpLeaveDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpLeaveDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpLeaveDate.DisabledColor = System.Drawing.Color.Gray;
            this.dtpLeaveDate.DisplayWeekNumbers = false;
            this.dtpLeaveDate.DPHeight = 0;
            this.dtpLeaveDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpLeaveDate.FillDatePicker = false;
            this.dtpLeaveDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLeaveDate.ForeColor = System.Drawing.Color.White;
            this.dtpLeaveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLeaveDate.Icon = ((System.Drawing.Image)(resources.GetObject("dtpLeaveDate.Icon")));
            this.dtpLeaveDate.IconColor = System.Drawing.Color.White;
            this.dtpLeaveDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpLeaveDate.LeftTextMargin = 5;
            this.dtpLeaveDate.Location = new System.Drawing.Point(477, 103);
            this.dtpLeaveDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpLeaveDate.Name = "dtpLeaveDate";
            this.dtpLeaveDate.Size = new System.Drawing.Size(185, 32);
            this.dtpLeaveDate.TabIndex = 113;
            this.dtpLeaveDate.Value = new System.DateTime(2024, 11, 29, 0, 0, 0, 0);
            // 
            // lblempID
            // 
            this.lblempID.AutoSize = true;
            this.lblempID.BackColor = System.Drawing.Color.Transparent;
            this.lblempID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempID.ForeColor = System.Drawing.Color.DarkGray;
            this.lblempID.Location = new System.Drawing.Point(33, 103);
            this.lblempID.Name = "lblempID";
            this.lblempID.Size = new System.Drawing.Size(119, 20);
            this.lblempID.TabIndex = 135;
            this.lblempID.Text = "LEAVE REQUEST";
            // 
            // LeaveApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(1316, 653);
            this.Controls.Add(this.txtTimeSlot);
            this.Controls.Add(this.txtReson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvLeaveApply);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnapply);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.cmbLeaveType);
            this.Controls.Add(this.dtpLeaveDate);
            this.Controls.Add(this.lblempID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeaveApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeaveApplication";
            this.Load += new System.EventHandler(this.LeaveApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveApply)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLeaveApply;
        private FontAwesome.Sharp.IconButton btncancel;
        private FontAwesome.Sharp.IconButton btnapply;
        private FontAwesome.Sharp.IconButton btnsearch;
        private Bunifu.UI.WinForms.BunifuTextBox txtsearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLeaveType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpLeaveDate;
        private Bunifu.UI.WinForms.BunifuTextBox txtReson;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuTextBox txtTimeSlot;
        private System.Windows.Forms.Label lblempID;
    }
}