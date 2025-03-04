namespace Hospital_Management_System.Appointments
{
    partial class frmAppointmentsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxFilterBy = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbtnPhoneNo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnStatus = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnNationalNo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnName = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dgvAppointments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsMenuList = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.pnlFilterBy = new System.Windows.Forms.Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.cmsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsConfirm = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbxSearchFilter = new System.Windows.Forms.PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbxFilterBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.cmsMenuList.SuspendLayout();
            this.pnlSearchBar.SuspendLayout();
            this.pnlFilterBy.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearchFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFilterBy
            // 
            this.gbxFilterBy.Controls.Add(this.rbtnPhoneNo);
            this.gbxFilterBy.Controls.Add(this.rbtnStatus);
            this.gbxFilterBy.Controls.Add(this.rbtnNationalNo);
            this.gbxFilterBy.Controls.Add(this.rbtnName);
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
            // rbtnPhoneNo
            // 
            this.rbtnPhoneNo.AutoSize = true;
            this.rbtnPhoneNo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnPhoneNo.CheckedState.BorderThickness = 0;
            this.rbtnPhoneNo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnPhoneNo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnPhoneNo.CheckedState.InnerOffset = -4;
            this.rbtnPhoneNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnPhoneNo.Location = new System.Drawing.Point(156, 67);
            this.rbtnPhoneNo.Name = "rbtnPhoneNo";
            this.rbtnPhoneNo.Size = new System.Drawing.Size(88, 19);
            this.rbtnPhoneNo.TabIndex = 3;
            this.rbtnPhoneNo.Tag = "Department";
            this.rbtnPhoneNo.Text = "Department";
            this.rbtnPhoneNo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnPhoneNo.UncheckedState.BorderThickness = 2;
            this.rbtnPhoneNo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnPhoneNo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtnPhoneNo.CheckedChanged += new System.EventHandler(this.EditFilterText);
            this.rbtnPhoneNo.Click += new System.EventHandler(this.txtSearchBar_Click);
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
            this.rbtnStatus.CheckedChanged += new System.EventHandler(this.EditFilterText);
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
            this.rbtnNationalNo.CheckedChanged += new System.EventHandler(this.EditFilterText);
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
            this.rbtnName.CheckedChanged += new System.EventHandler(this.EditFilterText);
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAppointments.ColumnHeadersHeight = 25;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAppointments.ContextMenuStrip = this.cmsMenuList;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointments.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAppointments.Location = new System.Drawing.Point(0, 316);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAppointments.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAppointments.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAppointments.RowTemplate.Height = 40;
            this.dgvAppointments.Size = new System.Drawing.Size(1181, 480);
            this.dgvAppointments.TabIndex = 7;
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
            this.dgvAppointments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellDoubleClick);
            this.dgvAppointments.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvAppointments_CellPainting);
            this.dgvAppointments.Click += new System.EventHandler(this.dgvAppointments_Click);
            // 
            // cmsMenuList
            // 
            this.cmsMenuList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmsMenuList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAdd,
            this.cmsEdit,
            this.toolStripSeparator1,
            this.cmsCancel,
            this.cmsConfirm,
            this.cmsDelete,
            this.toolStripMenuItem2,
            this.cmsInfo});
            this.cmsMenuList.Name = "cmsMenuList";
            this.cmsMenuList.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsMenuList.RenderStyle.BorderColor = System.Drawing.Color.Silver;
            this.cmsMenuList.RenderStyle.ColorTable = null;
            this.cmsMenuList.RenderStyle.RoundedEdges = true;
            this.cmsMenuList.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsMenuList.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsMenuList.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsMenuList.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsMenuList.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.cmsMenuList.Size = new System.Drawing.Size(166, 172);
            this.cmsMenuList.Text = "Delete";
            this.cmsMenuList.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMenuList_Opening);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 6);
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
            this.cbxStatus.SelectedIndexChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
            this.cbxStatus.Click += new System.EventHandler(this.txtSearchBar_Click);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.btnAdd);
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAdd.Location = new System.Drawing.Point(1027, 0);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(154, 158);
            this.pnlAdd.TabIndex = 16;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.White;
            this.pnlControls.Controls.Add(this.pnlSearchBar);
            this.pnlControls.Controls.Add(this.pnlAdd);
            this.pnlControls.Controls.Add(this.pnlFilterBy);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 158);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1181, 158);
            this.pnlControls.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.guna2CirclePictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1181, 158);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(516, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Appointments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.tableLayoutPanel1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(1181, 158);
            this.pnlLogo.TabIndex = 18;
            // 
            // cmsAdd
            // 
            this.cmsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsAdd.Image = global::Hospital_Management_System.Properties.Resources.Add_64;
            this.cmsAdd.Name = "cmsAdd";
            this.cmsAdd.Size = new System.Drawing.Size(165, 26);
            this.cmsAdd.Text = "Add";
            this.cmsAdd.Click += new System.EventHandler(this.cmsAdd_Click);
            // 
            // cmsEdit
            // 
            this.cmsEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsEdit.Image = global::Hospital_Management_System.Properties.Resources.Edit_64;
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(165, 26);
            this.cmsEdit.Text = "Edit";
            this.cmsEdit.Click += new System.EventHandler(this.cmsUpdate_Click);
            // 
            // cmsCancel
            // 
            this.cmsCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsCancel.ForeColor = System.Drawing.Color.Red;
            this.cmsCancel.Image = global::Hospital_Management_System.Properties.Resources._9004715_cross_delete_remove_cancel_icon;
            this.cmsCancel.Name = "cmsCancel";
            this.cmsCancel.Size = new System.Drawing.Size(165, 26);
            this.cmsCancel.Text = "Cancel";
            this.cmsCancel.Click += new System.EventHandler(this.cmsDelete_Click);
            // 
            // cmsConfirm
            // 
            this.cmsConfirm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmsConfirm.Image = global::Hospital_Management_System.Properties.Resources.Confirm_icon;
            this.cmsConfirm.Name = "cmsConfirm";
            this.cmsConfirm.Size = new System.Drawing.Size(165, 26);
            this.cmsConfirm.Text = "Confirm";
            this.cmsConfirm.Click += new System.EventHandler(this.cmsConfirm_Click);
            // 
            // cmsDelete
            // 
            this.cmsDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmsDelete.Image = global::Hospital_Management_System.Properties.Resources.Deleteicon;
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(165, 26);
            this.cmsDelete.Text = "Delete";
            this.cmsDelete.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cmsInfo
            // 
            this.cmsInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmsInfo.Image = global::Hospital_Management_System.Properties.Resources._352432_info_icon;
            this.cmsInfo.Name = "cmsInfo";
            this.cmsInfo.Size = new System.Drawing.Size(165, 26);
            this.cmsInfo.Text = "View Details";
            this.cmsInfo.Click += new System.EventHandler(this.cmsInfo_Click);
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
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
            this.txtSearchBar.Click += new System.EventHandler(this.txtSearchBar_Click);
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
            this.pbxSearchFilter.Click += new System.EventHandler(this.pbxSearchFilter_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2CirclePictureBox1.Image = global::Hospital_Management_System.Properties.Resources.Appointments_512;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(494, 15);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(193, 98);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 14;
            this.guna2CirclePictureBox1.TabStop = false;
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
            // frmAppointmentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 796);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlLogo);
            this.Name = "frmAppointmentsList";
            this.Text = "frmAppointments";
            this.Load += new System.EventHandler(this.frmAppointments_Load);
            this.gbxFilterBy.ResumeLayout(false);
            this.gbxFilterBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.cmsMenuList.ResumeLayout(false);
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlFilterBy.ResumeLayout(false);
            this.pnlAdd.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearchFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbxFilterBy;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnPhoneNo;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnStatus;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnNationalNo;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnName;
        private System.Windows.Forms.PictureBox pbxSearchFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAppointments;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsMenuList;
        private System.Windows.Forms.ToolStripMenuItem cmsAdd;
        private System.Windows.Forms.ToolStripMenuItem cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsInfo;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.Panel pnlFilterBy;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.ToolStripMenuItem cmsConfirm;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Panel pnlLogo;
    }
}