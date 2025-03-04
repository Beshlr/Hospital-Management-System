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
using Hospital_Management_System.Doctors;
using Hospital_Management_System.Patients;
using Hospital_Management_System.Properties;

namespace Hospital_Management_System.Appointments
{
    public partial class frmAddAppointment : Form
    {
        public frmAddAppointment(int AppointmentID = -1)
        {
            InitializeComponent();
            if (AppointmentID != -1)
            {
                _Appointment = clsAppointments.FindByAppointmentID(AppointmentID);
                _SelectedPatient = _Appointment.PatientsInfo;
                _SelectedDoctor = _Appointment.DoctorsInfo;
                _Mode = _enMode.enUpdate;
            }
        }

        private List<clsPatients> _patients = new List<clsPatients>();
        private List<clsDoctors> _doctors = null;
        private clsPatients _SelectedPatient = null;
        private clsDoctors _SelectedDoctor = null;
        private clsAppointments _Appointment = new clsAppointments();
        private enum _enMode { enAddNew = 1, enUpdate = 2};
        private _enMode _Mode = _enMode.enAddNew;
        private int _TempRoomID = -1;
        private void _HandelShowAndHideFoundPatientsPanal(List<clsPatients> patients)
        {
            

            pnlFoundPatients.Visible = patients.Count >= 0;

            if(patients.Count == 0 )
            {
                pnlAddNewPatient.Visible = true;
                pnlPatient1.Visible = false;
                pnlPatient2.Visible = false;
                pnlPatient3.Visible = false;

            }
            else if (patients.Count == 1)
            {
                pnlPatient1.Visible = true;
                pnlPatient2.Visible = false;
                pnlPatient3.Visible = false;
            }
            else if (patients.Count == 2)
            {
                pnlPatient1.Visible = true;
                pnlPatient2.Visible = true;
                pnlPatient3.Visible = false;
            }
            else
            {
                pnlPatient1.Visible = true;
                pnlPatient2.Visible = true;
                pnlPatient3.Visible = true;
            }
        }

        private void _HandelLoadFoundPatientsData(List<clsPatients> patients)
        {
            if (patients.Count == 0)
                return;
            if(pnlPatient1.Visible)
            {
                if (patients[0].PersonInfo.ImagePath != null)
                    pbxPatient1Image.ImageLocation = patients[0].PersonInfo.ImagePath;
                else
                    pbxPatient1Image.Image = Resources.Patient_512;
                lblPatient1Name.Text = patients[0].PersonInfo.FullName;
            }
            if(pnlPatient2.Visible)
            {
                if (patients[1].PersonInfo.ImagePath != null)
                    pbxPatient2Image.ImageLocation = patients[1].PersonInfo.ImagePath;
                lblPatient2Name.Text = patients[1].PersonInfo.FullName;
            }
            if (pnlPatient3.Visible)
            {
                if (patients[2].PersonInfo.ImagePath != null)
                    pbxPatient3Image.ImageLocation = patients[2].PersonInfo.ImagePath;
                lblPatient3Name.Text = patients[2].PersonInfo.FullName;


            }
        }

        private void _HandelShowAndHideFoundDoctorsPanal(List<clsDoctors> doctors)
        {
            

            pnlFoundDoctors.Visible = doctors.Count >= 0;

            if(doctors.Count == 0)
            {
                pnlDoctor1.Visible = false;
                pnlDoctor2.Visible = false;
                pnlDoctor3.Visible = false;
                pnlAddNewDoctor.Visible = true;
            }
            else if (doctors.Count == 1)
            {
                pnlDoctor1.Visible = true;
                pnlDoctor2.Visible = false;
                pnlDoctor3.Visible = false;
            }
            else if (doctors.Count == 2)
            {
                pnlDoctor1.Visible = true;
                pnlDoctor2.Visible = true;
                pnlDoctor3.Visible = false;
            }
            else
            {
                pnlDoctor1.Visible = true;
                pnlDoctor2.Visible = true;
                pnlDoctor3.Visible = true;
            }
        }

        private void _HandelLoadFoundDoctorsData(List<clsDoctors> doctors)
        {
            if(pnlDoctor1.Visible)
            {
                if (doctors[0].PersonInfo.ImagePath != null)
                    pbxDoctor1Image.ImageLocation = doctors[0].PersonInfo.ImagePath;
                //else
                    //pbxPatient1Image.Image = Resources.patient_512;
                lblDoctor1Name.Text = doctors[0].PersonInfo.FullName;
            }
            if(pnlDoctor2.Visible)
            {
                if (doctors[1].PersonInfo.ImagePath != null)
                    pbxDoctor2Image.ImageLocation = doctors[1].PersonInfo.ImagePath;
                lblDoctor2Name.Text = doctors[1].PersonInfo.FullName;
            }
            if (pnlDoctor3.Visible)
            {
                if (doctors[2].PersonInfo.ImagePath != null)
                    pbxDoctor3Image.ImageLocation = doctors[2].PersonInfo.ImagePath;
                lblDoctor3Name.Text = doctors[2].PersonInfo.FullName;


            }
        }




        private clsPatients TempPatient = new clsPatients();

        private void txtPatientSearchBar_TextChanged(object sender, EventArgs e)
        {
            clsPatients patient = new clsPatients();

            if(txtPatientSearchBar.Text == String.Empty)
            {
                _patients = new List<clsPatients>();
                pnlFoundPatients.Visible = false;
                return;
            }

            if (rbtnPatientName.Checked)
                _patients = clsPatients.GetPatientThereNameStartWith(txtPatientSearchBar.Text.Trim());
            else
            {
                patient = clsPatients.FindByNationalNO(txtPatientSearchBar.Text.Trim());
                if(patient != TempPatient && _patients != null)
                {
                    if (_patients.Contains(TempPatient))
                        _patients.Remove(TempPatient);
                }
                if (patient != null && !_patients.Contains(patient))
                {
                    _patients.Add(patient);
                    TempPatient = patient;
                }
            }

            if(_patients == null)
            {
                pnlFoundPatients.Visible = true;
                pnlAddNewPatient.Visible = true;
                pnlPatient1.Visible = false;
                pnlPatient2.Visible = false;
                pnlPatient3.Visible = false;

                return;
            }

            if (_patients.Count >= 0 && _patients!= null)
            {
                _HandelShowAndHideFoundPatientsPanal(_patients);
                _HandelLoadFoundPatientsData(_patients);
            }

            if (txtPatientSearchBar.Text.Length == 0)
                pnlFoundPatients.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewPatient frm = new frmAddNewPatient(null);
            frm.ShowDialog();
        }

        private void llblAddNewPatient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewPatient frm1 = new frmAddNewPatient(null);
            frm1.BackPatientID += _LoadSelectedPatientData;
            frm1.ShowDialog();
        }

        private void pnlPatient1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _HandelSelectPatient(object sender, EventArgs e)
        {
            if (((Control)sender).Tag.ToString() == "Patient1")
                _SelectedPatient = _patients[0];
            else if(((Control)sender).Tag.ToString() == "Patient2")
                _SelectedPatient = _patients[1];
            else
                _SelectedPatient = _patients[2];

        }

        private void _HandelSelectDoctor(object sender, EventArgs e)
        {
            if (((Control)sender).Tag.ToString() == "Doctor1")
                _SelectedDoctor = _doctors[0];
            else if(((Control)sender).Tag.ToString() == "Doctor2")
                _SelectedDoctor = _doctors[1];
            else
                _SelectedDoctor = _doctors[2];

        }

        private void _LoadSelectedPatientData(int PatientID = -1)
        {
            if(PatientID != -1)
                _SelectedPatient = clsPatients.FindByPatientID(PatientID);
            gbxPatientInfo.Enabled = true;
            pnlFoundPatients.Visible = false;
            txtPatientSearchBar.Text = String.Empty;


            if (_SelectedPatient.PersonInfo.ImagePath != null)
                pbxSelectedPatientImage.ImageLocation = _SelectedPatient.PersonInfo.ImagePath;

            lblPatientID.Text = _SelectedPatient.PatientID.ToString();
            lblPatientFullName.Text = _SelectedPatient.PersonInfo.FullName;
            lblPatientNationalNO.Text = _SelectedPatient.PersonInfo.NationalNumber;
            lblBloodType.Text = _SelectedPatient.BloodTypeName();
            
            if (_SelectedPatient.Allergies.Length > 0 || _SelectedPatient.Allergies != null)
                lblAllergies.Text = _SelectedPatient.Allergies;
            else
                lblAllergies.Text = "Noun";

            lblLastVisitDate.Text = _SelectedPatient.LastVisitDate.ToShortDateString();
            lblPatientStatus.Text = _SelectedPatient.PatientStatusText();

            if (_SelectedPatient.EmergencyContactID != -1 && _SelectedPatient.EmergemcyContactInfo != null)
            {
                lblContactName.Text = _SelectedPatient.EmergemcyContactInfo.ContactName;
                lblContactPhoneNO.Text = _SelectedPatient.EmergemcyContactInfo.ContactFirstPhoneNO;
                lblRWP.Text = _SelectedPatient.EmergemcyContactInfo.RelationshipWithEmergencyContact;
            }

            if (gbxDoctorInfo.Enabled)
                btnSave.Enabled = true;

        }

         private void _LoadSelectedDoctorData( int DoctorID = -1)
        {
            if (DoctorID != -1)
                _SelectedDoctor = clsDoctors.FindByDoctorID(DoctorID);
            gbxDoctorInfo.Enabled = true;
            pnlFoundDoctors.Visible = false;
            txtDoctorsSearchBar.Text = String.Empty;

            if (_SelectedDoctor.PersonInfo.ImagePath != null)
                pbxSelectedDoctorImage.ImageLocation = _SelectedDoctor.PersonInfo.ImagePath;

            lblDoctorID.Text = _SelectedDoctor.DoctorID.ToString();
            lblDoctorFullName.Text = _SelectedDoctor.PersonInfo.FullName;
            lblDoctorNationalNO.Text = _SelectedDoctor.PersonInfo.NationalNumber;
            lblIsDoctorAvailable.Text = "Yes";
            lblSpecialization.Text = _SelectedDoctor.SpecializationInfo.SpecializationName;


            if (gbxPatientInfo.Enabled)
            {
                btnSave.Enabled = true;
            }

        }



        private void pnlPatient1_Click(object sender, EventArgs e)
        {
            string NumPatient = "";
            

            NumPatient = ((Control)sender).Tag.ToString();

            if (NumPatient == "Patient1" || NumPatient == "Patient2" || NumPatient == "Patient3")
            {
                _HandelSelectPatient(sender,e);
                if (MessageBox.Show($"Are You Sure You Want To Choose Patient With National NO {_SelectedPatient.PersonInfo.NationalNumber} ?",
                                "Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _LoadSelectedPatientData(-1);
                }
            }
            else
            {
                _HandelSelectDoctor(sender,e);
                if (MessageBox.Show($"Are You Sure You Want To Choose Doctor With NationalNO :{_SelectedDoctor.PersonInfo.NationalNumber} ?",
                                "Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _LoadSelectedDoctorData( _SelectedDoctor.DoctorID);
                }


            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlEmergencyContactInfo.Visible = false;
        }

        private void frmAddAppointment_Load(object sender, EventArgs e)
        {
            pnlFoundPatients.Visible = false;
            pnlFoundDoctors.Visible = false;
            pnlEmergencyContactInfo.Visible = false;

            try
            {
                List<string> roomNumbers = clsRooms.GetAllRoomNumbers();

                cbxRoomNO.DataSource = roomNumbers; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            gbxPatientInfo.Enabled = false;
            gbxDoctorInfo.Enabled = false;
            gbxFilterBy.Visible = false;

            btnSave.Enabled = false;

            dtpDate.MinDate = DateTime.Now.AddDays(-30);
            dtpDate.MaxDate = DateTime.Now.AddYears(5);

            dtpDate.Value = DateTime.Now.AddDays(1);

            if(_Mode == _enMode.enUpdate)
            {
                _LoadSelectedPatientData();
                _LoadSelectedDoctorData();

                cbxRoomNO.Text = _Appointment.RoomsInfo.RoomNumber;
                dtpDate.Text = _Appointment.Date.ToShortDateString();
                dtpDate.Enabled = (_Appointment.AppStatus != clsAppointments.enStatus.Rescheduled);
            }
        }

        private void llblPEC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_SelectedPatient.EmergemcyContactInfo != null)
                pnlEmergencyContactInfo.Visible = true;
            else
                MessageBox.Show("This Patient Doesn't Has Any Emergency Contact Info To Show", "Not Found", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void llblEditDoctorInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewDoctor frm = new frmAddNewDoctor(_SelectedDoctor.PersonInfo.NationalNumber);
            frm.ShowDialog();
            _LoadSelectedDoctorData(_SelectedDoctor.DoctorID);
        }

        private void llblEditPatientInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewPatient frm = new frmAddNewPatient(_SelectedPatient.PersonInfo.NationalNumber);
            frm.ShowDialog();
            _LoadSelectedPatientData(_SelectedPatient.PatientID);
        }

        


        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            _doctors = clsDoctors.GetDoctorsThereNameStartWith(txtDoctorsSearchBar.Text.Trim());

            if (_doctors.Count >= 0)

            {
                _HandelShowAndHideFoundDoctorsPanal(_doctors);
                _HandelLoadFoundDoctorsData(_doctors);
            }

            if (txtDoctorsSearchBar.Text.Length == 0)
                pnlFoundDoctors.Visible = false;
        }

        private void llblAddNewDoctor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewDoctor frm = new frmAddNewDoctor(null);
            frm.BackDoctorID += _LoadSelectedDoctorData;
            frm.ShowDialog();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsAppointments appointment = new clsAppointments();

            int ActiveAppID = clsAppointments.CheckIfPatientHasActiveApp(_SelectedPatient.PatientID);
            if (ActiveAppID != -1)
            {
                if(MessageBox.Show($"Selected Patient Has An Active Appointment With ID : [ {ActiveAppID} ]Do You Want To Cancel This Appointment ?",
                                    "Patient Has Another Appointment",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    clsAppointments app = clsAppointments.FindByAppointmentID(ActiveAppID);
                    app.Status = 3;
                    app.Save();
                }
            }

                if (_Appointment.AppointmentID != -1)
                appointment = _Appointment;
            appointment.PatientID = _SelectedPatient.PatientID;
            appointment.DoctorID = _SelectedDoctor.DoctorID;
            if (_Appointment.AppointmentID != -1)
            {
                if (dtpDate.Value != appointment.Date)
                {
                    appointment.Date = dtpDate.Value;
                    appointment.Status = 5;
                    appointment.UpdateAppointmentStatus(appointment.AppointmentID, clsAppointments.enStatus.Rescheduled);
                }

            }
            else
                appointment.Date = dtpDate.Value;
            int SelectedRoomID = clsRooms.GetRoomIDByRoomNO(cbxRoomNO.Text);

            if (SelectedRoomID != appointment.RoomID && appointment.RoomID != -1)
            {
                appointment.TempRoomID = appointment.RoomID;
                appointment.RoomID = SelectedRoomID;
            }
            else
                appointment.RoomID = SelectedRoomID;

            if(
            appointment.Save())
            {
                MessageBox.Show("Appointment Saved Successfully", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Appointment Saved Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxSearchFilter_Click(object sender, EventArgs e)
        {
            if(gbxFilterBy.Visible)
                gbxFilterBy.Visible = false;
            else
                gbxFilterBy.Visible = true;
        }

        private void btnSave_DoubleClick(object sender, EventArgs e)
        {

        }

        private void rbtnNationalNO_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNationalNO.Checked)
                txtPatientSearchBar.PlaceholderText = "Enter NationalNO.";
            else
                txtPatientSearchBar.PlaceholderText = "Enter Patient's Name";

        }

        private void txtPatientSearchBar_Click(object sender, EventArgs e)
        {
            if(gbxFilterBy.Visible)
                gbxFilterBy.Visible = false;
        }

        private void cbxRoomNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_Mode == _enMode.enUpdate)
            {
                if (cbxRoomNO.SelectedIndex != cbxRoomNO.SelectedIndex + 1)
                {
                    _TempRoomID = _Appointment.RoomID;
                }
            }
        }
    }
}
