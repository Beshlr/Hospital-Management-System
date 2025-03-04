using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Management_System.Login;
using Hospital_Management_System.Classes;
using clsBussinessLayer;
using Hospital_Management_System.Properties;
using Hospital_Management_System.Appointments;

namespace Hospital_Management_System
{
    public partial class frmMainForSecretary : Form
    {
        frmLoginScreen _frmLogin;

        public frmMainForSecretary(frmLoginScreen LoginFrm)
        {
            InitializeComponent();
            _frmLogin = LoginFrm;
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            pnlSubMenuGeneral.Visible = false;
            pnlSubMenuStaf.Visible = false;
            pnlSubMenuPharmacy.Visible = false;
        }

        private clsNotifications[] _notificationsList = null;
        private void showSubMenu(Guna.UI2.WinForms.Guna2Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuGeneral);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _frmLogin.Show();
            this.Close();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuStaf);

        }

       

        private void btnPharmacy_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuPharmacy);

        }

        private Form activeForm = null;

        public static string HandelDateFormatForNow(DateTime date)
        {
            TimeSpan Diff = DateTime.Now - date;
            int DiffInMin = Convert.ToInt32(Math.Truncate(Diff.TotalMinutes));

            if (DiffInMin < 1)
                return "Just now";

            string dateTail;
            int DiffValue;

            if (DiffInMin >= 1440)
            {
                DiffValue = Convert.ToInt32(Diff.TotalDays);
                dateTail = (DiffValue == 1) ? " Day ago" : " Days ago";
            }
            else if (DiffInMin >= 60)
            {
                DiffValue = Convert.ToInt32(Diff.TotalHours);
                dateTail = (DiffValue == 1) ? " Hour ago" : " Hours ago";
            }
            else
            {
                DiffValue = DiffInMin;
                dateTail = (DiffValue == 1) ? " Minute ago" : " Minutes ago";
            }

            return DiffValue + dateTail;
        }

        private void _AddNewNotification(clsNotifications NotificationInfo, int ControlNum)
        {
            //Create New Button As Notification Bar
            Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button();

            //Set Button Propertes
            btn.BackColor = Color.FromArgb(68, 138, 255);
            btn.Name = $"btnNotify{ControlNum}";
            btn.Size = new Size(pnlNotificationList.Width, 42);
            btn.Dock = DockStyle.Top;
            btn.Text = NotificationInfo.Title;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            btn.Tag = NotificationInfo.ID;

            //Add Notification Button to Panel
            pnlNotificationList.Controls.Add(btn);

            //Create Label To Notification Date
            Label lbl = new Label();

            //Set Label's Properties
            lbl.Name = $"lblNotify{NotificationInfo.Date}Date";
            lbl.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            lbl.ForeColor = GetLabelColor(btn.BackColor);
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.Text = HandelDateFormatForNow(NotificationInfo.Date);
            lbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            lbl.Location = new Point(btn.Width - lbl.Width + 27, btn.Height - lbl.Height + 10);


            //Add Label To Button
            btn.Controls.Add(lbl);

            // Attach the Click event to the method that handles the button click
            btn.Click += new EventHandler(NotifiyBtn_Click);
        }

        private Color GetLabelColor(Color buttonColor)
        {
            if (buttonColor == Color.FromArgb(68, 138, 255))
                return Color.White; 
            else
                return Color.Black;
        }

        private void NotifiyBtn_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = ((Guna.UI2.WinForms.Guna2Button)sender);

            int NotifyID = Convert.ToInt32(btn.Tag);

            clsNotifications Notification = clsNotifications.Find(NotifyID);

            if(!Notification.OpenningStatus)
            {
                clsNotifications.UpdateNotificationOpenningStatus(NotifyID, true);
                btn.BackColor = Color.FromArgb(117, 184, 255);
            }

        }

        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Dispose();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Clear();
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            if (activeForm is frmAppointmentsList)
                return;

            openChildFormInPanel(new frmAppointmentsList());
            hideSubMenu();
        }

        private void _RefreashNotificationList()
        {
            _notificationsList = clsNotifications.GetAllNotificationsForUser(clsGlobal.CurrentUser.UserID);
            
            int NumOfNotifications = _notificationsList.Count();
            
            lblNoNotification.Visible = NumOfNotifications == 0;
            if (NumOfNotifications == 0)
                return;
            for (int i = 0; i < NumOfNotifications; i++)
            {
                _AddNewNotification(_notificationsList[i], i + 1);
            }
        }

        private void frmMainForSecretary_Load(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.ImagePath != null && clsGlobal.CurrentUser.ImagePath.Length > 0)
                pbxUserImage.ImageLocation = clsGlobal.CurrentUser.ImagePath;
            lblUsername.Text = clsGlobal.CurrentUser.UserName;
            _RefreashNotificationList();
        }

        private bool _KeepPanelVisable = false;

        private void _ResetSizeOfNotificationPanel()
        {

            int width = 211;
            int height = 20;
            foreach(Control control in pnlNotificationList.Controls)
            {
                height += control.Height;
            }

            pnlNotificationList.MaximumSize = new Size(width,height);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (pnlNotificationList.Visible)
                pnlNotificationList.Visible = false;
            else
            {
                if(activeForm != null)
                {
                    pnlNotificationList.Visible = true;
                    Parent = pnlNotificationList;
                }
                else
                    pnlNotificationList.Visible = true;
                _ResetSizeOfNotificationPanel();
            }
        }
    }
}
