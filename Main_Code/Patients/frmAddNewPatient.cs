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
using Hospital_Management_System.Properties;
using clsBussinessLayer;
using System.Xml.Linq;

namespace Hospital_Management_System.Patients
{
    public partial class frmAddNewPatient : Form
    {
        public delegate void BackAddedPatientID(int PatientID);
        public event BackAddedPatientID BackPatientID;
        public frmAddNewPatient(string NationalNo)
        {
            InitializeComponent();
            if(NationalNo != null)
            {
                _Patient = clsPatients.FindByNationalNO(NationalNo);
                enMode = _Mode.enUpdate;
                _Person = _Patient.PersonInfo;

            }
        }

        private clsPeople _Person = new clsPeople();
        private clsPatients _Patient = new clsPatients();
        private clsEmergencyContact _EmergencyContact = null;
        private enum _Mode { enAdd = 1, enUpdate = 2}
        private _Mode enMode = _Mode.enAdd;

        private void pbxEditImage_Click(object sender, EventArgs e)
        {
            clsGlobal.HandelChooseImageFromFileExplorer(ref openFileDialog1, ref pbxPatientImage);
        }

        private void llblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbxPatientImage.Image = Resources.Patient_512;
        }

        private bool SavePersonInfo(ref clsPeople Person)
        {
            string[] name = txtName.Text.Split(' ');

            if (name.Length == 3)
            {
                Person.FirstName = name[0];
                Person.SecondName = name[1];
                Person.LastName = name[2];
            }
            else if (name.Length == 2)
            {
                Person.FirstName = name[0];
                Person.SecondName = null;
                Person.LastName = name[1];
            }
            else
            {
                Person.FirstName = name[0];
                Person.SecondName = name[1];
                Person.LastName = name[name.Length - 1];
            }

            Person.Address = txtAddress.Text;
            Person.NationalNumber = txtNationalNo.Text;
            Person.DateOfBirth = dtpDOB.Value;
            if (cbxGendor.Text == "Male")
                Person.Gendor = clsPeople.enGendor.Male;
            else
                Person.Gendor = clsPeople.enGendor.Female;

            Person.PhoneNumber = txtPhoneNumber.Text;
            if(pbxPatientImage.Image != Resources.Patient_512)
                Person.ImagePath = pbxPatientImage.ImageLocation;
            else
                Person.ImagePath = null;


            return Person.Save();

        }

        private bool SavePatientInfo(ref clsPatients Patient)
        {
            Patient.PersonID = _Person.PersonID;
            Patient.PatientStatus = true;
            Patient.LastVisitDate = DateTime.Now;
            Patient.Allergies = txtAllergies.Text;
            Patient.BloodType = (clsPatients.enBloodType)cbxBloodType.SelectedIndex + 1;
            Patient.Notes = txtNotes.Text;
            if (_EmergencyContact != null)
                Patient.EmergencyContactID = _EmergencyContact.EmergemcyContactID;

            return Patient.Save();
        }

        private bool _CheckIfSavePatientIsAvalible()
        {
            List<string> errorFields = new List<string>();

            CheckField(txtName, "Patient Name", errorFields);
            CheckField(txtNationalNo, "National Number", errorFields);
            CheckField(txtAllergies, "Allergies", errorFields);
            CheckField(txtPhoneNumber, "Phone Number", errorFields);


            if (errorFields.Count > 0)
            {
                string errorMessage = "Can't Save Becouse This Error:\n- " + string.Join("\n- ", errorFields);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool _ResetpnlAddNewContact()
        {
            txtContactName.Text = String.Empty;
            txtFirstPhoneNo.Text = String.Empty;
            txtSecPhoneNo.Text= String.Empty;
            cbxRWP.SelectedIndex = 7;

            return true;
        }

        private bool _CheckIfSaveContactIsAvalible()
        {
            List<string> errorFields = new List<string>();

            CheckField(txtContactName, "Contact Name", errorFields);
            CheckField(txtFirstPhoneNo, "Contact First Phone Number", errorFields);


            if (errorFields.Count > 0)
            {
                string errorMessage = "Can't Save Becouse This Error:\n- " + string.Join("\n- ", errorFields);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {


            if (!_CheckIfSavePatientIsAvalible())
                return;


            if (SavePersonInfo(ref _Person))
            {
                if(SavePatientInfo(ref _Patient) )
                {
                    MessageBox.Show("The Patient Is Added Successfully","Saved Successfully",MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                    BackPatientID?.Invoke(_Patient.PatientID);
                    
                    gbxPersonalInfo.Enabled = false;
                    gbxHealthInfo.Enabled = false;
                }
                else
                {
                    MessageBox.Show("The Patient Adding Failed", "Error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("The Person Adding Failed", "Error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
        }

        private void _LoadData()
        {
            txtName.Text = _Patient.PersonInfo.FullName;
            txtNationalNo.Text = _Patient.PersonInfo.NationalNumber;
            dtpDOB.Text = _Patient.PersonInfo.DateOfBirth.ToShortDateString();
            cbxGendor.SelectedIndex = (int)_Patient.PersonInfo.Gendor - 1;
            txtPhoneNumber.Text = _Patient.PersonInfo.PhoneNumber;
            txtAddress.Text = _Patient.PersonInfo.Address;

            if (_Patient.PersonInfo.ImagePath != null)
                pbxPatientImage.ImageLocation = _Patient.PersonInfo.ImagePath;
            
            if(_Patient.EmergencyContactID != -1)
            {
                txtContactName.Text = _Patient.EmergemcyContactInfo.ContactName;
                txtFirstPhoneNo.Text = _Patient.EmergemcyContactInfo.ContactFirstPhoneNO;
                txtSecPhoneNo.Text = _Patient.EmergemcyContactInfo.ContactSecondPhoneNO;
                cbxRWP.Text = _Patient.EmergemcyContactInfo.RelationshipWithEmergencyContact;

            }

            cbxBloodType.SelectedIndex = (int)_Patient.BloodType - 1;
            txtAllergies.Text = _Patient.Allergies;
            txtNotes.Text = _Patient.Notes;
        }

        private void CheckIfTextBoxISEmpty(object sender, CancelEventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox textBox = (Guna.UI2.WinForms.Guna2TextBox)sender;


            if (textBox.Text.Length == 0)
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "This Field Is Required!");
            }
            else if (textBox.Tag.ToString() == "name")
            {
                if (textBox.Text.Split(' ').Length < 2)
                {
                    e.Cancel = false;
                    errorProvider1.SetError(textBox, "Please Enter At least First & Last Name");
                }
                
                else
                {
                    errorProvider1.SetError(textBox, "");

                }
            }
            else if(textBox.Tag.ToString() == "NationalNO")
            {
                if (clsPeople.IsPersonExist(txtNationalNo.Text))
                {
                    e.Cancel = false;
                    errorProvider1.SetError(textBox, "This NationalNO. Is Already Used");
                }
                else
                {
                    errorProvider1.SetError(textBox, "");

                }
            }
            else
            {
                errorProvider1.SetError(textBox, "");

            }

        }



        private void frmAddNewPatient_Load(object sender, EventArgs e)
        {
            pnlAddEmergencyContact.Visible = false;
            if (enMode == _Mode.enUpdate)
            {
                _LoadData();
                txtNationalNo.Enabled = false;
            }
            txtName.Focus();
        }
        private void CheckField(Control control, string fieldName, List<string> errorFields)
        {
            if (!string.IsNullOrEmpty(errorProvider1.GetError(control)))
            {
                errorFields.Add(fieldName);
            }
        }

       
           
          

    private void llblEmergency_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlAddEmergencyContact.Visible = true;
        }

        private void btnSaveContact_Click(object sender, EventArgs e)
        {
            if (!_CheckIfSaveContactIsAvalible())
                return;

            clsEmergencyContact EmergencyContact = new clsEmergencyContact();

            EmergencyContact.ContactName = txtContactName.Text;
            EmergencyContact.ContactFirstPhoneNO = txtFirstPhoneNo.Text;
            EmergencyContact.ContactSecondPhoneNO = txtSecPhoneNo.Text;
            EmergencyContact.RelationshipWithEmergencyContact = cbxRWP.Text;

            if (EmergencyContact.AddNewEmergemcyContact())
            {
                MessageBox.Show("The Contact Is Added Successfully", "Saved Successfully", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                _EmergencyContact = EmergencyContact;

                _ResetpnlAddNewContact();
            }
            else
                MessageBox.Show("The Contact Adding Failed", "Error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlAddEmergencyContact.Visible = false;
        }

        private void txtFirstPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            
        }
    }
}
