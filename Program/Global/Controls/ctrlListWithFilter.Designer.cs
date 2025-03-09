namespace Hospital_Management_System.Global.Controls
{
    partial class ctrlListWithFilter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.txtSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbxSearchFilter = new System.Windows.Forms.PictureBox();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.pnlFilterBy = new System.Windows.Forms.Panel();
            this.gbxFilterBy = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbtnDepartment = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnStatus = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnDoctorName = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnPatientName = new Guna.UI2.WinForms.Guna2RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.pnlSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearchFilter)).BeginInit();
            this.pnlAdd.SuspendLayout();
            this.pnlFilterBy.SuspendLayout();
            this.gbxFilterBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvList.ColumnHeadersHeight = 25;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvList.Location = new System.Drawing.Point(0, 158);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvList.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvList.RowTemplate.Height = 40;
            this.dgvList.Size = new System.Drawing.Size(1102, 368);
            this.dgvList.TabIndex = 18;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvList.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvList.ThemeStyle.ReadOnly = true;
            this.dgvList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvList.ThemeStyle.RowsStyle.Height = 40;
            this.dgvList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(180)))));
            this.dgvList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.White;
            this.pnlControls.Controls.Add(this.pnlSearchBar);
            this.pnlControls.Controls.Add(this.pnlAdd);
            this.pnlControls.Controls.Add(this.pnlFilterBy);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1102, 158);
            this.pnlControls.TabIndex = 19;
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
            this.txtSearchBar.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchBar.PlaceholderText = "Enter Patient\'s Text";
            this.txtSearchBar.SelectedText = "";
            this.txtSearchBar.Size = new System.Drawing.Size(263, 32);
            this.txtSearchBar.TabIndex = 6;
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
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.btnAdd);
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAdd.Location = new System.Drawing.Point(948, 0);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(154, 158);
            this.pnlAdd.TabIndex = 16;
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
            // 
            // pnlFilterBy
            // 
            this.pnlFilterBy.Controls.Add(this.gbxFilterBy);
            this.pnlFilterBy.Location = new System.Drawing.Point(327, 38);
            this.pnlFilterBy.Name = "pnlFilterBy";
            this.pnlFilterBy.Size = new System.Drawing.Size(265, 115);
            this.pnlFilterBy.TabIndex = 12;
            // 
            // gbxFilterBy
            // 
            this.gbxFilterBy.Controls.Add(this.rbtnDepartment);
            this.gbxFilterBy.Controls.Add(this.rbtnStatus);
            this.gbxFilterBy.Controls.Add(this.rbtnDoctorName);
            this.gbxFilterBy.Controls.Add(this.rbtnPatientName);
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
            // rbtnDepartment
            // 
            this.rbtnDepartment.AutoSize = true;
            this.rbtnDepartment.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnDepartment.CheckedState.BorderThickness = 0;
            this.rbtnDepartment.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnDepartment.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnDepartment.CheckedState.InnerOffset = -4;
            this.rbtnDepartment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnDepartment.Location = new System.Drawing.Point(156, 67);
            this.rbtnDepartment.Name = "rbtnDepartment";
            this.rbtnDepartment.Size = new System.Drawing.Size(88, 19);
            this.rbtnDepartment.TabIndex = 3;
            this.rbtnDepartment.Tag = "Department";
            this.rbtnDepartment.Text = "Department";
            this.rbtnDepartment.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnDepartment.UncheckedState.BorderThickness = 2;
            this.rbtnDepartment.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnDepartment.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
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
            // 
            // rbtnDoctorName
            // 
            this.rbtnDoctorName.AutoSize = true;
            this.rbtnDoctorName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnDoctorName.CheckedState.BorderThickness = 0;
            this.rbtnDoctorName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnDoctorName.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnDoctorName.CheckedState.InnerOffset = -4;
            this.rbtnDoctorName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnDoctorName.Location = new System.Drawing.Point(156, 33);
            this.rbtnDoctorName.Name = "rbtnDoctorName";
            this.rbtnDoctorName.Size = new System.Drawing.Size(96, 19);
            this.rbtnDoctorName.TabIndex = 1;
            this.rbtnDoctorName.Text = "Doctor Name";
            this.rbtnDoctorName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnDoctorName.UncheckedState.BorderThickness = 2;
            this.rbtnDoctorName.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnDoctorName.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtnPatientName
            // 
            this.rbtnPatientName.AutoSize = true;
            this.rbtnPatientName.Checked = true;
            this.rbtnPatientName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnPatientName.CheckedState.BorderThickness = 0;
            this.rbtnPatientName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnPatientName.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnPatientName.CheckedState.InnerOffset = -4;
            this.rbtnPatientName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtnPatientName.Location = new System.Drawing.Point(10, 33);
            this.rbtnPatientName.Name = "rbtnPatientName";
            this.rbtnPatientName.Size = new System.Drawing.Size(97, 19);
            this.rbtnPatientName.TabIndex = 0;
            this.rbtnPatientName.TabStop = true;
            this.rbtnPatientName.Text = "Patient Name";
            this.rbtnPatientName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnPatientName.UncheckedState.BorderThickness = 2;
            this.rbtnPatientName.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnPatientName.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // ctrlListWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlControls);
            this.Name = "ctrlListWithFilter";
            this.Size = new System.Drawing.Size(1102, 526);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlSearchBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearchFilter)).EndInit();
            this.pnlAdd.ResumeLayout(false);
            this.pnlFilterBy.ResumeLayout(false);
            this.gbxFilterBy.ResumeLayout(false);
            this.gbxFilterBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvList;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.ComboBox cbxStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBar;
        private System.Windows.Forms.PictureBox pbxSearchFilter;
        private System.Windows.Forms.Panel pnlAdd;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Panel pnlFilterBy;
        private Guna.UI2.WinForms.Guna2GroupBox gbxFilterBy;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnDepartment;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnStatus;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnDoctorName;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnPatientName;
    }
}
