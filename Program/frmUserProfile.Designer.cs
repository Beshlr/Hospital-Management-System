namespace Hospital_Management_System
{
    partial class frmUserProfile
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRoleName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pbxHideShowPass = new System.Windows.Forms.PictureBox();
            this.rbtnActiveYES = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnActiveNO = new Guna.UI2.WinForms.Guna2RadioButton();
            this.gbxRoles = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbtnPatient = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnDoctor = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnAdmin = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnSecretary = new Guna.UI2.WinForms.Guna2RadioButton();
            this.ctrlAddNewPicture1 = new Hospital_Management_System.Global.Controls.ctrlAddNewPicture();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHideShowPass)).BeginInit();
            this.gbxRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(25, 281);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(90, 18);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Animated = true;
            this.txtUsername.AutoRoundedCorners = true;
            this.txtUsername.BorderRadius = 19;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(118, 273);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Enter Your Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(265, 41);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.AutoRoundedCorners = true;
            this.txtPassword.BorderRadius = 19;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(118, 327);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.PlaceholderText = "Enter Your Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(265, 41);
            this.txtPassword.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.AutoRoundedCorners = true;
            this.txtEmail.BorderRadius = 19;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(118, 388);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Enter your email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(265, 41);
            this.txtEmail.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "UserID:";
            // 
            // lblUserID
            // 
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.Red;
            this.lblUserID.Location = new System.Drawing.Point(121, 232);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(53, 22);
            this.lblUserID.TabIndex = 12;
            this.lblUserID.Text = "[????]";
            // 
            // lblRoleName
            // 
            this.lblRoleName.BackColor = System.Drawing.Color.Transparent;
            this.lblRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleName.ForeColor = System.Drawing.Color.Red;
            this.lblRoleName.Location = new System.Drawing.Point(338, 232);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(53, 22);
            this.lblRoleName.TabIndex = 14;
            this.lblRoleName.Text = "Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Role:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Is Active:";
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Animated = true;
            this.btnSaveEdit.AutoRoundedCorners = true;
            this.btnSaveEdit.BorderRadius = 15;
            this.btnSaveEdit.BorderThickness = 1;
            this.btnSaveEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveEdit.FillColor = System.Drawing.Color.Green;
            this.btnSaveEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveEdit.ForeColor = System.Drawing.Color.White;
            this.btnSaveEdit.IndicateFocus = true;
            this.btnSaveEdit.Location = new System.Drawing.Point(176, 574);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(108, 33);
            this.btnSaveEdit.TabIndex = 17;
            this.btnSaveEdit.Text = "Save";
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BorderRadius = 15;
            this.btnClose.BorderThickness = 1;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(302, 574);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 33);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbxHideShowPass
            // 
            this.pbxHideShowPass.BackColor = System.Drawing.Color.Transparent;
            this.pbxHideShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxHideShowPass.Image = global::Hospital_Management_System.Properties.Resources.OpenEye_Password;
            this.pbxHideShowPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbxHideShowPass.Location = new System.Drawing.Point(345, 334);
            this.pbxHideShowPass.Name = "pbxHideShowPass";
            this.pbxHideShowPass.Size = new System.Drawing.Size(31, 30);
            this.pbxHideShowPass.TabIndex = 19;
            this.pbxHideShowPass.TabStop = false;
            this.pbxHideShowPass.Click += new System.EventHandler(this.pbxShowHidePass_Click);
            // 
            // rbtnActiveYES
            // 
            this.rbtnActiveYES.AutoSize = true;
            this.rbtnActiveYES.Checked = true;
            this.rbtnActiveYES.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnActiveYES.CheckedState.BorderThickness = 0;
            this.rbtnActiveYES.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnActiveYES.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnActiveYES.CheckedState.InnerOffset = -4;
            this.rbtnActiveYES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActiveYES.ForeColor = System.Drawing.Color.Green;
            this.rbtnActiveYES.Location = new System.Drawing.Point(121, 452);
            this.rbtnActiveYES.Name = "rbtnActiveYES";
            this.rbtnActiveYES.Size = new System.Drawing.Size(63, 24);
            this.rbtnActiveYES.TabIndex = 20;
            this.rbtnActiveYES.Text = "YES";
            this.rbtnActiveYES.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnActiveYES.UncheckedState.BorderThickness = 2;
            this.rbtnActiveYES.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnActiveYES.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtnActiveNO
            // 
            this.rbtnActiveNO.AutoSize = true;
            this.rbtnActiveNO.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnActiveNO.CheckedState.BorderThickness = 0;
            this.rbtnActiveNO.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnActiveNO.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnActiveNO.CheckedState.InnerOffset = -4;
            this.rbtnActiveNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActiveNO.ForeColor = System.Drawing.Color.Red;
            this.rbtnActiveNO.Location = new System.Drawing.Point(209, 452);
            this.rbtnActiveNO.Name = "rbtnActiveNO";
            this.rbtnActiveNO.Size = new System.Drawing.Size(52, 24);
            this.rbtnActiveNO.TabIndex = 21;
            this.rbtnActiveNO.Text = "NO";
            this.rbtnActiveNO.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnActiveNO.UncheckedState.BorderThickness = 2;
            this.rbtnActiveNO.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnActiveNO.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // gbxRoles
            // 
            this.gbxRoles.Controls.Add(this.rbtnAdmin);
            this.gbxRoles.Controls.Add(this.rbtnSecretary);
            this.gbxRoles.Controls.Add(this.rbtnPatient);
            this.gbxRoles.Controls.Add(this.rbtnDoctor);
            this.gbxRoles.Controls.Add(this.label6);
            this.gbxRoles.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gbxRoles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbxRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbxRoles.Location = new System.Drawing.Point(41, 487);
            this.gbxRoles.Name = "gbxRoles";
            this.gbxRoles.Size = new System.Drawing.Size(342, 76);
            this.gbxRoles.TabIndex = 22;
            this.gbxRoles.Visible = false;
            // 
            // rbtnPatient
            // 
            this.rbtnPatient.AutoSize = true;
            this.rbtnPatient.Checked = true;
            this.rbtnPatient.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnPatient.CheckedState.BorderThickness = 0;
            this.rbtnPatient.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnPatient.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnPatient.CheckedState.InnerOffset = -4;
            this.rbtnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPatient.ForeColor = System.Drawing.Color.Black;
            this.rbtnPatient.Location = new System.Drawing.Point(91, 11);
            this.rbtnPatient.Name = "rbtnPatient";
            this.rbtnPatient.Size = new System.Drawing.Size(84, 24);
            this.rbtnPatient.TabIndex = 24;
            this.rbtnPatient.TabStop = true;
            this.rbtnPatient.Text = "Patient";
            this.rbtnPatient.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnPatient.UncheckedState.BorderThickness = 2;
            this.rbtnPatient.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnPatient.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtnDoctor
            // 
            this.rbtnDoctor.AutoSize = true;
            this.rbtnDoctor.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnDoctor.CheckedState.BorderThickness = 0;
            this.rbtnDoctor.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnDoctor.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnDoctor.CheckedState.InnerOffset = -4;
            this.rbtnDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDoctor.ForeColor = System.Drawing.Color.Black;
            this.rbtnDoctor.Location = new System.Drawing.Point(91, 41);
            this.rbtnDoctor.Name = "rbtnDoctor";
            this.rbtnDoctor.Size = new System.Drawing.Size(81, 24);
            this.rbtnDoctor.TabIndex = 23;
            this.rbtnDoctor.Text = "Doctor";
            this.rbtnDoctor.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnDoctor.UncheckedState.BorderThickness = 2;
            this.rbtnDoctor.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnDoctor.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Role :";
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnAdmin.CheckedState.BorderThickness = 0;
            this.rbtnAdmin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnAdmin.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnAdmin.CheckedState.InnerOffset = -4;
            this.rbtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAdmin.ForeColor = System.Drawing.Color.Black;
            this.rbtnAdmin.Location = new System.Drawing.Point(234, 38);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(77, 24);
            this.rbtnAdmin.TabIndex = 26;
            this.rbtnAdmin.Text = "Admin";
            this.rbtnAdmin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnAdmin.UncheckedState.BorderThickness = 2;
            this.rbtnAdmin.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnAdmin.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtnSecretary
            // 
            this.rbtnSecretary.AutoSize = true;
            this.rbtnSecretary.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnSecretary.CheckedState.BorderThickness = 0;
            this.rbtnSecretary.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnSecretary.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnSecretary.CheckedState.InnerOffset = -4;
            this.rbtnSecretary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSecretary.ForeColor = System.Drawing.Color.Black;
            this.rbtnSecretary.Location = new System.Drawing.Point(234, 8);
            this.rbtnSecretary.Name = "rbtnSecretary";
            this.rbtnSecretary.Size = new System.Drawing.Size(104, 24);
            this.rbtnSecretary.TabIndex = 25;
            this.rbtnSecretary.Text = "Secretary";
            this.rbtnSecretary.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnSecretary.UncheckedState.BorderThickness = 2;
            this.rbtnSecretary.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnSecretary.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // ctrlAddNewPicture1
            // 
            this.ctrlAddNewPicture1.Location = new System.Drawing.Point(118, 12);
            this.ctrlAddNewPicture1.Name = "ctrlAddNewPicture1";
            this.ctrlAddNewPicture1.Size = new System.Drawing.Size(185, 201);
            this.ctrlAddNewPicture1.TabIndex = 0;
            this.ctrlAddNewPicture1.Load += new System.EventHandler(this.ctrlAddNewPicture1_Load);
            // 
            // frmUserProfile
            // 
            this.AcceptButton = this.btnSaveEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(421, 619);
            this.Controls.Add(this.gbxRoles);
            this.Controls.Add(this.rbtnActiveNO);
            this.Controls.Add(this.rbtnActiveYES);
            this.Controls.Add(this.pbxHideShowPass);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.ctrlAddNewPicture1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Info.";
            this.Load += new System.EventHandler(this.frmUserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxHideShowPass)).EndInit();
            this.gbxRoles.ResumeLayout(false);
            this.gbxRoles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Global.Controls.ctrlAddNewPicture ctrlAddNewPicture1;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUserID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRoleName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnSaveEdit;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.PictureBox pbxHideShowPass;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnActiveYES;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnActiveNO;
        private Guna.UI2.WinForms.Guna2GroupBox gbxRoles;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnAdmin;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnSecretary;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnPatient;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnDoctor;
        private System.Windows.Forms.Label label6;
    }
}