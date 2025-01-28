namespace Hospital_Management_System
{
    partial class frmMainForSecretary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForSecretary));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlControl = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlPuttons = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSubMenuPharmacy = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSubMenuMedicalRecords = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSubMenuStaf = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSubMenuGeneral = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlAppLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnRooms = new Guna.UI2.WinForms.Guna2Button();
            this.btnRequests = new Guna.UI2.WinForms.Guna2Button();
            this.btnInventory = new Guna.UI2.WinForms.Guna2Button();
            this.btnPharmacy = new Guna.UI2.WinForms.Guna2Button();
            this.btnLabResults = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrescriptions = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedicalHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedicalRecords = new Guna.UI2.WinForms.Guna2Button();
            this.btnHRManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnStaffScheduling = new Guna.UI2.WinForms.Guna2Button();
            this.btnNurses = new Guna.UI2.WinForms.Guna2Button();
            this.btnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.btnPayments = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdmissions = new Guna.UI2.WinForms.Guna2Button();
            this.btnAppointments = new Guna.UI2.WinForms.Guna2Button();
            this.btnGeneral = new Guna.UI2.WinForms.Guna2Button();
            this.pbxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.pnlPuttons.SuspendLayout();
            this.pnlSubMenuPharmacy.SuspendLayout();
            this.pnlSubMenuMedicalRecords.SuspendLayout();
            this.pnlSubMenuStaf.SuspendLayout();
            this.pnlSubMenuGeneral.SuspendLayout();
            this.pnlAppLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "user.png");
            this.imageList1.Images.SetKeyName(1, "7853756_menu_kashifarif_more_list_check list_icon.png");
            this.imageList1.Images.SetKeyName(2, "appointment.png");
            this.imageList1.Images.SetKeyName(3, "AddNewPatient.png");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.pnlControl.Size = new System.Drawing.Size(238, 697);
            this.pnlControl.TabIndex = 0;
            // 
            // pnlPuttons
            // 
            this.pnlPuttons.AutoScroll = true;
            this.pnlPuttons.Controls.Add(this.btnLogOut);
            this.pnlPuttons.Controls.Add(this.btnSettings);
            this.pnlPuttons.Controls.Add(this.btnRooms);
            this.pnlPuttons.Controls.Add(this.pnlSubMenuPharmacy);
            this.pnlPuttons.Controls.Add(this.btnPharmacy);
            this.pnlPuttons.Controls.Add(this.pnlSubMenuMedicalRecords);
            this.pnlPuttons.Controls.Add(this.btnMedicalRecords);
            this.pnlPuttons.Controls.Add(this.pnlSubMenuStaf);
            this.pnlPuttons.Controls.Add(this.btnStaff);
            this.pnlPuttons.Controls.Add(this.pnlSubMenuGeneral);
            this.pnlPuttons.Controls.Add(this.btnGeneral);
            this.pnlPuttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPuttons.Location = new System.Drawing.Point(0, 103);
            this.pnlPuttons.Name = "pnlPuttons";
            this.pnlPuttons.Size = new System.Drawing.Size(221, 1064);
            this.pnlPuttons.TabIndex = 1;
            // 
            // pnlSubMenuPharmacy
            // 
            this.pnlSubMenuPharmacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.pnlSubMenuPharmacy.Controls.Add(this.btnRequests);
            this.pnlSubMenuPharmacy.Controls.Add(this.btnInventory);
            this.pnlSubMenuPharmacy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuPharmacy.Location = new System.Drawing.Point(0, 773);
            this.pnlSubMenuPharmacy.Name = "pnlSubMenuPharmacy";
            this.pnlSubMenuPharmacy.Size = new System.Drawing.Size(221, 109);
            this.pnlSubMenuPharmacy.TabIndex = 14;
            // 
            // pnlSubMenuMedicalRecords
            // 
            this.pnlSubMenuMedicalRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.pnlSubMenuMedicalRecords.Controls.Add(this.btnLabResults);
            this.pnlSubMenuMedicalRecords.Controls.Add(this.btnPrescriptions);
            this.pnlSubMenuMedicalRecords.Controls.Add(this.btnMedicalHistory);
            this.pnlSubMenuMedicalRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSubMenuMedicalRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuMedicalRecords.Location = new System.Drawing.Point(0, 536);
            this.pnlSubMenuMedicalRecords.Name = "pnlSubMenuMedicalRecords";
            this.pnlSubMenuMedicalRecords.Size = new System.Drawing.Size(221, 177);
            this.pnlSubMenuMedicalRecords.TabIndex = 13;
            // 
            // pnlSubMenuStaf
            // 
            this.pnlSubMenuStaf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.pnlSubMenuStaf.Controls.Add(this.btnHRManagement);
            this.pnlSubMenuStaf.Controls.Add(this.btnStaffScheduling);
            this.pnlSubMenuStaf.Controls.Add(this.btnNurses);
            this.pnlSubMenuStaf.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuStaf.Location = new System.Drawing.Point(0, 298);
            this.pnlSubMenuStaf.Name = "pnlSubMenuStaf";
            this.pnlSubMenuStaf.Size = new System.Drawing.Size(221, 178);
            this.pnlSubMenuStaf.TabIndex = 12;
            // 
            // pnlSubMenuGeneral
            // 
            this.pnlSubMenuGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.pnlSubMenuGeneral.Controls.Add(this.btnPayments);
            this.pnlSubMenuGeneral.Controls.Add(this.btnAdmissions);
            this.pnlSubMenuGeneral.Controls.Add(this.btnAppointments);
            this.pnlSubMenuGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuGeneral.Location = new System.Drawing.Point(0, 60);
            this.pnlSubMenuGeneral.Name = "pnlSubMenuGeneral";
            this.pnlSubMenuGeneral.Size = new System.Drawing.Size(221, 178);
            this.pnlSubMenuGeneral.TabIndex = 8;
            // 
            // pnlAppLogo
            // 
            this.pnlAppLogo.Controls.Add(this.pbxLogo);
            this.pnlAppLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAppLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlAppLogo.Name = "pnlAppLogo";
            this.pnlAppLogo.Size = new System.Drawing.Size(221, 103);
            this.pnlAppLogo.TabIndex = 0;
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
            this.btnLogOut.Image = global::Hospital_Management_System.Properties.Resources.Logout_64;
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogOut.Location = new System.Drawing.Point(0, 1002);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnLogOut.Size = new System.Drawing.Size(221, 60);
            this.btnLogOut.TabIndex = 22;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.btnSettings.Image = global::Hospital_Management_System.Properties.Resources.Settings;
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSettings.Location = new System.Drawing.Point(0, 942);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnSettings.Size = new System.Drawing.Size(221, 60);
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
            this.btnRooms.Image = global::Hospital_Management_System.Properties.Resources.facility_management;
            this.btnRooms.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRooms.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRooms.Location = new System.Drawing.Point(0, 882);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnRooms.Size = new System.Drawing.Size(221, 60);
            this.btnRooms.TabIndex = 17;
            this.btnRooms.Text = "Rooms";
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
            this.btnRequests.Image = global::Hospital_Management_System.Properties.Resources.Requests_64;
            this.btnRequests.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRequests.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRequests.Location = new System.Drawing.Point(26, 65);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnRequests.Size = new System.Drawing.Size(204, 37);
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
            this.btnInventory.Image = global::Hospital_Management_System.Properties.Resources.Inventory_64;
            this.btnInventory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInventory.ImageSize = new System.Drawing.Size(25, 25);
            this.btnInventory.Location = new System.Drawing.Point(23, 6);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnInventory.Size = new System.Drawing.Size(201, 37);
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
            this.btnPharmacy.Image = global::Hospital_Management_System.Properties.Resources.Pharmacy_64;
            this.btnPharmacy.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPharmacy.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPharmacy.Location = new System.Drawing.Point(0, 713);
            this.btnPharmacy.Name = "btnPharmacy";
            this.btnPharmacy.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnPharmacy.Size = new System.Drawing.Size(221, 60);
            this.btnPharmacy.TabIndex = 15;
            this.btnPharmacy.Text = "Pharmacy";
            this.btnPharmacy.Click += new System.EventHandler(this.btnPharmacy_Click);
            // 
            // btnLabResults
            // 
            this.btnLabResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnLabResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLabResults.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLabResults.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLabResults.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLabResults.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLabResults.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnLabResults.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLabResults.ForeColor = System.Drawing.Color.Black;
            this.btnLabResults.Image = global::Hospital_Management_System.Properties.Resources.Lab_Result_64;
            this.btnLabResults.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLabResults.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLabResults.Location = new System.Drawing.Point(20, 124);
            this.btnLabResults.Name = "btnLabResults";
            this.btnLabResults.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnLabResults.Size = new System.Drawing.Size(201, 37);
            this.btnLabResults.TabIndex = 11;
            this.btnLabResults.Text = "Lab Results";
            // 
            // btnPrescriptions
            // 
            this.btnPrescriptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnPrescriptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrescriptions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrescriptions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrescriptions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrescriptions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrescriptions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnPrescriptions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrescriptions.ForeColor = System.Drawing.Color.Black;
            this.btnPrescriptions.Image = global::Hospital_Management_System.Properties.Resources._5978959_drugs_medicine_pills_tablets_icon;
            this.btnPrescriptions.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPrescriptions.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPrescriptions.Location = new System.Drawing.Point(20, 65);
            this.btnPrescriptions.Name = "btnPrescriptions";
            this.btnPrescriptions.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnPrescriptions.Size = new System.Drawing.Size(201, 37);
            this.btnPrescriptions.TabIndex = 10;
            this.btnPrescriptions.Text = "Prescriptions";
            // 
            // btnMedicalHistory
            // 
            this.btnMedicalHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnMedicalHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicalHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicalHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicalHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedicalHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedicalHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnMedicalHistory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMedicalHistory.ForeColor = System.Drawing.Color.Black;
            this.btnMedicalHistory.Image = global::Hospital_Management_System.Properties.Resources.History_64;
            this.btnMedicalHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMedicalHistory.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMedicalHistory.Location = new System.Drawing.Point(23, 6);
            this.btnMedicalHistory.Name = "btnMedicalHistory";
            this.btnMedicalHistory.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnMedicalHistory.Size = new System.Drawing.Size(201, 37);
            this.btnMedicalHistory.TabIndex = 9;
            this.btnMedicalHistory.Text = "Medical History";
            // 
            // btnMedicalRecords
            // 
            this.btnMedicalRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnMedicalRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicalRecords.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicalRecords.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicalRecords.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedicalRecords.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedicalRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicalRecords.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMedicalRecords.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicalRecords.ForeColor = System.Drawing.Color.Black;
            this.btnMedicalRecords.Image = global::Hospital_Management_System.Properties.Resources.Records_64;
            this.btnMedicalRecords.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMedicalRecords.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMedicalRecords.Location = new System.Drawing.Point(0, 476);
            this.btnMedicalRecords.Name = "btnMedicalRecords";
            this.btnMedicalRecords.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnMedicalRecords.Size = new System.Drawing.Size(221, 60);
            this.btnMedicalRecords.TabIndex = 13;
            this.btnMedicalRecords.Text = "Medical Records";
            this.btnMedicalRecords.Click += new System.EventHandler(this.btnMedicalRecords_Click);
            // 
            // btnHRManagement
            // 
            this.btnHRManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnHRManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHRManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHRManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHRManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHRManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHRManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnHRManagement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHRManagement.ForeColor = System.Drawing.Color.Black;
            this.btnHRManagement.Image = global::Hospital_Management_System.Properties.Resources.HR_64;
            this.btnHRManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHRManagement.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHRManagement.Location = new System.Drawing.Point(20, 124);
            this.btnHRManagement.Name = "btnHRManagement";
            this.btnHRManagement.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnHRManagement.Size = new System.Drawing.Size(201, 37);
            this.btnHRManagement.TabIndex = 11;
            this.btnHRManagement.Text = "HR Management";
            // 
            // btnStaffScheduling
            // 
            this.btnStaffScheduling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnStaffScheduling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffScheduling.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaffScheduling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaffScheduling.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaffScheduling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaffScheduling.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnStaffScheduling.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStaffScheduling.ForeColor = System.Drawing.Color.Black;
            this.btnStaffScheduling.Image = global::Hospital_Management_System.Properties.Resources._6843080_appointment_calendar_deadline_planing_reminder_icon;
            this.btnStaffScheduling.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaffScheduling.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStaffScheduling.Location = new System.Drawing.Point(20, 65);
            this.btnStaffScheduling.Name = "btnStaffScheduling";
            this.btnStaffScheduling.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnStaffScheduling.Size = new System.Drawing.Size(201, 37);
            this.btnStaffScheduling.TabIndex = 10;
            this.btnStaffScheduling.Text = "Staff Scheduling";
            // 
            // btnNurses
            // 
            this.btnNurses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnNurses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNurses.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNurses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNurses.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNurses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNurses.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnNurses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNurses.ForeColor = System.Drawing.Color.Black;
            this.btnNurses.Image = global::Hospital_Management_System.Properties.Resources.Nurses_64;
            this.btnNurses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNurses.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNurses.Location = new System.Drawing.Point(20, 6);
            this.btnNurses.Name = "btnNurses";
            this.btnNurses.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnNurses.Size = new System.Drawing.Size(201, 37);
            this.btnNurses.TabIndex = 9;
            this.btnNurses.Text = "Nurses";
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.Black;
            this.btnStaff.Image = global::Hospital_Management_System.Properties.Resources.Doctors_64;
            this.btnStaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaff.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStaff.Location = new System.Drawing.Point(0, 238);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnStaff.Size = new System.Drawing.Size(221, 60);
            this.btnStaff.TabIndex = 9;
            this.btnStaff.Text = "Staff";
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayments.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPayments.ForeColor = System.Drawing.Color.Black;
            this.btnPayments.Image = global::Hospital_Management_System.Properties.Resources.Payment_64;
            this.btnPayments.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPayments.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPayments.Location = new System.Drawing.Point(20, 124);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnPayments.Size = new System.Drawing.Size(201, 37);
            this.btnPayments.TabIndex = 11;
            this.btnPayments.Text = "Payments";
            // 
            // btnAdmissions
            // 
            this.btnAdmissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnAdmissions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmissions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmissions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmissions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdmissions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdmissions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnAdmissions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdmissions.ForeColor = System.Drawing.Color.Black;
            this.btnAdmissions.Image = global::Hospital_Management_System.Properties.Resources._309058_key_login_private_protect_protection_icon;
            this.btnAdmissions.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdmissions.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAdmissions.Location = new System.Drawing.Point(20, 65);
            this.btnAdmissions.Name = "btnAdmissions";
            this.btnAdmissions.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnAdmissions.Size = new System.Drawing.Size(201, 37);
            this.btnAdmissions.TabIndex = 10;
            this.btnAdmissions.Text = "Admissions";
            // 
            // btnAppointments
            // 
            this.btnAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppointments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAppointments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAppointments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAppointments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAppointments.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnAppointments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAppointments.ForeColor = System.Drawing.Color.Black;
            this.btnAppointments.Image = global::Hospital_Management_System.Properties.Resources.Calender_64;
            this.btnAppointments.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAppointments.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAppointments.Location = new System.Drawing.Point(20, 6);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnAppointments.Size = new System.Drawing.Size(201, 37);
            this.btnAppointments.TabIndex = 9;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
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
            this.btnGeneral.Image = global::Hospital_Management_System.Properties.Resources.DashBoard_64;
            this.btnGeneral.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGeneral.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGeneral.Location = new System.Drawing.Point(0, 0);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnGeneral.Size = new System.Drawing.Size(221, 60);
            this.btnGeneral.TabIndex = 0;
            this.btnGeneral.Text = "General";
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxLogo.Image = global::Hospital_Management_System.Properties.Resources.Hospital_Icon_5121;
            this.pbxLogo.ImageRotate = 0F;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(221, 96);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(238, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(798, 697);
            this.panelChildForm.TabIndex = 1;
            // 
            // frmMainForSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 697);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.pnlControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainForSecretary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlPuttons.ResumeLayout(false);
            this.pnlSubMenuPharmacy.ResumeLayout(false);
            this.pnlSubMenuMedicalRecords.ResumeLayout(false);
            this.pnlSubMenuStaf.ResumeLayout(false);
            this.pnlSubMenuGeneral.ResumeLayout(false);
            this.pnlAppLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Panel pnlControl;
        private Guna.UI2.WinForms.Guna2Panel pnlAppLogo;
        private Guna.UI2.WinForms.Guna2PictureBox pbxLogo;
        private Guna.UI2.WinForms.Guna2Panel pnlPuttons;
        private Guna.UI2.WinForms.Guna2Button btnGeneral;
        private Guna.UI2.WinForms.Guna2Panel pnlSubMenuStaf;
        private Guna.UI2.WinForms.Guna2Button btnHRManagement;
        private Guna.UI2.WinForms.Guna2Button btnStaffScheduling;
        private Guna.UI2.WinForms.Guna2Button btnNurses;
        private Guna.UI2.WinForms.Guna2Button btnStaff;
        private Guna.UI2.WinForms.Guna2Panel pnlSubMenuGeneral;
        private Guna.UI2.WinForms.Guna2Button btnPayments;
        private Guna.UI2.WinForms.Guna2Button btnAdmissions;
        private Guna.UI2.WinForms.Guna2Button btnAppointments;
        private Guna.UI2.WinForms.Guna2Panel pnlSubMenuMedicalRecords;
        private Guna.UI2.WinForms.Guna2Button btnLabResults;
        private Guna.UI2.WinForms.Guna2Button btnPrescriptions;
        private Guna.UI2.WinForms.Guna2Button btnMedicalHistory;
        private Guna.UI2.WinForms.Guna2Button btnMedicalRecords;
        private Guna.UI2.WinForms.Guna2Button btnPharmacy;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnRooms;
        private Guna.UI2.WinForms.Guna2Panel pnlSubMenuPharmacy;
        private Guna.UI2.WinForms.Guna2Button btnRequests;
        private Guna.UI2.WinForms.Guna2Button btnInventory;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

