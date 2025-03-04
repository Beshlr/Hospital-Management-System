using clsBussinessLayer;
using Hospital_Management_System.Classes;
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

namespace Hospital_Management_System.Doctors
{
    public partial class frmAddNewDoctor : Form
    {
        public delegate void BackDoctorIDHandler( int DoctorID);

        public event BackDoctorIDHandler BackDoctorID;
        
        public frmAddNewDoctor(string NationalNo)
        {
            InitializeComponent();
            if (NationalNo != null)
            {
                _Doctor = clsDoctors.FindByNationalNO(NationalNo);
                _Person = _Doctor.PersonInfo;

                enMode = _Mode.enUpdate;
            }

        }

        private clsPeople _Person = new clsPeople();
        private clsDoctors _Doctor = new clsDoctors();
        private clsEmergencyContact _EmergencyContact = new clsEmergencyContact();
        private enum _Mode { enAdd = 1, enUpdate = 2 }
        private _Mode enMode = _Mode.enAdd;

        private void pbxEditImage_Click(object sender, EventArgs e)
        {
            clsGlobal.HandelChooseImageFromFileExplorer(ref openFileDialog1, ref pbxDoctorImage);
        }

        private void llblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbxDoctorImage.Image = Resources.Doctor_512;
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
            Person.ImagePath = pbxDoctorImage.ImageLocation;

            return Person.Save();

        }

        private bool SaveDoctorInfo(ref clsDoctors Doctor)
        {
            Doctor.PersonID = _Person.PersonID;
            Doctor.SpecializationID = cbxSpecialization.SelectedIndex + 1;
            Doctor.WorkingHours = Convert.ToInt32(numUDWorkingHours.Value);

            return Doctor.Save();
        }

        private void CheckField(Control control, string fieldName, List<string> errorFields)
        {
            if (!string.IsNullOrEmpty(errorProvider1.GetError(control)))
            {
                errorFields.Add(fieldName);
            }
            if (control.Tag != null)
            {
                //if (control.Tag.ToString() == "NationalNO")
                //{
                //    errorFields.Add(fieldName);

                //}

            }
        }



        private bool _CheckIfSaveDoctorIsAvalible()
        {
            List<string> errorFields = new List<string>();

            CheckField(txtName, "Patient Name", errorFields);
            CheckField(txtNationalNo, "National Number", errorFields);
            CheckField(txtPhoneNumber, "Phone Number", errorFields);


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

            if (!_CheckIfSaveDoctorIsAvalible())
                return;

            if (SavePersonInfo(ref _Person))
            {
                if (SaveDoctorInfo(ref _Doctor) && _EmergencyContact != null)
                {
                    MessageBox.Show("The Doctor Is Added Successfully", "Saved Successfully", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    btnSave.Enabled = false;

                    BackDoctorID?.Invoke( _Doctor.DoctorID);
                    gbxPersonalInfo.Enabled = false;
                    gbxCareerInfo.Enabled = false;
                }
                else
                {
                    MessageBox.Show("The Doctor Adding Failed", "Error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("The Person Adding Failed", "Error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
        }

        private void _LoadData()
        {
            txtName.Text = _Doctor.PersonInfo.FullName;
            txtNationalNo.Text = _Doctor.PersonInfo.NationalNumber;
            dtpDOB.Text = _Doctor.PersonInfo.DateOfBirth.ToShortDateString();
            cbxGendor.SelectedIndex = (int)_Doctor.PersonInfo.Gendor - 1;
            txtPhoneNumber.Text = _Doctor.PersonInfo.PhoneNumber;
            txtAddress.Text = _Doctor.PersonInfo.Address;
            pbxDoctorImage.ImageLocation = _Doctor.PersonInfo.ImagePath;



            cbxSpecialization.SelectedIndex = (int)_Doctor.SpecializationID - 1;
            numUDWorkingHours.Value = _Doctor.WorkingHours;
        }

        private void CheckIfTextBoxISEmpty(object sender, CancelEventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox textBox = (Guna.UI2.WinForms.Guna2TextBox)sender;


            if (textBox.Text.Length == 0)
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "This Field Is Required!");
            }
            else if (textBox.Tag != null)
            {
                if(textBox.Tag.ToString() == "name")
                {
                    if (textBox.Text.Split(' ').Length < 2)
                    {
                        e.Cancel = false;
                        errorProvider1.SetError(textBox, "Please Enter At least First & Last Name");
                    }

                }
                else if(textBox.Tag.ToString() == "NationalNO")
                {
                    if (clsPeople.IsPersonExist(txtNationalNo.Text))
                    {
                        e.Cancel = false;
                        errorProvider1.SetError(textBox, "This NationalNo. Is Already Used");
                    }
                    else
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
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddNewDoctor_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> SpecializationNames = clsSpecializations.GetAllSpecializationName();

                cbxSpecialization.DataSource = SpecializationNames;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }            //cbxSpecialization.SelectedIndex = 0;
            if (enMode == _Mode.enUpdate)
            {
                _LoadData();
                txtNationalNo.Enabled = false;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
    
}
