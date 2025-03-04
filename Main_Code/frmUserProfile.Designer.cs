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
            this.ctrlAddNewPicture1 = new Hospital_Management_System.Global.Controls.ctrlAddNewPicture();
            this.SuspendLayout();
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 558);
            this.Controls.Add(this.ctrlAddNewPicture1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Info.";
            this.Load += new System.EventHandler(this.frmUserProfile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Global.Controls.ctrlAddNewPicture ctrlAddNewPicture1;
    }
}