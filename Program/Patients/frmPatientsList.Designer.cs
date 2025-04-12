using Hospital_Management_System.Global.Controls;

namespace Hospital_Management_System.Patients
{
    partial class frmPatientsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientsList));
            this.siticonePictureBox1 = new SiticoneNetFrameworkUI.SiticonePictureBox();
            this.siticoneLabel1 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.pnlFormImage = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrlListWithFilter1 = new Hospital_Management_System.Global.Controls.ctrlListWithFilter(ctrlListWithFilter.enListTypes.enPatients);
            this.pnlFormImage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.BorderColor = System.Drawing.Color.Black;
            this.siticonePictureBox1.BorderWidth = 0;
            this.siticonePictureBox1.Brightness = 1F;
            this.siticonePictureBox1.Contrast = 1F;
            this.siticonePictureBox1.CornerRadius = 0;
            this.siticonePictureBox1.DraggingSpeed = 3.15F;
            this.siticonePictureBox1.EnableAsyncLoading = false;
            this.siticonePictureBox1.EnableCaching = false;
            this.siticonePictureBox1.EnableDragDrop = false;
            this.siticonePictureBox1.EnableExtendedImageSources = false;
            this.siticonePictureBox1.EnableFilters = false;
            this.siticonePictureBox1.EnableFlipping = false;
            this.siticonePictureBox1.EnableGlow = false;
            this.siticonePictureBox1.EnableHighDpiSupport = false;
            this.siticonePictureBox1.EnableMouseInteraction = false;
            this.siticonePictureBox1.EnablePlaceholder = false;
            this.siticonePictureBox1.EnableRotation = false;
            this.siticonePictureBox1.EnableShadow = false;
            this.siticonePictureBox1.EnableSlideshow = false;
            this.siticonePictureBox1.FlipHorizontal = false;
            this.siticonePictureBox1.FlipVertical = false;
            this.siticonePictureBox1.Grayscale = false;
            this.siticonePictureBox1.Image = global::Hospital_Management_System.Properties.Resources.Patient_512;
            this.siticonePictureBox1.ImageOpacity = 1F;
            this.siticonePictureBox1.Images = ((System.Collections.Generic.List<System.Drawing.Image>)(resources.GetObject("siticonePictureBox1.Images")));
            this.siticonePictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.siticonePictureBox1.IsCircular = false;
            this.siticonePictureBox1.Location = new System.Drawing.Point(515, 12);
            this.siticonePictureBox1.MaintainAspectRatio = true;
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.PlaceholderImage = null;
            this.siticonePictureBox1.RotationAngle = 0F;
            this.siticonePictureBox1.Saturation = 1F;
            this.siticonePictureBox1.ShowBorder = true;
            this.siticonePictureBox1.Size = new System.Drawing.Size(177, 115);
            this.siticonePictureBox1.SizeMode = SiticoneNetFrameworkUI.Helpers.Enum.SiticonePictureBoxSizeMode.StretchImage;
            this.siticonePictureBox1.TabIndex = 1;
            this.siticonePictureBox1.Text = "siticonePictureBox1";
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold);
            this.siticoneLabel1.Location = new System.Drawing.Point(491, 8);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(232, 38);
            this.siticoneLabel1.TabIndex = 2;
            this.siticoneLabel1.Text = "Patients List";
            this.siticoneLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFormImage
            // 
            this.pnlFormImage.Controls.Add(this.siticonePictureBox1);
            this.pnlFormImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormImage.Location = new System.Drawing.Point(0, 0);
            this.pnlFormImage.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pnlFormImage.Name = "pnlFormImage";
            this.pnlFormImage.Size = new System.Drawing.Size(1181, 140);
            this.pnlFormImage.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.siticoneLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 56);
            this.panel1.TabIndex = 4;
            // 
            // ctrlListWithFilter1
            // 
            this.ctrlListWithFilter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlListWithFilter1.Location = new System.Drawing.Point(0, 246);
            this.ctrlListWithFilter1.Name = "ctrlListWithFilter1";
            this.ctrlListWithFilter1.Size = new System.Drawing.Size(1181, 500);
            this.ctrlListWithFilter1.TabIndex = 0;
            this.ctrlListWithFilter1.Load += new System.EventHandler(this.ctrlListWithFilter1_Load);
            // 
            // frmPatientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1181, 746);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctrlListWithFilter1);
            this.Controls.Add(this.pnlFormImage);
            this.Name = "frmPatientsList";
            this.Text = "frmPatientsList";
            this.Load += new System.EventHandler(this.frmPatientsList_Load);
            this.pnlFormImage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Global.Controls.ctrlListWithFilter ctrlListWithFilter1;
        private SiticoneNetFrameworkUI.SiticonePictureBox siticonePictureBox1;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel1;
        private System.Windows.Forms.Panel pnlFormImage;
        private System.Windows.Forms.Panel panel1;
    }
}