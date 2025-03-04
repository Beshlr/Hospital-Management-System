using Hospital_Management_System.Properties;
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

namespace Hospital_Management_System.People.Controls
{
    public partial class ctrlAddNewPerson : UserControl
    {
        public ctrlAddNewPerson()
        {
            InitializeComponent();
            

        }

        public delegate void BackAddedPersonID(int PersonID);
        public BackAddedPersonID addedPersonID;

        private clsPeople _Person = null;
        private enum _enMode { enAddNewPerson = 1, enUpdatePerson = 2};
        private _enMode _Mode = _enMode.enAddNewPerson;

        private void CheckEmptyTextBoxs(object sender, CancelEventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox Temp = (Guna.UI2.WinForms.Guna2TextBox)sender;

            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This Field is Required");
            }
            else
            {
                errorProvider1.SetError(Temp, null);

            }
        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            HandelChangeingDefualtPicture();
        }

        private void HandelChangeingDefualtPicture()
        {
            if (rbtnFemale.Checked && pbxPersonImage.ImageLocation == null)
                pbxPersonImage.Image = Resources.Female_512;

            else if (!rbtnFemale.Checked && pbxPersonImage.ImageLocation == null)
                pbxPersonImage.Image = Resources.Male_512;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            if (clsGlobal.HandelChooseImageFromFileExplorer(ref openFileDialog1, ref pbxPersonImage))
                return;
            else
            {
                HandelChangeingDefualtPicture();
                return;
            }
        }

        public void AddNewPerson(clsPeople Person)
        {
            Person.FirstName = txtFirstName.Text;
            Person.SecondName = txtSecondName.Text;
            Person.LastName = txtLastName.Text;
            Person.Gendor = rbtnFemale.Checked ? clsPeople.enGendor.Female : clsPeople.enGendor.Male;
            Person.Address = txtAddress.Text;
            Person.ImagePath = pbxPersonImage.ImageLocation;
            Person.PhoneNumber = txtPhoneNO.Text;
            Person.DateOfBirth = dtbDateOfBirth.Value;

            Person.Save();
        }

        public delegate bool DelResetControls(Control ctrl);

        private DelResetControls Del;
        public bool ResetControls(Control ctrl)
        {
            ctrl.ResetText();
            return true;
        }

        private void txtNationNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtPhoneNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddNewPerson(_Person);
            addedPersonID?.Invoke(_Person.PersonID);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                Del += ResetControls;
            }
        }
    }
}
