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


namespace Hospital_Management_System.Login
{
    public partial class frmLoginScreen : Form
    {

        private clsUsers _user = new clsUsers();
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void _ShowThisForm()
        {
            this.ShowDialog();
        }

        private void llblForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //MessageBox.Show("This Feture Will Added Soon","Stay Tuend",MessageBoxButtons.OK,MessageBoxIcon.Information);
            frmForgetPassword frm = new frmForgetPassword(this);
            this.Hide();
            //frm.Back += _ShowThisForm;
            frm.ShowDialog();
            this.Show();
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            pxbHideShowPass.ImageLocation = "C:\\Users\\Hassan\\Pictures\\Icnos\\OpenEye_Password.png";
            pbxLoginLogo.ImageLocation = "C:\\Users\\Hassan\\Pictures\\Projects Images\\Hospital\\Logo.png";
            string Username = "", Password = "";
            if (clsGlobal.GetStoredCredential(ref Username, ref Password))
            {
                txtUsername.Text = Username;
                txtPassword.Text = Password;
                cbxRemeberMe.Checked = true;
            }
            else
                cbxRemeberMe.Checked = false;
            txtUsername.Focus();
        }
        private int Trials = 0;

        private void _SaveLoginLog()
        {
            if (!clsLogs.AddNewLogRecord("Login", _user.UserID, DateTime.Now, ""))
                MessageBox.Show("Can't Save Record Log, Please Try Again Later", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            _user = clsUsers.FindByUsernameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (_user != null)
            {

                if (cbxRemeberMe.Checked)
                {
                    //store username and password
                    clsGlobal.RememberUsernameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());

                }
                else
                {
                    //store empty username and password
                    clsGlobal.RememberUsernameAndPassword("", "");

                }

                //incase the user is not active
                if (!_user.IsActive)
                {

                    txtUsername.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsGlobal.CurrentUser = _user;
                
                //Save Login Log To Database.
                _SaveLoginLog();

                this.Hide();
                frmMainForSecretary frm = new frmMainForSecretary(this);
                frm.ShowDialog();
                this.Show();

                
            }
            else
            {
                //Incress Failed Tries To Login
                Trials++;

                if(Trials < 3)
                {
                    MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    if(Trials > 4)
                    {
                        MessageBox.Show("Your Tries To Login Is End, Please Call Your Admin!", "Blocked!", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        
                        this.Close();

                        return;
                    }

                    if(MessageBox.Show("Invalid Username/Password.,Are You Forget Password?", "Wrong Credintials",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        Form frm = new frmForgetPassword(this,txtUsername.Text);
                        this.Hide();
                        frm.ShowDialog();
                        Trials = 0;
                    }

                }

                txtUsername.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pxbHideShowPass_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '*')
            {
                clsGlobal.ShowPasswordAndChangeIcon(ref txtPassword, ref pxbHideShowPass);
                    
            }
            else
            {
                clsGlobal.HidePasswordAndChangeIcon(ref txtPassword, ref pxbHideShowPass);
            }
        }

       

        private void rbtnRemeberMe_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSignIn_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
