using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Management_System.Classes;
using clsBussinessLayer;

namespace Hospital_Management_System.Login
{
    public partial class frmForgetPassword : Form
    {
        public frmForgetPassword(frmLoginScreen PriviousForm,string Username = "")
        {
            InitializeComponent();
            _LastForm = PriviousForm;
            if(Username != "")
            {
                txtUsername.Text = Username;

            }
        }

        public delegate void CloseFormAndShowLastOne();

        public event CloseFormAndShowLastOne Back;

        private string _UserEmail = "";
        private string _CorrectCode = "";
        private clsUsers _CurrentUser = null;
        private frmLoginScreen _LastForm;
        private static int Tick = 30;

        private bool CheckIfCodeIsCorrect(string EnterdCode,string CorrectCode)
        {
            if(EnterdCode != null && EnterdCode == CorrectCode)
            {
                return true;
            }

            return false;
        }

        private async void HandelSendTheCode()
        {
            _CorrectCode = await Global.clsEmailSender.SendCodeToAnEmail(_UserEmail, _CurrentUser.UserName);

        }

        private void SendCode()
        {
            _CurrentUser = clsUsers.Find(txtUsername.Text);

            //Check If Username Is Exist
            if (_CurrentUser == null)
            {
                MessageBox.Show("Username You Enterd Is Not Correct, Please Enter Correct One", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            _UserEmail = _CurrentUser.UserEmail;

            if(_UserEmail == null)
            {
                MessageBox.Show("This User Doesn't Have An Email, Please Call Your Admin To Change Password","Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HandelSendTheCode();

            // Show Code In Screen Until Search For Another Way To Send Code To Email
            //MessageBox.Show($"Your Code IS: {_CorrectCode},Please Save It", "Code", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ReFormat User's Email For More Privacy
            string UserEmailAfterFormatting = clsGlobal.ReFormatEmail(_UserEmail);


            if (MessageBox.Show($"The Code Sent Successfully To Email: {UserEmailAfterFormatting}", "Code Sent", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {

            }

            //Change Screen Controls To Accept Enter Code
            lblUsername.Text = "Code";
            txtUsername.PlaceholderText = "Enter Code";
            txtUsername.Text = "";
            btnSentCode.Text = "Confirm Code";

            timer1.Start();

            

            llblResendCode.Visible = true;
            llblResendCode.Enabled = false;
            lblTimer.Visible = true;
        }

        private void EnterCode()
        {
           

            if (CheckIfCodeIsCorrect(txtUsername.Text, _CorrectCode))
            {
                MessageBox.Show("Code You Enter Is Matched Code Sent, Now You Can Change Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Change Screen Controls To Accept New Password

                llblResendCode.Visible = false;
                lblTimer.Visible = false;

                lblUsername.Text = "New Password";
                txtUsername.PlaceholderText = "Enter New Password";

                lblPassword.Visible = true;
                txtPassword.Visible = true;

                lblPassword.Text = "Confirm Password";
                txtPassword.PlaceholderText = "Enter Same Password";

                btnSentCode.Text = "Change Password";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.PasswordChar = '*';
                txtPassword.PasswordChar = '*';

                pxbHideShowPass1.Visible = true;
                pxbHideShowPass2.Visible = true;

                pxbHideShowPass1.ImageLocation = "C:\\Users\\Hassan\\Pictures\\Icnos\\OpenEye_Password.png";
                pxbHideShowPass2.ImageLocation = "C:\\Users\\Hassan\\Pictures\\Icnos\\OpenEye_Password.png";
            }
            else
            {
                MessageBox.Show("Code You Entered Doesn't Matched Code Sent, Please Try Again","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool CheckIfNewPasswordIsTheCurrentOne(string NewPassword,string OldPassword)
        {
            if (clsGlobal.CheckIfTwoTextsAreMatched(NewPassword, OldPassword))
            {
                if (MessageBox.Show("You Have Enterd The Current Password !,\n Do You Want To Enter Another One ?"
                                        , "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    txtUsername.Text = "";
                    txtPassword.Text = "";

                }
                else
                {
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                    btnSentCode.Enabled = false;

                    this.Close();
                    _LastForm.Show();
                }
                return true;
            }

            return false;
        }

        private void ChangePassword()
        {
           

            if (clsGlobal.CheckIfTwoTextsAreMatched(txtUsername.Text, txtPassword.Text))
            {
                if (CheckIfNewPasswordIsTheCurrentOne(txtUsername.Text, _CurrentUser.Password))
                    return;
                
                
                _CurrentUser.Password = txtUsername.Text;
                if (_CurrentUser.Save())
                {
                    MessageBox.Show("Password Is Changed Successfully", "Completed Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                    btnSentCode.Enabled = false;
                    
                    _LastForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password Changing Not Completed Successfully, Please Try Again", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Confirmed Password Doesn't Matched Password You Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
            }
        }

        private void btnSentCode_Click(object sender, EventArgs e)
        {
            if(txtUsername.PlaceholderText == "Enter Username")
            {
                lblUsername.Focus();
                SendCode();

            }
            else if(txtUsername.PlaceholderText == "Enter Code")
            {
                lblUsername.Focus();
                EnterCode();
            }
            else
            {
                lblUsername.Focus();
                ChangePassword();
            }

        }

        private void frmForgetPassword_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            lblPassword.Visible = false;
            txtPassword.Visible = false;

            pxbHideShowPass1.Visible = false;
            pxbHideShowPass2.Visible = false;

            llblResendCode.Visible = false;
            lblTimer.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Back?.Invoke();
        }

        private void pxbHideShowPass1_Click(object sender, EventArgs e)
        {
            if (txtUsername.PasswordChar == '*')
            {
                clsGlobal.ShowPasswordAndChangeIcon(ref txtUsername, ref pxbHideShowPass1);

            }
            else
            {
                clsGlobal.HidePasswordAndChangeIcon(ref txtUsername, ref pxbHideShowPass1);
            }
        }

        private void pxbHideShowPass2_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                clsGlobal.ShowPasswordAndChangeIcon(ref txtPassword, ref pxbHideShowPass2);

            }
            else
            {
                clsGlobal.HidePasswordAndChangeIcon(ref txtPassword, ref pxbHideShowPass2);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tick--;
            lblTimer.Text = Tick.ToString();
            if(Tick == 0)
            {
                llblResendCode.Enabled = true;
                lblTimer.Visible = false;
                timer1.Stop();
            }
        }

        private void llblResendCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HandelSendTheCode();
            llblResendCode.Enabled = false;
            Tick = 30;
            lblTimer.Text = "30";
            lblTimer.Visible = true;
            timer1.Start();

        }
    }
}
