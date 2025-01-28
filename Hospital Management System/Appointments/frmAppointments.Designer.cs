namespace Hospital_Management_System.Appointments
{
    partial class frmAppointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxFilterBy = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbtnPhoneNo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnGendor = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnNationalNo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnName = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dgvPeopleList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNationalNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsMenuList = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.pnlFilterBy = new System.Windows.Forms.Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbxSearchFilter = new System.Windows.Forms.PictureBox();
            this.cmsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbxFilterBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).BeginInit();
            this.cmsMenuList.SuspendLayout();
            this.pnlSearchBar.SuspendLayout();
            this.pnlFilterBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearchFilter)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFilterBy
            // 
            this.gbxFilterBy.Controls.Add(this.rbtnPhoneNo);
            this.gbxFilterBy.Controls.Add(this.rbtnGendor);
            this.gbxFilterBy.Controls.Add(this.rbtnNationalNo);
            this.gbxFilterBy.Controls.Add(this.rbtnName);
            this.gbxFilterBy.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.gbxFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbxFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbxFilterBy.Location = new System.Drawing.Point(3, 6);
            this.gbxFilterBy.Name = "gbxFilterBy";
            this.gbxFilterBy.Size = new System.Drawing.Size(259, 109);
            this.gbxFilterBy.TabIndex = 9;
            this.gbxFilterBy.Text = "Filter By";
            // 
            // rbtnPhoneNo
            // 
            this.rbtnPhoneNo.AutoSize = true;
            this.rbtnPhoneNo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnPhoneNo.CheckedState.BorderThickness = 0;
            this.rbtnPhoneNo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnPhoneNo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnPhoneNo.CheckedState.InnerOffset = -4;
            this.rbtnPhoneNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnPhoneNo.Location = new System.Drawing.Point(156, 77);
            this.rbtnPhoneNo.Name = "rbtnPhoneNo";
            this.rbtnPhoneNo.Size = new System.Drawing.Size(88, 19);
            this.rbtnPhoneNo.TabIndex = 3;
            this.rbtnPhoneNo.Text = "Department";
            this.rbtnPhoneNo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnPhoneNo.UncheckedState.BorderThickness = 2;
            this.rbtnPhoneNo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnPhoneNo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtnGendor
            // 
            this.rbtnGendor.AutoSize = true;
            this.rbtnGendor.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnGendor.CheckedState.BorderThickness = 0;
            this.rbtnGendor.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnGendor.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnGendor.CheckedState.InnerOffset = -4;
            this.rbtnGendor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnGendor.Location = new System.Drawing.Point(10, 77);
            this.rbtnGendor.Name = "rbtnGendor";
            this.rbtnGendor.Size = new System.Drawing.Size(57, 19);
            this.rbtnGendor.TabIndex = 2;
            this.rbtnGendor.Text = "Status";
            this.rbtnGendor.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnGendor.UncheckedState.BorderThickness = 2;
            this.rbtnGendor.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnGendor.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtnNationalNo
            // 
            this.rbtnNationalNo.AutoSize = true;
            this.rbtnNationalNo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnNationalNo.CheckedState.BorderThickness = 0;
            this.rbtnNationalNo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnNationalNo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnNationalNo.CheckedState.InnerOffset = -4;
            this.rbtnNationalNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnNationalNo.Location = new System.Drawing.Point(156, 33);
            this.rbtnNationalNo.Name = "rbtnNationalNo";
            this.rbtnNationalNo.Size = new System.Drawing.Size(96, 19);
            this.rbtnNationalNo.TabIndex = 1;
            this.rbtnNationalNo.Text = "Doctor Name";
            this.rbtnNationalNo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnNationalNo.UncheckedState.BorderThickness = 2;
            this.rbtnNationalNo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnNationalNo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtnName
            // 
            this.rbtnName.AutoSize = true;
            this.rbtnName.Checked = true;
            this.rbtnName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnName.CheckedState.BorderThickness = 0;
            this.rbtnName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnName.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnName.CheckedState.InnerOffset = -4;
            this.rbtnName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnName.Location = new System.Drawing.Point(10, 33);
            this.rbtnName.Name = "rbtnName";
            this.rbtnName.Size = new System.Drawing.Size(97, 19);
            this.rbtnName.TabIndex = 0;
            this.rbtnName.TabStop = true;
            this.rbtnName.Text = "Patient Name";
            this.rbtnName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnName.UncheckedState.BorderThickness = 2;
            this.rbtnName.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnName.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // dgvPeopleList
            // 
            this.dgvPeopleList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvPeopleList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeopleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPeopleList.ColumnHeadersHeight = 25;
            this.dgvPeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPeopleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFullName,
            this.colNationalNO,
            this.colDOB,
            this.colGendor,
            this.colAddress});
            this.dgvPeopleList.ContextMenuStrip = this.cmsMenuList;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeopleList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPeopleList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPeopleList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPeopleList.Location = new System.Drawing.Point(0, 316);
            this.dgvPeopleList.Name = "dgvPeopleList";
            this.dgvPeopleList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeopleList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPeopleList.RowHeadersVisible = false;
            this.dgvPeopleList.Size = new System.Drawing.Size(1181, 330);
            this.dgvPeopleList.TabIndex = 7;
            this.dgvPeopleList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPeopleList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPeopleList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPeopleList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPeopleList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPeopleList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPeopleList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPeopleList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPeopleList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPeopleList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPeopleList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPeopleList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPeopleList.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvPeopleList.ThemeStyle.ReadOnly = false;
            this.dgvPeopleList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPeopleList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPeopleList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPeopleList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPeopleList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPeopleList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPeopleList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colFullName
            // 
            this.colFullName.FillWeight = 90.20835F;
            this.colFullName.HeaderText = "Appointment Date";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            // 
            // colNationalNO
            // 
            this.colNationalNO.HeaderText = "Patient Name";
            this.colNationalNO.Name = "colNationalNO";
            this.colNationalNO.ReadOnly = true;
            // 
            // colDOB
            // 
            this.colDOB.FillWeight = 90.20835F;
            this.colDOB.HeaderText = "Doctor Name";
            this.colDOB.Name = "colDOB";
            this.colDOB.ReadOnly = true;
            // 
            // colGendor
            // 
            this.colGendor.FillWeight = 90.20835F;
            this.colGendor.HeaderText = "Department";
            this.colGendor.Name = "colGendor";
            this.colGendor.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.FillWeight = 90.20835F;
            this.colAddress.HeaderText = "Status";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // cmsMenuList
            // 
            this.cmsMenuList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmsMenuList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAdd,
            this.cmsUpdate,
            this.cmsDelete,
            this.toolStripSeparator1,
            this.cmsInfo});
            this.cmsMenuList.Name = "cmsMenuList";
            this.cmsMenuList.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsMenuList.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsMenuList.RenderStyle.ColorTable = null;
            this.cmsMenuList.RenderStyle.RoundedEdges = true;
            this.cmsMenuList.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsMenuList.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsMenuList.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsMenuList.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsMenuList.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsMenuList.Size = new System.Drawing.Size(154, 106);
            this.cmsMenuList.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // pnlSearchBar
            // 
            this.pnlSearchBar.Controls.Add(this.comboBox1);
            this.pnlSearchBar.Controls.Add(this.txtSearchBar);
            this.pnlSearchBar.Controls.Add(this.pbxSearchFilter);
            this.pnlSearchBar.Location = new System.Drawing.Point(4, 19);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Size = new System.Drawing.Size(321, 67);
            this.pnlSearchBar.TabIndex = 11;
            // 
            // pnlFilterBy
            // 
            this.pnlFilterBy.Controls.Add(this.gbxFilterBy);
            this.pnlFilterBy.Location = new System.Drawing.Point(331, 19);
            this.pnlFilterBy.Name = "pnlFilterBy";
            this.pnlFilterBy.Size = new System.Drawing.Size(265, 133);
            this.pnlFilterBy.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Cairo Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1043, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 32);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Hospital_Management_System.Properties.Resources.Appointments_512;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(525, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(173, 116);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 14;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // txtSearchBar
            // 
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
            this.txtSearchBar.Location = new System.Drawing.Point(3, 12);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.PasswordChar = '\0';
            this.txtSearchBar.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchBar.PlaceholderText = "Enter Text";
            this.txtSearchBar.SelectedText = "";
            this.txtSearchBar.Size = new System.Drawing.Size(263, 32);
            this.txtSearchBar.TabIndex = 6;
            // 
            // pbxSearchFilter
            // 
            this.pbxSearchFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSearchFilter.Image = global::Hospital_Management_System.Properties.Resources._4781833_filter_filters_funnel_list_navigation_icon;
            this.pbxSearchFilter.Location = new System.Drawing.Point(285, 12);
            this.pbxSearchFilter.Name = "pbxSearchFilter";
            this.pbxSearchFilter.Size = new System.Drawing.Size(29, 30);
            this.pbxSearchFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSearchFilter.TabIndex = 8;
            this.pbxSearchFilter.TabStop = false;
            // 
            // cmsAdd
            // 
            this.cmsAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsAdd.Image = global::Hospital_Management_System.Properties.Resources.Add_64;
            this.cmsAdd.Name = "cmsAdd";
            this.cmsAdd.Size = new System.Drawing.Size(153, 24);
            this.cmsAdd.Text = "Add";
            // 
            // cmsUpdate
            // 
            this.cmsUpdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsUpdate.Image = global::Hospital_Management_System.Properties.Resources.Edit_64;
            this.cmsUpdate.Name = "cmsUpdate";
            this.cmsUpdate.Size = new System.Drawing.Size(153, 24);
            this.cmsUpdate.Text = "Edit";
            // 
            // cmsDelete
            // 
            this.cmsDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDelete.ForeColor = System.Drawing.Color.Red;
            this.cmsDelete.Image = global::Hospital_Management_System.Properties.Resources._984759_cancel_close_delete_exit_no_icon;
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(153, 24);
            this.cmsDelete.Text = "Cancel";
            // 
            // cmsInfo
            // 
            this.cmsInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsInfo.Image = global::Hospital_Management_System.Properties.Resources._352432_info_icon;
            this.cmsInfo.Name = "cmsInfo";
            this.cmsInfo.Size = new System.Drawing.Size(153, 24);
            this.cmsInfo.Text = "View Details";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 50.96518F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Hospital_Management_System.Properties.Resources.accountProfileIcon1;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(537, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Appointments";
            // 
            // pnlAdd
            // 
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAdd.Location = new System.Drawing.Point(1027, 646);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(154, 150);
            this.pnlAdd.TabIndex = 16;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnAdd);
            this.pnlControls.Controls.Add(this.pnlSearchBar);
            this.pnlControls.Controls.Add(this.pnlFilterBy);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 158);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1181, 158);
            this.pnlControls.TabIndex = 17;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.panel2);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(1181, 158);
            this.pnlLogo.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 646);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 153);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number Of Records :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "???";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Location = new System.Drawing.Point(531, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 158);
            this.panel2.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Scheduled",
            "Confirmed",
            "Pending",
            "Cancelled by Patient",
            "Cancelled by Doctor",
            "Rescheduled",
            "Completed",
            "Missed"});
            this.comboBox1.Location = new System.Drawing.Point(46, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // frmAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 796);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.dgvPeopleList);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlLogo);
            this.Name = "frmAppointments";
            this.Text = "frmAppointments";
            this.gbxFilterBy.ResumeLayout(false);
            this.gbxFilterBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).EndInit();
            this.cmsMenuList.ResumeLayout(false);
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlFilterBy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearchFilter)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbxFilterBy;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnPhoneNo;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnGendor;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnNationalNo;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnName;
        private System.Windows.Forms.PictureBox pbxSearchFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPeopleList;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNationalNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsMenuList;
        private System.Windows.Forms.ToolStripMenuItem cmsAdd;
        private System.Windows.Forms.ToolStripMenuItem cmsUpdate;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsInfo;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.Panel pnlFilterBy;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}