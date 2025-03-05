namespace Hospital_Management_System.Global.Controls
{
    partial class ctrlAddNewPicture
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
            this.btnChangeImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pbxImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.llblRemoveImage = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeImage.Image = global::Hospital_Management_System.Properties.Resources._9055423_bxs_edit_icon__1_;
            this.btnChangeImage.ImageRotate = 0F;
            this.btnChangeImage.Location = new System.Drawing.Point(132, 128);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnChangeImage.Size = new System.Drawing.Size(35, 35);
            this.btnChangeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnChangeImage.TabIndex = 3;
            this.btnChangeImage.TabStop = false;
            this.btnChangeImage.Click += new System.EventHandler(this.guna2CirclePictureBox2_Click);
            // 
            // pbxImage
            // 
            this.pbxImage.Image = global::Hospital_Management_System.Properties.Resources.Male_512;
            this.pbxImage.ImageRotate = 0F;
            this.pbxImage.Location = new System.Drawing.Point(0, 3);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbxImage.Size = new System.Drawing.Size(167, 160);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImage.TabIndex = 2;
            this.pbxImage.TabStop = false;
            // 
            // llblRemoveImage
            // 
            this.llblRemoveImage.AutoSize = true;
            this.llblRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.llblRemoveImage.Location = new System.Drawing.Point(55, 166);
            this.llblRemoveImage.Name = "llblRemoveImage";
            this.llblRemoveImage.Size = new System.Drawing.Size(60, 17);
            this.llblRemoveImage.TabIndex = 4;
            this.llblRemoveImage.TabStop = true;
            this.llblRemoveImage.Text = "Remove";
            this.llblRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRemoveImage_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ctrlAddNewPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.llblRemoveImage);
            this.Controls.Add(this.btnChangeImage);
            this.Controls.Add(this.pbxImage);
            this.Name = "ctrlAddNewPicture";
            this.Size = new System.Drawing.Size(185, 201);
            this.Load += new System.EventHandler(this.ctrlAddNewPicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox btnChangeImage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbxImage;
        private System.Windows.Forms.LinkLabel llblRemoveImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
