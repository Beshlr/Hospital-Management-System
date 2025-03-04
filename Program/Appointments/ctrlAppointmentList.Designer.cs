namespace Hospital_Management_System.Appointments
{
    partial class ctrlAppointmentList
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

        #region Component Designer generated code

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
            this.dgvAppointments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.txtSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbxSearchFilter = new System.Windows.Forms.PictureBox();
            this.gbxFilterBy = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbtnDepartment = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnStatus = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnDoctorName = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnPatientName = new Guna.UI2.WinForms.Guna2RadioButton();
            this.pnlFilterBy = new System.Windows.Forms.Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblScreenTitle = new System.Windows.Forms.Label();
            this.pbxScreenImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearchFilter)).BeginInit();
            this.gbxFilterBy.SuspendLayout();
            this.pnlFilterBy.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlSearchBar.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScreenImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointments.ColumnHeadersHeight = 25;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppointments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAppointments.Location = new System.Drawing.Point(0, 316);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAppointments.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAppointments.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAppointments.RowTemplate.Height = 40;
            this.dgvAppointments.Size = new System.Drawing.Size(1052, 444);
            this.dgvAppointments.TabIndex = 8;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAppointments.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAppointments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAppointments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAppointments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAppointments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAppointments.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvAppointments.ThemeStyle.ReadOnly = true;
            this.dgvAppointments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAppointments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAppointments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAppointments.ThemeStyle.RowsStyle.Height = 40;
            this.dgvAppointments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAppointments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cbxStatus
            // 
            this.cbxStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Scheduled",
            "Confirmed",
            "Pending",
            "Cancelled by Patient",
            "Cancelled by Doctor",
            "Rescheduled",
            "Missed"});
            this.cbxStatus.Location = new System.Drawing.Point(37, 121);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(205, 28);
            this.cbxStatus.TabIndex = 9;
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSearchBar.Animated = true;
            this.txtSearchBar.AutoRoundedCorners = true;
            this.txtSearchBar.BorderRadius = 15;
            this.txtSearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBar.DefaultText = "";
            this.txtSearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBar.FillColor = System.Drawing.Color.DarkGray;
            this.txtSearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchBar.ForeColor = System.Drawing.Color.Black;
            this.txtSearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBar.IconRight = global::Hospital_Management_System.Properties.Resources._211817_search_strong_icon;
            this.txtSearchBar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearchBar.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtSearchBar.Location = new System.Drawing.Point(12, 120);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.PasswordChar = '\0';
            this.txtSearchBar.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchBar.PlaceholderText = "Enter Patient\'s Text";
            this.txtSearchBar.SelectedText = "";
            this.txtSearchBar.Size = new System.Drawing.Size(263, 32);
            this.txtSearchBar.TabIndex = 6;
            // 
            // pbxSearchFilter
            // 
            this.pbxSearchFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbxSearchFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSearchFilter.Image = global::Hospital_Management_System.Properties.Resources._4781833_filter_filters_funnel_list_navigation_icon;
            this.pbxSearchFilter.Location = new System.Drawing.Point(289, 122);
            this.pbxSearchFilter.Name = "pbxSearchFilter";
            this.pbxSearchFilter.Size = new System.Drawing.Size(29, 30);
            this.pbxSearchFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSearchFilter.TabIndex = 8;
            this.pbxSearchFilter.TabStop = false;
            // 
            // gbxFilterBy
            // 
            this.gbxFilterBy.Controls.Add(this.rbtnDepartment);
            this.gbxFilterBy.Controls.Add(this.rbtnStatus);
            this.gbxFilterBy.Controls.Add(this.rbtnDoctorName);
            this.gbxFilterBy.Controls.Add(this.rbtnPatientName);
            this.gbxFilterBy.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.gbxFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbxFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbxFilterBy.Location = new System.Drawing.Point(4, 14);
            this.gbxFilterBy.Name = "gbxFilterBy";
            this.gbxFilterBy.Size = new System.Drawing.Size(259, 97);
            this.gbxFilterBy.TabIndex = 9;
            this.gbxFilterBy.Tag = "Department";
            this.gbxFilterBy.Text = "Filter By";
            // 
            // rbtnDepartment
            // 
            this.rbtnDepartment.AutoSize = true;
            this.rbtnDepartment.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnDepartment.CheckedState.BorderThickness = 0;
            this.rbtnDepartment.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnDepartment.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnDepartment.CheckedState.InnerOffset = -4;
            this.rbtnDepartment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnDepartment.Location = new System.Drawing.Point(156, 67);
            this.rbtnDepartment.Name = "rbtnDepartment";
            this.rbtnDepartment.Size = new System.Drawing.Size(88, 19);
            this.rbtnDepartment.TabIndex = 3;
            this.rbtnDepartment.Tag = "Department";
            this.rbtnDepartment.Text = "Department";
            this.rbtnDepartment.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnDepartment.UncheckedState.BorderThickness = 2;
            this.rbtnDepartment.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnDepartment.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtnStatus
            // 
            this.rbtnStatus.AutoSize = true;
            this.rbtnStatus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnStatus.CheckedState.BorderThickness = 0;
            this.rbtnStatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnStatus.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnStatus.CheckedState.InnerOffset = -4;
            this.rbtnStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnStatus.Location = new System.Drawing.Point(10, 67);
            this.rbtnStatus.Name = "rbtnStatus";
            this.rbtnStatus.Size = new System.Drawing.Size(57, 19);
            this.rbtnStatus.TabIndex = 2;
            this.rbtnStatus.Tag = "Status";
            this.rbtnStatus.Text = "Status";
            this.rbtnStatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnStatus.UncheckedState.BorderThickness = 2;
            this.rbtnStatus.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnStatus.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtnDoctorName
            // 
            this.rbtnDoctorName.AutoSize = true;
            this.rbtnDoctorName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnDoctorName.CheckedState.BorderThickness = 0;
            this.rbtnDoctorName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnDoctorName.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnDoctorName.CheckedState.InnerOffset = -4;
            this.rbtnDoctorName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnDoctorName.Location = new System.Drawing.Point(156, 33);
            this.rbtnDoctorName.Name = "rbtnDoctorName";
            this.rbtnDoctorName.Size = new System.Drawing.Size(96, 19);
            this.rbtnDoctorName.TabIndex = 1;
            this.rbtnDoctorName.Text = "Doctor Name";
            this.rbtnDoctorName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnDoctorName.UncheckedState.BorderThickness = 2;
            this.rbtnDoctorName.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnDoctorName.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtnPatientName
            // 
            this.rbtnPatientName.AutoSize = true;
            this.rbtnPatientName.Checked = true;
            this.rbtnPatientName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnPatientName.CheckedState.BorderThickness = 0;
            this.rbtnPatientName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnPatientName.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnPatientName.CheckedState.InnerOffset = -4;
            this.rbtnPatientName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnPatientName.Location = new System.Drawing.Point(10, 33);
            this.rbtnPatientName.Name = "rbtnPatientName";
            this.rbtnPatientName.Size = new System.Drawing.Size(97, 19);
            this.rbtnPatientName.TabIndex = 0;
            this.rbtnPatientName.TabStop = true;
            this.rbtnPatientName.Text = "Patient Name";
            this.rbtnPatientName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnPatientName.UncheckedState.BorderThickness = 2;
            this.rbtnPatientName.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnPatientName.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // pnlFilterBy
            // 
            this.pnlFilterBy.Controls.Add(this.gbxFilterBy);
            this.pnlFilterBy.Location = new System.Drawing.Point(327, 38);
            this.pnlFilterBy.Name = "pnlFilterBy";
            this.pnlFilterBy.Size = new System.Drawing.Size(265, 115);
            this.pnlFilterBy.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Cairo Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(10, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 32);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.White;
            this.pnlControls.Controls.Add(this.pnlSearchBar);
            this.pnlControls.Controls.Add(this.pnlAdd);
            this.pnlControls.Controls.Add(this.pnlFilterBy);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControls.Location = new System.Drawing.Point(0, 158);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1052, 158);
            this.pnlControls.TabIndex = 18;
            // 
            // pnlSearchBar
            // 
            this.pnlSearchBar.Controls.Add(this.cbxStatus);
            this.pnlSearchBar.Controls.Add(this.txtSearchBar);
            this.pnlSearchBar.Controls.Add(this.pbxSearchFilter);
            this.pnlSearchBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSearchBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Size = new System.Drawing.Size(321, 158);
            this.pnlSearchBar.TabIndex = 11;
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.btnAdd);
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAdd.Location = new System.Drawing.Point(898, 0);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(154, 158);
            this.pnlAdd.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblScreenTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbxScreenImage, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1052, 158);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // lblScreenTitle
            // 
            this.lblScreenTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScreenTitle.AutoSize = true;
            this.lblScreenTitle.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenTitle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblScreenTitle.Location = new System.Drawing.Point(451, 129);
            this.lblScreenTitle.Name = "lblScreenTitle";
            this.lblScreenTitle.Size = new System.Drawing.Size(149, 29);
            this.lblScreenTitle.TabIndex = 15;
            this.lblScreenTitle.Text = "Appointments";
            this.lblScreenTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxScreenImage
            // 
            this.pbxScreenImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxScreenImage.Image = global::Hospital_Management_System.Properties.Resources.Appointments_512;
            this.pbxScreenImage.ImageRotate = 0F;
            this.pbxScreenImage.Location = new System.Drawing.Point(429, 15);
            this.pbxScreenImage.Name = "pbxScreenImage";
            this.pbxScreenImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbxScreenImage.Size = new System.Drawing.Size(193, 98);
            this.pbxScreenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxScreenImage.TabIndex = 14;
            this.pbxScreenImage.TabStop = false;
            // 
            // ctrlAppointmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.dgvAppointments);
            this.Name = "ctrlAppointmentList";
            this.Size = new System.Drawing.Size(1052, 760);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearchFilter)).EndInit();
            this.gbxFilterBy.ResumeLayout(false);
            this.gbxFilterBy.PerformLayout();
            this.pnlFilterBy.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlAdd.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScreenImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvAppointments;
        private System.Windows.Forms.ComboBox cbxStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBar;
        private System.Windows.Forms.PictureBox pbxSearchFilter;
        private Guna.UI2.WinForms.Guna2GroupBox gbxFilterBy;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnDepartment;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnStatus;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnDoctorName;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnPatientName;
        private System.Windows.Forms.Panel pnlFilterBy;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblScreenTitle;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbxScreenImage;
    }
}
