namespace Hospital_Management_System.Patients
{
    partial class frmAddNewPatient
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlPatientImage = new Guna.UI2.WinForms.Guna2Panel();
            this.pbxEditImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pbxPatientImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
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
            this.cbxBloodType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxPersonalInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pnlAddEmergencyContact = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSaveContact = new Guna.UI2.WinForms.Guna2Button();
            this.cbxRWP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSecPhoneNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFirstPhoneNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtContactName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.llblRemoveImage = new System.Windows.Forms.LinkLabel();
            this.llblEmergency = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.gbxHealthInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAllergies = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlPatientImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPatientImage)).BeginInit();
            this.gbxPersonalInfo.SuspendLayout();
            this.pnlAddEmergencyContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.gbxHealthInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnlPatientImage
            // 
            this.pnlPatientImage.BackColor = System.Drawing.Color.Transparent;
            this.pnlPatientImage.Controls.Add(this.pbxEditImage);
            this.pnlPatientImage.Controls.Add(this.pbxPatientImage);
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
            // pbxPatientImage
            // 
            this.pbxPatientImage.BackColor = System.Drawing.Color.Transparent;
            this.pbxPatientImage.Image = global::Hospital_Management_System.Properties.Resources.Patient_512;
            this.pbxPatientImage.ImageRotate = 0F;
            this.pbxPatientImage.Location = new System.Drawing.Point(7, 5);
            this.pbxPatientImage.Name = "pbxPatientImage";
            this.pbxPatientImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbxPatientImage.Size = new System.Drawing.Size(132, 124);
            this.pbxPatientImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPatientImage.TabIndex = 19;
            this.pbxPatientImage.TabStop = false;
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
            this.txtPhoneNumber.Tag = "PhoneNO";
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstPhoneNo_KeyPress);
            this.txtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.CheckIfTextBoxISEmpty);
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
            this.txtAddress.Tag = "Address";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "National Number";
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
            // cbxBloodType
            // 
            this.cbxBloodType.AutoRoundedCorners = true;
            this.cbxBloodType.BackColor = System.Drawing.Color.Transparent;
            this.cbxBloodType.BorderRadius = 17;
            this.cbxBloodType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBloodType.FillColor = System.Drawing.Color.LightGray;
            this.cbxBloodType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxBloodType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxBloodType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxBloodType.ForeColor = System.Drawing.Color.Black;
            this.cbxBloodType.ItemHeight = 30;
            this.cbxBloodType.Items.AddRange(new object[] {
            "O_Negative ",
            "O_Positive",
            "A_Negative",
            "A_Positive ",
            "B_Negative ",
            "B_Positive ",
            "AB_Negative ",
            "AB_Positive "});
            this.cbxBloodType.Location = new System.Drawing.Point(147, 53);
            this.cbxBloodType.Name = "cbxBloodType";
            this.cbxBloodType.Size = new System.Drawing.Size(198, 36);
            this.cbxBloodType.StartIndex = 0;
            this.cbxBloodType.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(27, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Blood Type";
            // 
            // gbxPersonalInfo
            // 
            this.gbxPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbxPersonalInfo.BorderRadius = 10;
            this.gbxPersonalInfo.Controls.Add(this.pnlAddEmergencyContact);
            this.gbxPersonalInfo.Controls.Add(this.llblRemoveImage);
            this.gbxPersonalInfo.Controls.Add(this.llblEmergency);
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
            this.gbxPersonalInfo.Location = new System.Drawing.Point(32, 47);
            this.gbxPersonalInfo.Name = "gbxPersonalInfo";
            this.gbxPersonalInfo.Size = new System.Drawing.Size(602, 416);
            this.gbxPersonalInfo.TabIndex = 36;
            this.gbxPersonalInfo.Text = "Personal Information";
            // 
            // pnlAddEmergencyContact
            // 
            this.pnlAddEmergencyContact.Controls.Add(this.pictureBox1);
            this.pnlAddEmergencyContact.Controls.Add(this.btnSaveContact);
            this.pnlAddEmergencyContact.Controls.Add(this.cbxRWP);
            this.pnlAddEmergencyContact.Controls.Add(this.label10);
            this.pnlAddEmergencyContact.Controls.Add(this.txtSecPhoneNo);
            this.pnlAddEmergencyContact.Controls.Add(this.label11);
            this.pnlAddEmergencyContact.Controls.Add(this.label12);
            this.pnlAddEmergencyContact.Controls.Add(this.txtFirstPhoneNo);
            this.pnlAddEmergencyContact.Controls.Add(this.label13);
            this.pnlAddEmergencyContact.Controls.Add(this.txtContactName);
            this.pnlAddEmergencyContact.Controls.Add(this.label14);
            this.pnlAddEmergencyContact.Location = new System.Drawing.Point(4, 115);
            this.pnlAddEmergencyContact.Name = "pnlAddEmergencyContact";
            this.pnlAddEmergencyContact.Size = new System.Drawing.Size(425, 298);
            this.pnlAddEmergencyContact.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Hospital_Management_System.Properties.Resources.Close_48;
            this.pictureBox1.Location = new System.Drawing.Point(399, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSaveContact
            // 
            this.btnSaveContact.Animated = true;
            this.btnSaveContact.AutoRoundedCorners = true;
            this.btnSaveContact.BorderRadius = 16;
            this.btnSaveContact.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveContact.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveContact.ForeColor = System.Drawing.Color.White;
            this.btnSaveContact.Location = new System.Drawing.Point(126, 252);
            this.btnSaveContact.Name = "btnSaveContact";
            this.btnSaveContact.Size = new System.Drawing.Size(146, 34);
            this.btnSaveContact.TabIndex = 49;
            this.btnSaveContact.Text = "Save";
            this.btnSaveContact.Click += new System.EventHandler(this.btnSaveContact_Click);
            // 
            // cbxRWP
            // 
            this.cbxRWP.BackColor = System.Drawing.Color.Transparent;
            this.cbxRWP.BorderRadius = 15;
            this.cbxRWP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxRWP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRWP.FillColor = System.Drawing.Color.DarkGray;
            this.cbxRWP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxRWP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxRWP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbxRWP.ForeColor = System.Drawing.Color.Black;
            this.cbxRWP.ItemHeight = 30;
            this.cbxRWP.Items.AddRange(new object[] {
            "Mother",
            "Father",
            "Brother",
            "Sister",
            "GrandFather",
            "GrandMother",
            "Uncel",
            "Friend"});
            this.cbxRWP.Location = new System.Drawing.Point(155, 182);
            this.cbxRWP.Name = "cbxRWP";
            this.cbxRWP.Size = new System.Drawing.Size(193, 36);
            this.cbxRWP.StartIndex = 7;
            this.cbxRWP.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 32);
            this.label10.TabIndex = 47;
            this.label10.Text = "Relationship with\r\n the patient";
            // 
            // txtSecPhoneNo
            // 
            this.txtSecPhoneNo.Animated = true;
            this.txtSecPhoneNo.AutoRoundedCorners = true;
            this.txtSecPhoneNo.BorderRadius = 13;
            this.txtSecPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecPhoneNo.DefaultText = "";
            this.txtSecPhoneNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSecPhoneNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSecPhoneNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecPhoneNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecPhoneNo.FillColor = System.Drawing.Color.Silver;
            this.txtSecPhoneNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecPhoneNo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSecPhoneNo.ForeColor = System.Drawing.Color.Black;
            this.txtSecPhoneNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecPhoneNo.Location = new System.Drawing.Point(153, 126);
            this.txtSecPhoneNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSecPhoneNo.Name = "txtSecPhoneNo";
            this.txtSecPhoneNo.PasswordChar = '\0';
            this.txtSecPhoneNo.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSecPhoneNo.PlaceholderText = "Enter PhoneNO.";
            this.txtSecPhoneNo.SelectedText = "";
            this.txtSecPhoneNo.Size = new System.Drawing.Size(193, 29);
            this.txtSecPhoneNo.TabIndex = 46;
            this.txtSecPhoneNo.Tag = "SecPhoneNO";
            this.txtSecPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstPhoneNo_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(350, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 15);
            this.label11.TabIndex = 45;
            this.label11.Text = "(optional)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 16);
            this.label12.TabIndex = 44;
            this.label12.Text = "Additional PhoneNO.";
            // 
            // txtFirstPhoneNo
            // 
            this.txtFirstPhoneNo.Animated = true;
            this.txtFirstPhoneNo.AutoRoundedCorners = true;
            this.txtFirstPhoneNo.BorderRadius = 13;
            this.txtFirstPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstPhoneNo.DefaultText = "";
            this.txtFirstPhoneNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstPhoneNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstPhoneNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstPhoneNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstPhoneNo.FillColor = System.Drawing.Color.Silver;
            this.txtFirstPhoneNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstPhoneNo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFirstPhoneNo.ForeColor = System.Drawing.Color.Black;
            this.txtFirstPhoneNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstPhoneNo.Location = new System.Drawing.Point(151, 70);
            this.txtFirstPhoneNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstPhoneNo.Name = "txtFirstPhoneNo";
            this.txtFirstPhoneNo.PasswordChar = '\0';
            this.txtFirstPhoneNo.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtFirstPhoneNo.PlaceholderText = "Enter PhoneNO.";
            this.txtFirstPhoneNo.SelectedText = "";
            this.txtFirstPhoneNo.Size = new System.Drawing.Size(193, 29);
            this.txtFirstPhoneNo.TabIndex = 43;
            this.txtFirstPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstPhoneNo_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 16);
            this.label13.TabIndex = 42;
            this.label13.Text = "Contact PhoneNO.";
            // 
            // txtContactName
            // 
            this.txtContactName.Animated = true;
            this.txtContactName.AutoRoundedCorners = true;
            this.txtContactName.BorderRadius = 13;
            this.txtContactName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactName.DefaultText = "";
            this.txtContactName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContactName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContactName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContactName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContactName.FillColor = System.Drawing.Color.Silver;
            this.txtContactName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContactName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtContactName.ForeColor = System.Drawing.Color.Black;
            this.txtContactName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContactName.Location = new System.Drawing.Point(151, 13);
            this.txtContactName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.PasswordChar = '\0';
            this.txtContactName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtContactName.PlaceholderText = "Enter Name";
            this.txtContactName.SelectedText = "";
            this.txtContactName.Size = new System.Drawing.Size(193, 29);
            this.txtContactName.TabIndex = 41;
            this.txtContactName.Tag = "ContactName";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 16);
            this.label14.TabIndex = 40;
            this.label14.Text = "Contact Name";
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
            // llblEmergency
            // 
            this.llblEmergency.AutoSize = true;
            this.llblEmergency.Location = new System.Drawing.Point(431, 343);
            this.llblEmergency.Name = "llblEmergency";
            this.llblEmergency.Size = new System.Drawing.Size(157, 19);
            this.llblEmergency.TabIndex = 34;
            this.llblEmergency.TabStop = true;
            this.llblEmergency.Text = "Add Emergency Contact";
            this.llblEmergency.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblEmergency_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Hospital_Management_System.Properties.Resources.Close_48;
            this.btnClose.Location = new System.Drawing.Point(639, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 39;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbxHealthInfo
            // 
            this.gbxHealthInfo.BorderRadius = 10;
            this.gbxHealthInfo.Controls.Add(this.label9);
            this.gbxHealthInfo.Controls.Add(this.txtNotes);
            this.gbxHealthInfo.Controls.Add(this.label8);
            this.gbxHealthInfo.Controls.Add(this.cbxBloodType);
            this.gbxHealthInfo.Controls.Add(this.txtAllergies);
            this.gbxHealthInfo.Controls.Add(this.label7);
            this.gbxHealthInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.gbxHealthInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gbxHealthInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbxHealthInfo.ForeColor = System.Drawing.Color.Black;
            this.gbxHealthInfo.Location = new System.Drawing.Point(32, 469);
            this.gbxHealthInfo.Name = "gbxHealthInfo";
            this.gbxHealthInfo.Size = new System.Drawing.Size(602, 212);
            this.gbxHealthInfo.TabIndex = 37;
            this.gbxHealthInfo.Text = "Health information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(453, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Animated = true;
            this.txtNotes.BackColor = System.Drawing.Color.Transparent;
            this.txtNotes.BorderRadius = 10;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.ForeColor = System.Drawing.Color.Black;
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Location = new System.Drawing.Point(390, 76);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(198, 117);
            this.txtNotes.TabIndex = 36;
            this.txtNotes.Tag = "notes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(27, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Allergies";
            // 
            // txtAllergies
            // 
            this.txtAllergies.Animated = true;
            this.txtAllergies.BackColor = System.Drawing.Color.Transparent;
            this.txtAllergies.BorderRadius = 10;
            this.txtAllergies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAllergies.DefaultText = "";
            this.txtAllergies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAllergies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAllergies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAllergies.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAllergies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAllergies.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAllergies.ForeColor = System.Drawing.Color.Black;
            this.txtAllergies.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAllergies.Location = new System.Drawing.Point(147, 110);
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.PasswordChar = '\0';
            this.txtAllergies.PlaceholderText = "";
            this.txtAllergies.SelectedText = "";
            this.txtAllergies.Size = new System.Drawing.Size(198, 83);
            this.txtAllergies.TabIndex = 34;
            this.txtAllergies.Tag = "Allergies";
            this.txtAllergies.Validating += new System.ComponentModel.CancelEventHandler(this.CheckIfTextBoxISEmpty);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 16;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(488, 688);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 34);
            this.btnSave.TabIndex = 38;
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
            // frmAddNewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(680, 734);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxHealthInfo);
            this.Controls.Add(this.gbxPersonalInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNewPatient";
            this.Text = "frmAddNewPatient";
            this.Load += new System.EventHandler(this.frmAddNewPatient_Load);
            this.pnlPatientImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPatientImage)).EndInit();
            this.gbxPersonalInfo.ResumeLayout(false);
            this.gbxPersonalInfo.PerformLayout();
            this.pnlAddEmergencyContact.ResumeLayout(false);
            this.pnlAddEmergencyContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.gbxHealthInfo.ResumeLayout(false);
            this.gbxHealthInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pnlPatientImage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbxEditImage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbxPatientImage;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2ComboBox cbxGendor;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtNationalNo;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxBloodType;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GroupBox gbxPersonalInfo;
        private Guna.UI2.WinForms.Guna2GroupBox gbxHealthInfo;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtAllergies;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel llblRemoveImage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel llblEmergency;
        private Guna.UI2.WinForms.Guna2Panel pnlAddEmergencyContact;
        private Guna.UI2.WinForms.Guna2Button btnSaveContact;
        private Guna.UI2.WinForms.Guna2ComboBox cbxRWP;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtSecPhoneNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstPhoneNo;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtContactName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}