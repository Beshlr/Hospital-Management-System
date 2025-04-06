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
        public class FormCloseEventArgs : EventArgs
        {
            public Image UserImage { get; }

            public FormCloseEventArgs(Image userImage)
            { this.UserImage = userImage; }
        }

        public EventHandler<FormCloseEventArgs> ImageChanged;

        public frmUserProfile(int UserID)
        {
            InitializeComponent();

            if (UserID != -1)
            {
                _User = clsUsers.Find(UserID);
                _UserMode = enUserMode.enUpdate;
            }

        }

        public frmUserProfile(clsUsers User)
        {
            InitializeComponent();

            if (User != null)
            {
                _User = User;
                _UserMode = enUserMode.enUpdate;
            }
        }


        private enum enUserMode { enAddNew, enUpdate};
        private enUserMode _UserMode = enUserMode.enAddNew;
        private enum enScreenMode { enShow, enEdit};
        private enScreenMode _ScreenMode = enScreenMode.enShow;
        private Image _Img = null;
        private clsUsers _User = null;


        ///<summary>
        ///Changes Status of Controls (Enable - Disable)
        ///</summary>
        ///<param name="enable"> Are you want to enable controls ?</param>

        private void _ChangeAllTheControlsStatus(bool enable) =>  gbxActiveStatus.Enabled = pbxHideShowPass.Enabled = gbxRoles.Enabled = txtUsername.Enabled = txtPassword.Enabled = txtEmail.Enabled = enable;
        
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
                    if (_UserMode != enUserMode.enUpdate)
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
            //Load User Image
            ctrlAddNewPicture1.SetImage(_User.ImagePath);

            _RefreashImageCtrl();

            //Choose User Role 

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

        private void _RefreashImageCtrl()
        {
            ctrlAddNewPicture1.Refresh();
            ctrlAddNewPicture1.Invalidate();

        }

        //Change The Screen Controls Properties to Show Mode
        private void _SwitchScreenSettingsToShowInfo()
        {
            btnSaveEdit.Text = "Edit";
            btnClose.Text = "Close";
            pbxHideShowPass.BackColor = Color.FromArgb(226, 226, 226);
            ctrlAddNewPicture1.ChangeEditImageStatus(false);
                _ChangeAllTheControlsStatus(false);
        }

        //Change The Screen Controls Properties to Edit Mode
        private void _SwitchScreenSettingsToEditInfo()
        {
            btnSaveEdit.Text = "Save";
            btnClose.Text = "Cancel";
            pbxHideShowPass.BackColor = Color.Transparent;
            ctrlAddNewPicture1.ChangeEditImageStatus(true);
            _ChangeAllTheControlsStatus(true);
        }

        private void _SwitchScreenMode()
        {
            switch (_ScreenMode)
            {
                case enScreenMode.enEdit:
                    _SwitchScreenSettingsToEditInfo();
                    break;
                case enScreenMode.enShow:
                    _SwitchScreenSettingsToShowInfo();
                    break;
                default:
                    _SwitchScreenSettingsToShowInfo();
                    break;
            }
        }

        private void ctrlAddNewPicture1_Load(object sender, EventArgs e)
        {
           
            if (_User.ImagePath != null && _User.ImagePath.Length != 0)
            {
                ctrlAddNewPicture1.SetImage(_User.ImagePath);
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

        /// <summary>
        /// Get the role id from the checked radio button in groub box : 'Role'
        /// </summary>
        /// <returns></returns>

        private int GetRoleID()
        {
            if (rbtnAdmin.Checked)
                return 1;
            else if (rbtnSecretary.Checked)
                return 2;
            else if (rbtnPatient.Checked)
                return 3;
            else if (rbtnDoctor.Checked)
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
            _User.IsActive = rbtnActiveYES.Checked;
            _User.RoleID = GetRoleID();
            _User.ImagePath = ctrlAddNewPicture1.GetImagePath();

            return _User.Save();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (btnSaveEdit.Text == "Save")
            {
                _ScreenMode = enScreenMode.enShow;
                if (SaveUserInfo())
                {
                    if(_UserMode== enUserMode.enUpdate)
                    {
                        MessageBox.Show("User Updated Successfully","Saved",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("User Added Successfully","Saved",MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Save Opertaion Failed","Failed To Save",MessageBoxButtons.OK, MessageBoxIcon.Error);

                
            }
            else
            {
                _ScreenMode = enScreenMode.enEdit;

            }
            _SwitchScreenMode();

        }

        protected virtual void OnFormClosed(Image userImage)
        {
            ImageChanged?.Invoke(this, new FormCloseEventArgs(userImage));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_ScreenMode == enScreenMode.enShow)
            {
                _Img = ctrlAddNewPicture1.GetImage();
                if (_Img != null)
                    OnFormClosed(_Img);
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                _ScreenMode = enScreenMode.enShow;
                _SwitchScreenSettingsToShowInfo();
            }

        }

        
    }
}
