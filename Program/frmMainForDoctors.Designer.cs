namespace Hospital_Management_System
{
    partial class frmMainForDoctors
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
            this.pnlSubMenuGeneral = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPatients = new Guna.UI2.WinForms.Guna2Button();
            this.btnAppointments = new Guna.UI2.WinForms.Guna2Button();
            this.pnlAppLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.pbxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlUserImage = new System.Windows.Forms.Panel();
            this.pbxUserImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.pnlLoginUserDetails = new System.Windows.Forms.Panel();
            this.pnlPuttons = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnRooms = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSubMenuPharmacy = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRequests = new Guna.UI2.WinForms.Guna2Button();
            this.btnInventory = new Guna.UI2.WinForms.Guna2Button();
            this.btnPharmacy = new Guna.UI2.WinForms.Guna2Button();
            this.btnGeneral = new Guna.UI2.WinForms.Guna2Button();
            this.pnlControl = new Guna.UI2.WinForms.Guna2Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pnlSubMenuGeneral.SuspendLayout();
            this.pnlAppLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlUserImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserImage)).BeginInit();
            this.pnlUsername.SuspendLayout();
            this.pnlLoginUserDetails.SuspendLayout();
            this.pnlPuttons.SuspendLayout();
            this.pnlSubMenuPharmacy.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSubMenuGeneral
            // 
            this.pnlSubMenuGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.pnlSubMenuGeneral.Controls.Add(this.btnPatients);
            this.pnlSubMenuGeneral.Controls.Add(this.btnAppointments);
            this.pnlSubMenuGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuGeneral.Location = new System.Drawing.Point(0, 60);
            this.pnlSubMenuGeneral.Name = "pnlSubMenuGeneral";
            this.pnlSubMenuGeneral.Size = new System.Drawing.Size(238, 163);
            this.pnlSubMenuGeneral.TabIndex = 8;
            // 
            // btnPatients
            // 
            this.btnPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPatients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPatients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPatients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatients.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnPatients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPatients.ForeColor = System.Drawing.Color.Black;
            this.btnPatients.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(134)))), ((int)(((byte)(205)))));
            this.btnPatients.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(144)))), ((int)(((byte)(225)))));
            this.btnPatients.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnPatients.Image = global::Hospital_Management_System.Properties.Resources.Patient_128;
            this.btnPatients.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPatients.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnPatients.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPatients.Location = new System.Drawing.Point(0, 49);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnPatients.Size = new System.Drawing.Size(238, 49);
            this.btnPatients.TabIndex = 10;
            this.btnPatients.Text = "Patients";
            this.btnPatients.Click += new System.EventHandler(this.btnAdmissions_Click);
            // 
            // btnAppointments
            // 
            this.btnAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppointments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAppointments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAppointments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAppointments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppointments.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnAppointments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAppointments.ForeColor = System.Drawing.Color.Black;
            this.btnAppointments.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(134)))), ((int)(((byte)(205)))));
            this.btnAppointments.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(144)))), ((int)(((byte)(225)))));
            this.btnAppointments.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAppointments.Image = global::Hospital_Management_System.Properties.Resources.Calender_64;
            this.btnAppointments.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAppointments.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnAppointments.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAppointments.Location = new System.Drawing.Point(0, 0);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnAppointments.Size = new System.Drawing.Size(238, 49);
            this.btnAppointments.TabIndex = 9;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // pnlAppLogo
            // 
            this.pnlAppLogo.Controls.Add(this.pbxLogo);
            this.pnlAppLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAppLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlAppLogo.Name = "pnlAppLogo";
            this.pnlAppLogo.Size = new System.Drawing.Size(238, 103);
            this.pnlAppLogo.TabIndex = 0;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxLogo.Image = global::Hospital_Management_System.Properties.Resources.Hospital_Icon_5121;
            this.pbxLogo.ImageRotate = 0F;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(238, 96);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // pnlUserImage
            // 
            this.pnlUserImage.Controls.Add(this.pbxUserImage);
            this.pnlUserImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUserImage.Location = new System.Drawing.Point(188, 0);
            this.pnlUserImage.Name = "pnlUserImage";
            this.pnlUserImage.Size = new System.Drawing.Size(50, 52);
            this.pnlUserImage.TabIndex = 2;
            // 
            // pbxUserImage
            // 
            this.pbxUserImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxUserImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxUserImage.Image = global::Hospital_Management_System.Properties.Resources.accountProfileIcon11;
            this.pbxUserImage.ImageRotate = 0F;
            this.pbxUserImage.Location = new System.Drawing.Point(7, 8);
            this.pbxUserImage.Name = "pbxUserImage";
            this.pbxUserImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbxUserImage.Size = new System.Drawing.Size(37, 36);
            this.pbxUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUserImage.TabIndex = 0;
            this.pbxUserImage.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Gray;
            this.lblUsername.Location = new System.Drawing.Point(65, 17);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(54, 18);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Admin";
            // 
            // pnlUsername
            // 
            this.pnlUsername.Controls.Add(this.lblUsername);
            this.pnlUsername.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUsername.Location = new System.Drawing.Point(3, 0);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(185, 52);
            this.pnlUsername.TabIndex = 3;
            // 
            // pnlLoginUserDetails
            // 
            this.pnlLoginUserDetails.Controls.Add(this.pnlUsername);
            this.pnlLoginUserDetails.Controls.Add(this.pnlUserImage);
            this.pnlLoginUserDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLoginUserDetails.Location = new System.Drawing.Point(0, 762);
            this.pnlLoginUserDetails.Name = "pnlLoginUserDetails";
            this.pnlLoginUserDetails.Size = new System.Drawing.Size(238, 52);
            this.pnlLoginUserDetails.TabIndex = 3;
            // 
            // pnlPuttons
            // 
            this.pnlPuttons.Controls.Add(this.pnlLoginUserDetails);
            this.pnlPuttons.Controls.Add(this.btnLogOut);
            this.pnlPuttons.Controls.Add(this.btnSettings);
            this.pnlPuttons.Controls.Add(this.btnRooms);
            this.pnlPuttons.Controls.Add(this.pnlSubMenuPharmacy);
            this.pnlPuttons.Controls.Add(this.btnPharmacy);
            this.pnlPuttons.Controls.Add(this.pnlSubMenuGeneral);
            this.pnlPuttons.Controls.Add(this.btnGeneral);
            this.pnlPuttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPuttons.Location = new System.Drawing.Point(0, 103);
            this.pnlPuttons.Name = "pnlPuttons";
            this.pnlPuttons.Size = new System.Drawing.Size(238, 814);
            this.pnlPuttons.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Red;
            this.btnLogOut.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnLogOut.Image = global::Hospital_Management_System.Properties.Resources.Logout_64;
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnLogOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogOut.Location = new System.Drawing.Point(0, 525);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnLogOut.Size = new System.Drawing.Size(238, 60);
            this.btnLogOut.TabIndex = 22;
            this.btnLogOut.Text = "Logout";
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnSettings.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnSettings.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::Hospital_Management_System.Properties.Resources.Settings;
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnSettings.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSettings.Location = new System.Drawing.Point(0, 465);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnSettings.Size = new System.Drawing.Size(238, 60);
            this.btnSettings.TabIndex = 21;
            this.btnSettings.Text = "Settings";
            // 
            // btnRooms
            // 
            this.btnRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRooms.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRooms.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.ForeColor = System.Drawing.Color.Black;
            this.btnRooms.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnRooms.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnRooms.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRooms.Image = global::Hospital_Management_System.Properties.Resources.facility_management;
            this.btnRooms.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRooms.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnRooms.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRooms.Location = new System.Drawing.Point(0, 405);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnRooms.Size = new System.Drawing.Size(238, 60);
            this.btnRooms.TabIndex = 17;
            this.btnRooms.Text = "Rooms";
            // 
            // pnlSubMenuPharmacy
            // 
            this.pnlSubMenuPharmacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.pnlSubMenuPharmacy.Controls.Add(this.btnRequests);
            this.pnlSubMenuPharmacy.Controls.Add(this.btnInventory);
            this.pnlSubMenuPharmacy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuPharmacy.Location = new System.Drawing.Point(0, 283);
            this.pnlSubMenuPharmacy.Name = "pnlSubMenuPharmacy";
            this.pnlSubMenuPharmacy.Size = new System.Drawing.Size(238, 122);
            this.pnlSubMenuPharmacy.TabIndex = 14;
            // 
            // btnRequests
            // 
            this.btnRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequests.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRequests.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRequests.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRequests.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRequests.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnRequests.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRequests.ForeColor = System.Drawing.Color.Black;
            this.btnRequests.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(134)))), ((int)(((byte)(205)))));
            this.btnRequests.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(144)))), ((int)(((byte)(225)))));
            this.btnRequests.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRequests.Image = global::Hospital_Management_System.Properties.Resources.Requests_64;
            this.btnRequests.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRequests.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnRequests.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRequests.Location = new System.Drawing.Point(-4, 65);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnRequests.Size = new System.Drawing.Size(239, 49);
            this.btnRequests.TabIndex = 10;
            this.btnRequests.Text = "Requests";
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInventory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInventory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInventory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInventory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnInventory.ForeColor = System.Drawing.Color.Black;
            this.btnInventory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(134)))), ((int)(((byte)(205)))));
            this.btnInventory.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(144)))), ((int)(((byte)(225)))));
            this.btnInventory.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = global::Hospital_Management_System.Properties.Resources.Inventory_64;
            this.btnInventory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInventory.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnInventory.ImageSize = new System.Drawing.Size(25, 25);
            this.btnInventory.Location = new System.Drawing.Point(-7, 6);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnInventory.Size = new System.Drawing.Size(242, 49);
            this.btnInventory.TabIndex = 9;
            this.btnInventory.Text = "Inventory";
            // 
            // btnPharmacy
            // 
            this.btnPharmacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnPharmacy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPharmacy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPharmacy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPharmacy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPharmacy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPharmacy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPharmacy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPharmacy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPharmacy.ForeColor = System.Drawing.Color.Black;
            this.btnPharmacy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnPharmacy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnPharmacy.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnPharmacy.Image = global::Hospital_Management_System.Properties.Resources.Pharmacy_64;
            this.btnPharmacy.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPharmacy.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnPharmacy.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPharmacy.Location = new System.Drawing.Point(0, 223);
            this.btnPharmacy.Name = "btnPharmacy";
            this.btnPharmacy.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnPharmacy.Size = new System.Drawing.Size(238, 60);
            this.btnPharmacy.TabIndex = 15;
            this.btnPharmacy.Text = "Pharmacy";
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneral.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneral.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneral.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGeneral.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneral.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGeneral.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneral.ForeColor = System.Drawing.Color.Black;
            this.btnGeneral.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnGeneral.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnGeneral.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnGeneral.Image = global::Hospital_Management_System.Properties.Resources.DashBoard_64;
            this.btnGeneral.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGeneral.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnGeneral.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGeneral.Location = new System.Drawing.Point(0, 0);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnGeneral.Size = new System.Drawing.Size(238, 60);
            this.btnGeneral.TabIndex = 0;
            this.btnGeneral.Text = "General";
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.AutoScroll = true;
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlControl.Controls.Add(this.pnlPuttons);
            this.pnlControl.Controls.Add(this.pnlAppLogo);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(238, 917);
            this.pnlControl.TabIndex = 2;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1111, 917);
            this.panelChildForm.TabIndex = 3;
            // 
            // frmMainForDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 917);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.panelChildForm);
            this.Name = "frmMainForDoctors";
            this.Text = "frmMainForDoctors";
            this.pnlSubMenuGeneral.ResumeLayout(false);
            this.pnlAppLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlUserImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserImage)).EndInit();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.pnlLoginUserDetails.ResumeLayout(false);
            this.pnlPuttons.ResumeLayout(false);
            this.pnlSubMenuPharmacy.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbxLogo;
        private Guna.UI2.WinForms.Guna2Button btnAppointments;
        private Guna.UI2.WinForms.Guna2Panel pnlSubMenuGeneral;
        private Guna.UI2.WinForms.Guna2Button btnPharmacy;
        private Guna.UI2.WinForms.Guna2Panel pnlAppLogo;
        private Guna.UI2.WinForms.Guna2Button btnRequests;
        private Guna.UI2.WinForms.Guna2Button btnInventory;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnRooms;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbxUserImage;
        private System.Windows.Forms.Panel pnlUserImage;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Panel pnlLoginUserDetails;
        private Guna.UI2.WinForms.Guna2Panel pnlPuttons;
        private Guna.UI2.WinForms.Guna2Panel pnlSubMenuPharmacy;
        private Guna.UI2.WinForms.Guna2Panel pnlControl;
        private System.Windows.Forms.Panel panelChildForm;
        private Guna.UI2.WinForms.Guna2Button btnGeneral;
        private Guna.UI2.WinForms.Guna2Button btnPatients;
    }
}