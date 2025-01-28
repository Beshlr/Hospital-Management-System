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
            pnlSubMenuMedicalRecords.Visible = false;
            pnlSubMenuPharmacy.Visible = false;
        }

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

        private void btnMedicalRecords_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuMedicalRecords);

        }

        private void btnPharmacy_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuPharmacy);

        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmAppointments());

            hideSubMenu();
        }
    }
}
