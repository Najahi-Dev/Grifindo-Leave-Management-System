namespace Grifindo_Sample_LMS.Admin
{
    partial class LeaveApproval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveApproval));
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
            this.dgvLeaveRequest = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.btnApprove = new FontAwesome.Sharp.IconButton();
            this.btnsearch = new FontAwesome.Sharp.IconButton();
            this.txtsearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpLeaveDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.txtTimeSlot = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLeaveType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNote = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLeaveID = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveRequest)).BeginInit();
            this.SuspendLayout();
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
            this.dgvLeaveRequest.Location = new System.Drawing.Point(12, 287);
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
            this.dgvLeaveRequest.Size = new System.Drawing.Size(1292, 347);
            this.dgvLeaveRequest.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 130;
            this.label1.Text = "LEAVE APPROVAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(458, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 127;
            this.label4.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(201, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 129;
            this.label2.Text = "Employee ID";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemove.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnRemove.IconColor = System.Drawing.Color.White;
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemove.IconSize = 30;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(423, 228);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 39);
            this.btnRemove.TabIndex = 124;
            this.btnRemove.Text = "Reject";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnApprove.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btnApprove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btnApprove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnApprove.IconColor = System.Drawing.Color.White;
            this.btnApprove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnApprove.IconSize = 30;
            this.btnApprove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprove.Location = new System.Drawing.Point(181, 228);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(123, 39);
            this.btnApprove.TabIndex = 122;
            this.btnApprove.Text = "Approve";
            this.btnApprove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
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
            this.btnsearch.TabIndex = 126;
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
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtsearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtsearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtsearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtsearch.OnIdleState = stateProperties4;
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
            this.txtsearch.TabIndex = 125;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsearch.TextMarginBottom = 0;
            this.txtsearch.TextMarginLeft = 3;
            this.txtsearch.TextMarginTop = 0;
            this.txtsearch.TextPlaceholder = "Enter text";
            this.txtsearch.UseSystemPasswordChar = false;
            this.txtsearch.WordWrap = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 129;
            this.label3.Text = "Leave ID";
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
            this.dtpLeaveDate.Location = new System.Drawing.Point(462, 96);
            this.dtpLeaveDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpLeaveDate.Name = "dtpLeaveDate";
            this.dtpLeaveDate.Size = new System.Drawing.Size(185, 32);
            this.dtpLeaveDate.TabIndex = 137;
            this.dtpLeaveDate.Value = new System.DateTime(2024, 11, 29, 0, 0, 0, 0);
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
            this.txtTimeSlot.Location = new System.Drawing.Point(709, 92);
            this.txtTimeSlot.MaxLength = 32767;
            this.txtTimeSlot.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTimeSlot.Modified = false;
            this.txtTimeSlot.Multiline = false;
            this.txtTimeSlot.Name = "txtTimeSlot";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimeSlot.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTimeSlot.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimeSlot.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimeSlot.OnIdleState = stateProperties8;
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
            this.txtTimeSlot.TabIndex = 140;
            this.txtTimeSlot.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimeSlot.TextMarginBottom = 0;
            this.txtTimeSlot.TextMarginLeft = 3;
            this.txtTimeSlot.TextMarginTop = 0;
            this.txtTimeSlot.TextPlaceholder = "Enter text";
            this.txtTimeSlot.UseSystemPasswordChar = false;
            this.txtTimeSlot.WordWrap = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(705, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 139;
            this.label7.Text = "Time Slot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 129;
            this.label5.Text = "Leave Type";
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
            this.cmbLeaveType.Location = new System.Drawing.Point(166, 158);
            this.cmbLeaveType.Name = "cmbLeaveType";
            this.cmbLeaveType.Size = new System.Drawing.Size(199, 36);
            this.cmbLeaveType.TabIndex = 134;
            // 
            // txtNote
            // 
            this.txtNote.AcceptsReturn = false;
            this.txtNote.AcceptsTab = false;
            this.txtNote.AnimationSpeed = 200;
            this.txtNote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNote.BackColor = System.Drawing.Color.Transparent;
            this.txtNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNote.BackgroundImage")));
            this.txtNote.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNote.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNote.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNote.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtNote.BorderRadius = 15;
            this.txtNote.BorderThickness = 1;
            this.txtNote.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.DefaultFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.DefaultText = "";
            this.txtNote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            this.txtNote.ForeColor = System.Drawing.Color.White;
            this.txtNote.HideSelection = true;
            this.txtNote.IconLeft = null;
            this.txtNote.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.IconPadding = 10;
            this.txtNote.IconRight = null;
            this.txtNote.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.Lines = new string[0];
            this.txtNote.Location = new System.Drawing.Point(463, 158);
            this.txtNote.MaxLength = 32767;
            this.txtNote.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNote.Modified = false;
            this.txtNote.Multiline = false;
            this.txtNote.Name = "txtNote";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNote.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNote.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNote.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(87)))));
            stateProperties12.ForeColor = System.Drawing.Color.White;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNote.OnIdleState = stateProperties12;
            this.txtNote.Padding = new System.Windows.Forms.Padding(3);
            this.txtNote.PasswordChar = '\0';
            this.txtNote.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNote.PlaceholderText = "Enter text";
            this.txtNote.ReadOnly = false;
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNote.SelectedText = "";
            this.txtNote.SelectionLength = 0;
            this.txtNote.SelectionStart = 0;
            this.txtNote.ShortcutsEnabled = true;
            this.txtNote.Size = new System.Drawing.Size(444, 39);
            this.txtNote.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNote.TabIndex = 141;
            this.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNote.TextMarginBottom = 0;
            this.txtNote.TextMarginLeft = 3;
            this.txtNote.TextMarginTop = 0;
            this.txtNote.TextPlaceholder = "Enter text";
            this.txtNote.UseSystemPasswordChar = false;
            this.txtNote.WordWrap = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(399, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 142;
            this.label6.Text = "Note";
            // 
            // lblLeaveID
            // 
            this.lblLeaveID.AutoSize = true;
            this.lblLeaveID.BackColor = System.Drawing.Color.Transparent;
            this.lblLeaveID.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveID.ForeColor = System.Drawing.Color.DarkGray;
            this.lblLeaveID.Location = new System.Drawing.Point(28, 103);
            this.lblLeaveID.Name = "lblLeaveID";
            this.lblLeaveID.Size = new System.Drawing.Size(115, 20);
            this.lblLeaveID.TabIndex = 143;
            this.lblLeaveID.Text = "LEAVE REQUEST";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeID.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.Color.DarkGray;
            this.lblEmployeeID.Location = new System.Drawing.Point(201, 103);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(115, 20);
            this.lblEmployeeID.TabIndex = 143;
            this.lblEmployeeID.Text = "LEAVE REQUEST";
            // 
            // LeaveApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(1316, 653);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblLeaveID);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTimeSlot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpLeaveDate);
            this.Controls.Add(this.cmbLeaveType);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dgvLeaveRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeaveApproval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeaveApproval";
            this.Load += new System.EventHandler(this.LeaveApproval_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnRemove;
        private FontAwesome.Sharp.IconButton btnApprove;
        private FontAwesome.Sharp.IconButton btnsearch;
        private Bunifu.UI.WinForms.BunifuTextBox txtsearch;
        private System.Windows.Forms.DataGridView dgvLeaveRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpLeaveDate;
        private Bunifu.UI.WinForms.BunifuTextBox txtTimeSlot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLeaveType;
        private Bunifu.UI.WinForms.BunifuTextBox txtNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLeaveID;
        private System.Windows.Forms.Label lblEmployeeID;
    }
}