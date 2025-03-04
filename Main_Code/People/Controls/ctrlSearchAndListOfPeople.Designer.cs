namespace Hospital_Management_System.People.Controls
{
    partial class ctrlSearchAndListOfPeople
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
            this.dgvPeopleList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNationalNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsMenuList = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gbxFilterBy = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbtnPhoneNo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnGendor = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnNationalNo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnName = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.pnlAddEditPerson = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxGendor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNationalNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pbxEditImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pbxImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pbxHidePanel = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbxSearchFilter = new System.Windows.Forms.PictureBox();
            this.txtSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.colPersonImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeactivate = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).BeginInit();
            this.cmsMenuList.SuspendLayout();
            this.gbxFilterBy.SuspendLayout();
            this.pnlAddEditPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHidePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearchFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeopleList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPeopleList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeopleList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeopleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPeopleList.ColumnHeadersHeight = 25;
            this.dgvPeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPeopleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPersonImage,
            this.colFullName,
            this.colNationalNO,
            this.colDOB,
            this.colGendor,
            this.colAddress,
            this.colPhoneNumber});
            this.dgvPeopleList.ContextMenuStrip = this.cmsMenuList;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeopleList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPeopleList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPeopleList.Location = new System.Drawing.Point(19, 157);
            this.dgvPeopleList.Name = "dgvPeopleList";
            this.dgvPeopleList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeopleList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPeopleList.RowHeadersVisible = false;
            this.dgvPeopleList.Size = new System.Drawing.Size(1284, 566);
            this.dgvPeopleList.TabIndex = 2;
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
            this.colFullName.HeaderText = "Name";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            // 
            // colNationalNO
            // 
            this.colNationalNO.HeaderText = "National Number";
            this.colNationalNO.Name = "colNationalNO";
            this.colNationalNO.ReadOnly = true;
            // 
            // colDOB
            // 
            this.colDOB.FillWeight = 90.20835F;
            this.colDOB.HeaderText = "Date Of Birth";
            this.colDOB.Name = "colDOB";
            this.colDOB.ReadOnly = true;
            // 
            // colGendor
            // 
            this.colGendor.FillWeight = 90.20835F;
            this.colGendor.HeaderText = "Gendor";
            this.colGendor.Name = "colGendor";
            this.colGendor.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.FillWeight = 90.20835F;
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.FillWeight = 90.20835F;
            this.colPhoneNumber.HeaderText = "Phone Number";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.ReadOnly = true;
            // 
            // cmsMenuList
            // 
            this.cmsMenuList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmsMenuList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAdd,
            this.cmsUpdate,
            this.cmsDelete,
            this.toolStripSeparator1,
            this.cmsInfo,
            this.cmsDeactivate});
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
            this.cmsMenuList.Size = new System.Drawing.Size(144, 130);
            this.cmsMenuList.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
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
            this.gbxFilterBy.Location = new System.Drawing.Point(341, 3);
            this.gbxFilterBy.Name = "gbxFilterBy";
            this.gbxFilterBy.Size = new System.Drawing.Size(202, 112);
            this.gbxFilterBy.TabIndex = 5;
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
            this.rbtnPhoneNo.Location = new System.Drawing.Point(109, 77);
            this.rbtnPhoneNo.Name = "rbtnPhoneNo";
            this.rbtnPhoneNo.Size = new System.Drawing.Size(80, 19);
            this.rbtnPhoneNo.TabIndex = 3;
            this.rbtnPhoneNo.Text = "PhoneNO.";
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
            this.rbtnGendor.Size = new System.Drawing.Size(64, 19);
            this.rbtnGendor.TabIndex = 2;
            this.rbtnGendor.Text = "Gendor";
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
            this.rbtnNationalNo.Location = new System.Drawing.Point(109, 33);
            this.rbtnNationalNo.Name = "rbtnNationalNo";
            this.rbtnNationalNo.Size = new System.Drawing.Size(91, 19);
            this.rbtnNationalNo.TabIndex = 1;
            this.rbtnNationalNo.Text = "NationalNO.";
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
            this.rbtnName.Size = new System.Drawing.Size(57, 19);
            this.rbtnName.TabIndex = 0;
            this.rbtnName.TabStop = true;
            this.rbtnName.Text = "Name";
            this.rbtnName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnName.UncheckedState.BorderThickness = 2;
            this.rbtnName.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnName.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Cairo Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1168, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlAddEditPerson
            // 
            this.pnlAddEditPerson.Controls.Add(this.pbxEditImage);
            this.pnlAddEditPerson.Controls.Add(this.btnSave);
            this.pnlAddEditPerson.Controls.Add(this.pbxImage);
            this.pnlAddEditPerson.Controls.Add(this.label6);
            this.pnlAddEditPerson.Controls.Add(this.txtPhoneNumber);
            this.pnlAddEditPerson.Controls.Add(this.label5);
            this.pnlAddEditPerson.Controls.Add(this.txtAddress);
            this.pnlAddEditPerson.Controls.Add(this.cbxGendor);
            this.pnlAddEditPerson.Controls.Add(this.dtpDOB);
            this.pnlAddEditPerson.Controls.Add(this.label4);
            this.pnlAddEditPerson.Controls.Add(this.label3);
            this.pnlAddEditPerson.Controls.Add(this.txtNationalNo);
            this.pnlAddEditPerson.Controls.Add(this.label2);
            this.pnlAddEditPerson.Controls.Add(this.txtName);
            this.pnlAddEditPerson.Controls.Add(this.label1);
            this.pnlAddEditPerson.Controls.Add(this.pbxHidePanel);
            this.pnlAddEditPerson.Controls.Add(this.lblTitle);
            this.pnlAddEditPerson.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAddEditPerson.Location = new System.Drawing.Point(760, 0);
            this.pnlAddEditPerson.Name = "pnlAddEditPerson";
            this.pnlAddEditPerson.Size = new System.Drawing.Size(559, 738);
            this.pnlAddEditPerson.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 15;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IndicateFocus = true;
            this.btnSave.Location = new System.Drawing.Point(419, 679);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 33);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(36, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Animated = true;
            this.txtPhoneNumber.AutoRoundedCorners = true;
            this.txtPhoneNumber.BorderRadius = 16;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FillColor = System.Drawing.Color.LightGray;
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(157, 405);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(378, 34);
            this.txtPhoneNumber.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(57, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Animated = true;
            this.txtAddress.BorderRadius = 10;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FillColor = System.Drawing.Color.LightGray;
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(157, 467);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(378, 197);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // cbxGendor
            // 
            this.cbxGendor.AutoRoundedCorners = true;
            this.cbxGendor.BackColor = System.Drawing.Color.Transparent;
            this.cbxGendor.BorderRadius = 17;
            this.cbxGendor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxGendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGendor.FillColor = System.Drawing.Color.LightGray;
            this.cbxGendor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxGendor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxGendor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxGendor.ForeColor = System.Drawing.Color.Black;
            this.cbxGendor.ItemHeight = 30;
            this.cbxGendor.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGendor.Location = new System.Drawing.Point(157, 351);
            this.cbxGendor.Name = "cbxGendor";
            this.cbxGendor.Size = new System.Drawing.Size(378, 36);
            this.cbxGendor.StartIndex = 0;
            this.cbxGendor.TabIndex = 11;
            this.cbxGendor.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Animated = true;
            this.dtpDOB.AutoRoundedCorners = true;
            this.dtpDOB.BorderRadius = 16;
            this.dtpDOB.Checked = true;
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(157, 299);
            this.dtpDOB.MaxDate = new System.DateTime(2025, 1, 26, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(378, 34);
            this.dtpDOB.TabIndex = 10;
            this.dtpDOB.Value = new System.DateTime(2025, 1, 26, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(42, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(30, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "National Number";
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Animated = true;
            this.txtNationalNo.AutoRoundedCorners = true;
            this.txtNationalNo.BorderRadius = 16;
            this.txtNationalNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalNo.DefaultText = "";
            this.txtNationalNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNationalNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNationalNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationalNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationalNo.FillColor = System.Drawing.Color.LightGray;
            this.txtNationalNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationalNo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNationalNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationalNo.Location = new System.Drawing.Point(157, 246);
            this.txtNationalNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.PasswordChar = '\0';
            this.txtNationalNo.PlaceholderText = "";
            this.txtNationalNo.SelectedText = "";
            this.txtNationalNo.Size = new System.Drawing.Size(378, 34);
            this.txtNationalNo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(65, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Animated = true;
            this.txtName.AutoRoundedCorners = true;
            this.txtName.BorderRadius = 16;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FillColor = System.Drawing.Color.LightGray;
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(157, 193);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(378, 34);
            this.txtName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(59, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gendor";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(19, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Record";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 50.96518F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Hospital_Management_System.Properties.Resources.accountProfileIcon1;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 82;
            // 
            // pbxEditImage
            // 
            this.pbxEditImage.BackColor = System.Drawing.Color.Transparent;
            this.pbxEditImage.FillColor = System.Drawing.Color.Transparent;
            this.pbxEditImage.Image = global::Hospital_Management_System.Properties.Resources._9055423_bxs_edit_icon__1_1;
            this.pbxEditImage.ImageRotate = 0F;
            this.pbxEditImage.Location = new System.Drawing.Point(335, 132);
            this.pbxEditImage.Name = "pbxEditImage";
            this.pbxEditImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbxEditImage.Size = new System.Drawing.Size(37, 35);
            this.pbxEditImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEditImage.TabIndex = 18;
            this.pbxEditImage.TabStop = false;
            this.pbxEditImage.Click += new System.EventHandler(this.guna2CirclePictureBox2_Click);
            // 
            // pbxImage
            // 
            this.pbxImage.BackColor = System.Drawing.Color.Transparent;
            this.pbxImage.FillColor = System.Drawing.Color.Transparent;
            this.pbxImage.Image = global::Hospital_Management_System.Properties.Resources.patient_boy;
            this.pbxImage.ImageRotate = 0F;
            this.pbxImage.Location = new System.Drawing.Point(240, 43);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbxImage.Size = new System.Drawing.Size(132, 124);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImage.TabIndex = 16;
            this.pbxImage.TabStop = false;
            // 
            // pbxHidePanel
            // 
            this.pbxHidePanel.Image = global::Hospital_Management_System.Properties.Resources.Close_48;
            this.pbxHidePanel.ImageRotate = 0F;
            this.pbxHidePanel.Location = new System.Drawing.Point(3, 3);
            this.pbxHidePanel.Name = "pbxHidePanel";
            this.pbxHidePanel.Size = new System.Drawing.Size(26, 25);
            this.pbxHidePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHidePanel.TabIndex = 1;
            this.pbxHidePanel.TabStop = false;
            this.pbxHidePanel.Click += new System.EventHandler(this.pbxHidePanel_Click);
            // 
            // pbxSearchFilter
            // 
            this.pbxSearchFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSearchFilter.Image = global::Hospital_Management_System.Properties.Resources._4781833_filter_filters_funnel_list_navigation_icon;
            this.pbxSearchFilter.Location = new System.Drawing.Point(288, 24);
            this.pbxSearchFilter.Name = "pbxSearchFilter";
            this.pbxSearchFilter.Size = new System.Drawing.Size(29, 30);
            this.pbxSearchFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSearchFilter.TabIndex = 4;
            this.pbxSearchFilter.TabStop = false;
            this.pbxSearchFilter.Click += new System.EventHandler(this.pbxSearchFilter_Click);
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
            this.txtSearchBar.Location = new System.Drawing.Point(19, 22);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.PasswordChar = '\0';
            this.txtSearchBar.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchBar.PlaceholderText = "Enter Text";
            this.txtSearchBar.SelectedText = "";
            this.txtSearchBar.Size = new System.Drawing.Size(263, 32);
            this.txtSearchBar.TabIndex = 0;
            // 
            // colPersonImage
            // 
            this.colPersonImage.FillWeight = 50.96518F;
            this.colPersonImage.HeaderText = "";
            this.colPersonImage.Image = global::Hospital_Management_System.Properties.Resources.accountProfileIcon1;
            this.colPersonImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colPersonImage.Name = "colPersonImage";
            this.colPersonImage.ReadOnly = true;
            // 
            // cmsAdd
            // 
            this.cmsAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsAdd.Image = global::Hospital_Management_System.Properties.Resources.Add_64;
            this.cmsAdd.Name = "cmsAdd";
            this.cmsAdd.Size = new System.Drawing.Size(143, 24);
            this.cmsAdd.Text = "Add";
            // 
            // cmsUpdate
            // 
            this.cmsUpdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsUpdate.Image = global::Hospital_Management_System.Properties.Resources.Edit_64;
            this.cmsUpdate.Name = "cmsUpdate";
            this.cmsUpdate.Size = new System.Drawing.Size(143, 24);
            this.cmsUpdate.Text = "Edit";
            // 
            // cmsDelete
            // 
            this.cmsDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDelete.ForeColor = System.Drawing.Color.Red;
            this.cmsDelete.Image = global::Hospital_Management_System.Properties.Resources.Deleteicon;
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(143, 24);
            this.cmsDelete.Text = "Delete";
            // 
            // cmsInfo
            // 
            this.cmsInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsInfo.Image = global::Hospital_Management_System.Properties.Resources._352432_info_icon;
            this.cmsInfo.Name = "cmsInfo";
            this.cmsInfo.Size = new System.Drawing.Size(143, 24);
            this.cmsInfo.Text = "Info.";
            // 
            // cmsDeactivate
            // 
            this.cmsDeactivate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsDeactivate.Image = global::Hospital_Management_System.Properties.Resources._12607_close_delete_error_exit_false_icon;
            this.cmsDeactivate.Name = "cmsDeactivate";
            this.cmsDeactivate.Size = new System.Drawing.Size(143, 24);
            this.cmsDeactivate.Text = "Deactivate";
            // 
            // ctrlSearchAndListOfPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAddEditPerson);
            this.Controls.Add(this.gbxFilterBy);
            this.Controls.Add(this.pbxSearchFilter);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPeopleList);
            this.Name = "ctrlSearchAndListOfPeople";
            this.Size = new System.Drawing.Size(1319, 738);
            this.Load += new System.EventHandler(this.ctrlSearchAndListOfPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).EndInit();
            this.cmsMenuList.ResumeLayout(false);
            this.gbxFilterBy.ResumeLayout(false);
            this.gbxFilterBy.PerformLayout();
            this.pnlAddEditPerson.ResumeLayout(false);
            this.pnlAddEditPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHidePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearchFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearchBar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPeopleList;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsMenuList;
        private System.Windows.Forms.ToolStripMenuItem cmsAdd;
        private System.Windows.Forms.ToolStripMenuItem cmsUpdate;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsInfo;
        private System.Windows.Forms.ToolStripMenuItem cmsDeactivate;
        private System.Windows.Forms.PictureBox pbxSearchFilter;
        private Guna.UI2.WinForms.Guna2GroupBox gbxFilterBy;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnName;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnPhoneNo;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnGendor;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnNationalNo;
        private System.Windows.Forms.DataGridViewImageColumn colPersonImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNationalNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlAddEditPerson;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pbxHidePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtNationalNo;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxGendor;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbxImage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbxEditImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
