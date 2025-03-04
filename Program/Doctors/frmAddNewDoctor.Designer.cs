namespace Hospital_Management_System.Doctors
{
    partial class frmAddNewDoctor
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
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxCareerInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.numUDWorkingHours = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbxSpecialization = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.llblRemoveImage = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNationalNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPatientImage = new Guna.UI2.WinForms.Guna2Panel();
            this.pbxEditImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pbxDoctorImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbxGendor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gbxPersonalInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbxCareerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWorkingHours)).BeginInit();
            this.pnlPatientImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDoctorImage)).BeginInit();
            this.gbxPersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(151, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Working Hours";
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 16;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(489, 661);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 34);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbxCareerInfo
            // 
            this.gbxCareerInfo.BorderRadius = 10;
            this.gbxCareerInfo.Controls.Add(this.numUDWorkingHours);
            this.gbxCareerInfo.Controls.Add(this.label8);
            this.gbxCareerInfo.Controls.Add(this.cbxSpecialization);
            this.gbxCareerInfo.Controls.Add(this.label7);
            this.gbxCareerInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.gbxCareerInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gbxCareerInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbxCareerInfo.ForeColor = System.Drawing.Color.Black;
            this.gbxCareerInfo.Location = new System.Drawing.Point(33, 475);
            this.gbxCareerInfo.Name = "gbxCareerInfo";
            this.gbxCareerInfo.Size = new System.Drawing.Size(602, 170);
            this.gbxCareerInfo.TabIndex = 40;
            this.gbxCareerInfo.Text = "Career information";
            // 
            // numUDWorkingHours
            // 
            this.numUDWorkingHours.AutoRoundedCorners = true;
            this.numUDWorkingHours.BackColor = System.Drawing.Color.Transparent;
            this.numUDWorkingHours.BorderRadius = 11;
            this.numUDWorkingHours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numUDWorkingHours.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.numUDWorkingHours.Location = new System.Drawing.Point(272, 112);
            this.numUDWorkingHours.Name = "numUDWorkingHours";
            this.numUDWorkingHours.Size = new System.Drawing.Size(92, 25);
            this.numUDWorkingHours.TabIndex = 38;
            this.numUDWorkingHours.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // cbxSpecialization
            // 
            this.cbxSpecialization.AutoRoundedCorners = true;
            this.cbxSpecialization.BackColor = System.Drawing.Color.Transparent;
            this.cbxSpecialization.BorderRadius = 17;
            this.cbxSpecialization.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSpecialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSpecialization.FillColor = System.Drawing.Color.LightGray;
            this.cbxSpecialization.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxSpecialization.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxSpecialization.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxSpecialization.ForeColor = System.Drawing.Color.Black;
            this.cbxSpecialization.ItemHeight = 30;
            this.cbxSpecialization.Location = new System.Drawing.Point(271, 55);
            this.cbxSpecialization.Name = "cbxSpecialization";
            this.cbxSpecialization.Size = new System.Drawing.Size(198, 36);
            this.cbxSpecialization.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(151, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Specialization";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // llblRemoveImage
            // 
            this.llblRemoveImage.AutoSize = true;
            this.llblRemoveImage.Location = new System.Drawing.Point(491, 184);
            this.llblRemoveImage.Name = "llblRemoveImage";
            this.llblRemoveImage.Size = new System.Drawing.Size(58, 19);
            this.llblRemoveImage.TabIndex = 35;
            this.llblRemoveImage.TabStop = true;
            this.llblRemoveImage.Text = "Remove";
            this.llblRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRemoveImage_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "FullName";
            // 
            // txtName
            // 
            this.txtName.Animated = true;
            this.txtName.AutoRoundedCorners = true;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BorderRadius = 12;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(148, 62);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(194, 26);
            this.txtName.TabIndex = 23;
            this.txtName.Tag = "name";
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.CheckIfTextBoxISEmpty);
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Animated = true;
            this.txtNationalNo.AutoRoundedCorners = true;
            this.txtNationalNo.BackColor = System.Drawing.Color.Transparent;
            this.txtNationalNo.BorderRadius = 12;
            this.txtNationalNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalNo.DefaultText = "";
            this.txtNationalNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNationalNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNationalNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationalNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationalNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationalNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNationalNo.ForeColor = System.Drawing.Color.Black;
            this.txtNationalNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationalNo.Location = new System.Drawing.Point(148, 115);
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.PasswordChar = '\0';
            this.txtNationalNo.PlaceholderText = "";
            this.txtNationalNo.SelectedText = "";
            this.txtNationalNo.Size = new System.Drawing.Size(194, 26);
            this.txtNationalNo.TabIndex = 25;
            this.txtNationalNo.Tag = "NationalNO";
            this.txtNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.CheckIfTextBoxISEmpty);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "National Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Gendor";
            // 
            // pnlPatientImage
            // 
            this.pnlPatientImage.BackColor = System.Drawing.Color.Transparent;
            this.pnlPatientImage.Controls.Add(this.pbxEditImage);
            this.pnlPatientImage.Controls.Add(this.pbxDoctorImage);
            this.pnlPatientImage.Location = new System.Drawing.Point(449, 49);
            this.pnlPatientImage.Name = "pnlPatientImage";
            this.pnlPatientImage.Size = new System.Drawing.Size(142, 132);
            this.pnlPatientImage.TabIndex = 21;
            // 
            // pbxEditImage
            // 
            this.pbxEditImage.BackColor = System.Drawing.Color.Transparent;
            this.pbxEditImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxEditImage.FillColor = System.Drawing.Color.Transparent;
            this.pbxEditImage.Image = global::Hospital_Management_System.Properties.Resources._9055423_bxs_edit_icon__1_1;
            this.pbxEditImage.ImageRotate = 0F;
            this.pbxEditImage.Location = new System.Drawing.Point(102, 92);
            this.pbxEditImage.Name = "pbxEditImage";
            this.pbxEditImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbxEditImage.Size = new System.Drawing.Size(37, 35);
            this.pbxEditImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEditImage.TabIndex = 20;
            this.pbxEditImage.TabStop = false;
            this.pbxEditImage.Click += new System.EventHandler(this.pbxEditImage_Click);
            // 
            // pbxDoctorImage
            // 
            this.pbxDoctorImage.BackColor = System.Drawing.Color.Transparent;
            this.pbxDoctorImage.Image = global::Hospital_Management_System.Properties.Resources.Doctor_512;
            this.pbxDoctorImage.ImageRotate = 0F;
            this.pbxDoctorImage.Location = new System.Drawing.Point(5, 5);
            this.pbxDoctorImage.Name = "pbxDoctorImage";
            this.pbxDoctorImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbxDoctorImage.Size = new System.Drawing.Size(132, 124);
            this.pbxDoctorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDoctorImage.TabIndex = 19;
            this.pbxDoctorImage.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(28, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Phone Number";
            // 
            // txtAddress
            // 
            this.txtAddress.Animated = true;
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BorderRadius = 10;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(148, 329);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(194, 58);
            this.txtAddress.TabIndex = 30;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.CheckIfTextBoxISEmpty);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Animated = true;
            this.txtPhoneNumber.AutoRoundedCorners = true;
            this.txtPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtPhoneNumber.BorderRadius = 12;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(148, 277);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(194, 26);
            this.txtPhoneNumber.TabIndex = 32;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            this.txtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.CheckIfTextBoxISEmpty);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Animated = true;
            this.dtpDOB.AutoRoundedCorners = true;
            this.dtpDOB.BackColor = System.Drawing.Color.Transparent;
            this.dtpDOB.BorderRadius = 16;
            this.dtpDOB.Checked = true;
            this.dtpDOB.FillColor = System.Drawing.Color.Cyan;
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDOB.ForeColor = System.Drawing.Color.Black;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(148, 159);
            this.dtpDOB.MaxDate = new System.DateTime(2025, 1, 26, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(194, 34);
            this.dtpDOB.TabIndex = 28;
            this.dtpDOB.Value = new System.DateTime(2025, 1, 26, 0, 0, 0, 0);
            // 
            // cbxGendor
            // 
            this.cbxGendor.AutoRoundedCorners = true;
            this.cbxGendor.BackColor = System.Drawing.Color.Transparent;
            this.cbxGendor.BorderRadius = 17;
            this.cbxGendor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxGendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGendor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxGendor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxGendor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxGendor.ForeColor = System.Drawing.Color.Black;
            this.cbxGendor.ItemHeight = 30;
            this.cbxGendor.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGendor.Location = new System.Drawing.Point(148, 217);
            this.cbxGendor.Name = "cbxGendor";
            this.cbxGendor.Size = new System.Drawing.Size(194, 36);
            this.cbxGendor.StartIndex = 0;
            this.cbxGendor.TabIndex = 29;
            // 
            // gbxPersonalInfo
            // 
            this.gbxPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbxPersonalInfo.BorderRadius = 10;
            this.gbxPersonalInfo.Controls.Add(this.llblRemoveImage);
            this.gbxPersonalInfo.Controls.Add(this.label2);
            this.gbxPersonalInfo.Controls.Add(this.txtName);
            this.gbxPersonalInfo.Controls.Add(this.txtNationalNo);
            this.gbxPersonalInfo.Controls.Add(this.pnlPatientImage);
            this.gbxPersonalInfo.Controls.Add(this.label5);
            this.gbxPersonalInfo.Controls.Add(this.label6);
            this.gbxPersonalInfo.Controls.Add(this.txtAddress);
            this.gbxPersonalInfo.Controls.Add(this.txtPhoneNumber);
            this.gbxPersonalInfo.Controls.Add(this.label3);
            this.gbxPersonalInfo.Controls.Add(this.label4);
            this.gbxPersonalInfo.Controls.Add(this.dtpDOB);
            this.gbxPersonalInfo.Controls.Add(this.label1);
            this.gbxPersonalInfo.Controls.Add(this.cbxGendor);
            this.gbxPersonalInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.gbxPersonalInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gbxPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbxPersonalInfo.ForeColor = System.Drawing.Color.Black;
            this.gbxPersonalInfo.Location = new System.Drawing.Point(33, 53);
            this.gbxPersonalInfo.Name = "gbxPersonalInfo";
            this.gbxPersonalInfo.Size = new System.Drawing.Size(602, 416);
            this.gbxPersonalInfo.TabIndex = 39;
            this.gbxPersonalInfo.Text = "Personal Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Date Of Birth";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Hospital_Management_System.Properties.Resources.Close_48;
            this.btnClose.Location = new System.Drawing.Point(639, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 42;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddNewDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(680, 711);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxCareerInfo);
            this.Controls.Add(this.gbxPersonalInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNewDoctor";
            this.Text = "frmAddNewDoctor";
            this.Load += new System.EventHandler(this.frmAddNewDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbxCareerInfo.ResumeLayout(false);
            this.gbxCareerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWorkingHours)).EndInit();
            this.pnlPatientImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDoctorImage)).EndInit();
            this.gbxPersonalInfo.ResumeLayout(false);
            this.gbxPersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2GroupBox gbxCareerInfo;
        private Guna.UI2.WinForms.Guna2ComboBox cbxSpecialization;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GroupBox gbxPersonalInfo;
        private System.Windows.Forms.LinkLabel llblRemoveImage;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtNationalNo;
        private Guna.UI2.WinForms.Guna2Panel pnlPatientImage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbxEditImage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbxDoctorImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxGendor;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numUDWorkingHours;
        private System.Windows.Forms.PictureBox btnClose;
    }
}