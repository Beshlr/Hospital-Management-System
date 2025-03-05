using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsBussinessLayer;
using Hospital_Management_System.Classes;


namespace Hospital_Management_System
{
    public partial class frmUserProfile : Form
    {
        public frmUserProfile(int UserID)
        {
            InitializeComponent();

            if (UserID != -1)
            {
                _User = clsUsers.Find(UserID);
                _Mode = enMode.enUpdate;
            }

        }

        public frmUserProfile(clsUsers User)
        {
            InitializeComponent();

            if (User != null)
            {
                _User = User;
                _Mode = enMode.enUpdate;
            }
        }


        private enum enMode { enAddNew, enUpdate};
        private enMode _Mode = enMode.enAddNew;
        private clsUsers _User = null;

        private void _ChangeAllTheControlsStatus(bool enable) => gbxRoles.Enabled = txtUsername.Enabled = txtPassword.Enabled = txtEmail.Enabled = enable;
        
        private void _HandelShowRolesLoginUserCouldSelect()
        {
            //Check if Login User Is Secretary OR Admin
            if (clsGlobal.CurrentUser.RoleName == "Secretary" || clsGlobal.CurrentUser.RoleName == "Admin")
            {
                gbxRoles.Visible = true;

                //If he was Secretary desable Admin & Secretary radio buttons other than this don't show the GroubBox
                if (clsGlobal.CurrentUser.RoleName == "Secretary")
                {
                    rbtnAdmin.Visible = false;
                    rbtnSecretary.Visible = false;
                }
            }
        }

        private void _LoadUserInfo()
        {
            txtUsername.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtEmail.Text = _User.UserEmail;
            rbtnActiveYES.Checked = _User.IsActive;
            rbtnActiveNO.Checked = !_User.IsActive;
            lblUserID.Text = _User.UserID.ToString();
            lblRoleName.Text = _User.RoleName;
            ctrlAddNewPicture1.SetImage(_User.ImagePath);


            if (_User.RoleName != "Patient")
                rbtnPatient.Checked = false;
            if (_User.RoleName == "Doctor")
                rbtnDoctor.Checked = true;
            else if(_User.RoleName == "Admin")
                rbtnAdmin.Checked = true;
            else if( _User.RoleName == "Secretary")
                rbtnSecretary.Checked = true;
            
            
        }
        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            if(_User != null )
            {
                _ChangeAllTheControlsStatus(false);
                _LoadUserInfo();
                ctrlAddNewPicture1.ChangeEditImageStatus(false);
                btnSaveEdit.Text = "Edit";
            }
        }

        private void ctrlAddNewPicture1_Load(object sender, EventArgs e)
        {
            if (_User.ImagePath != null && _User.ImagePath.Length != 0)
            {
                Image img = Image.FromFile(_User.ImagePath);
                ctrlAddNewPicture1 = new Global.Controls.ctrlAddNewPicture(img);
                ctrlAddNewPicture1.ChangeEditImageStatus(false);
                
            }
            _HandelShowRolesLoginUserCouldSelect();
        }
            
        

        private void pbxShowHidePass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '•')
            {
                clsGlobal.ShowPasswordAndChangeIcon(ref txtPassword, ref pbxHideShowPass);

            }
            else
            {
                clsGlobal.HidePasswordAndChangeIcon(ref txtPassword, ref pbxHideShowPass);
            }
        }

        private int GetRoleID()
        {
            if (rbtnDoctor.Checked)
                return 5;
            else if (rbtnAdmin.Checked)
                return 1;
            else if (rbtnSecretary.Checked)
                return 2;
            else if (rbtnPatient.Checked)
                return 4;

            else return -1;
        }

        private bool SaveUserInfo()
        {
            
            //Check IF object = null create new one
            if (_User == null)
                _User = new clsUsers();

            _User.UserEmail = txtEmail.Text;
            _User.UserName = txtUsername.Text;
            _User.Password = txtPassword.Text;
            _User.IsActive = rbtnActiveYES.Enabled;
            _User.RoleID = GetRoleID();
            _User.ImagePath = ctrlAddNewPicture1.GetImagePath();

            return _User.Save();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (btnSaveEdit.Text == "Save")
            {
                if(SaveUserInfo())
                {
                    if(_Mode== enMode.enUpdate)
                    {
                        MessageBox.Show("User Updated Successfully","Saved",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("User Added Successfully","Saved",MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Save Opertaion Failed","Failed To Save",MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSaveEdit.Text = "Edit";
                ctrlAddNewPicture1.ChangeEditImageStatus(false);
                _ChangeAllTheControlsStatus(false);
            }
            else
            {
                btnSaveEdit.Text = "Save";
                ctrlAddNewPicture1.ChangeEditImageStatus(true);
                _ChangeAllTheControlsStatus(true);
            }

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
