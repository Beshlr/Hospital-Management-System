using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Management_System.Global;
using clsBussinessLayer;
namespace Hospital_Management_System.Appointments
{
    public partial class frmAppointmentInfo : Form
    {
        public frmAppointmentInfo(int AppointmentID)
        {
            InitializeComponent();
            if(AppointmentID != -1)
            {
                _AppID = AppointmentID;
                _AppInfo = clsAppointments.FindByAppointmentID(AppointmentID);
                _Patient = _AppInfo.PatientsInfo;
                _Doctor = _AppInfo.DoctorsInfo;
            }
        }

        private int _AppID = -1;
        private clsAppointments _AppInfo = null;
        private clsPatients _Patient = null;
        private clsDoctors _Doctor = null;

        private void _LoadAppDetails()
        {
            if(_AppInfo == null)
            {
                MessageBox.Show("This Appointment Info Does't Exist, Please Try Again Or Call Admin", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEditAppointment.Enabled = false;
                return;
            }

            //Load Patient Info.
            pbxPatientImage.ImageLocation = _AppInfo.PatientsInfo.PersonInfo.ImagePath;
            lblPatientID.Text = _Patient.PatientID.ToString();
            lblPatientName.Text = _Patient.PersonInfo.FullName;
            lblPatientGendor.Text = _Patient.PersonInfo.GendorText;
            lblPatientNationalNO.Text = _Patient.PersonInfo.NationalNumber;
            lblBloodType.Text = _Patient.PersonInfo.NationalNumber;

            if(_Patient.EmergemcyContactInfo != null)
            {
                lblContactName.Text = _Patient.EmergemcyContactInfo.ContactName;
                lblContactPhoneNO.Text = _Patient.EmergemcyContactInfo.ContactFirstPhoneNO;
                lblRWP.Text = _Patient.EmergemcyContactInfo.RelationshipWithEmergencyContact;

            }

            //Load Doctor Info.
            pbxDoctorImage.ImageLocation = _Doctor.PersonInfo.ImagePath;
            lblDoctorID.Text = _Doctor.DoctorID.ToString();
            lblDoctorName.Text = _Doctor.PersonInfo.FullName;
            lblDoctorGendor.Text = _Doctor.PersonInfo.GendorText;
            lblDoctorNationalNO.Text = _Doctor.PersonInfo.NationalNumber;
            lblSpecialization.Text = _Doctor.SpecializationInfo.SpecializationName;

            //Load Appointment Info.
            lblAppDate.Text = _AppInfo.Date.ToString("ddd, MMM dd, yyyy - hh:mm tt");
            lblRoomNO.Text = _AppInfo.RoomsInfo.RoomNumber;
            lblAppStatus.Text = clsAppointments.GetAppStatusByInt(Convert.ToInt32(_AppInfo.Status));
            
            switch(_AppInfo.Status)
            {
                // if Appointment Status Was : Pending Then The Patien Didn't Paid Else He Paid
                case 2:
                    lblAppPaid.Text = "NO";
                    lblAppPaid.ForeColor = Color.Red;
                    break;
                default:
                    lblAppPaid.Text = "YES";
                    lblAppPaid.ForeColor = Color.Green;
                    break;
            }

            if (_AppInfo.AppStatus == clsAppointments.enStatus.CancelledByPatient || _AppInfo.AppStatus == clsAppointments.enStatus.CancelledByDoctor
                || _AppInfo.AppStatus == clsAppointments.enStatus.Missed || _AppInfo.AppStatus == clsAppointments.enStatus.Confirmed)
            {
                
                btnEditAppointment.Enabled = false;

            }
            else
            {
                
                btnEditAppointment.Enabled = true;
            }
        }

        private void frmAppointmentInfo_Load(object sender, EventArgs e)
        {
            _LoadAppDetails();
        }

        private void btnEditAppointment_Click(object sender, EventArgs e)
        {
            frmAddAppointment frm = new frmAddAppointment(_AppID);
            frm.ShowDialog();

            _LoadAppDetails();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llblDoctorPhone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_Doctor != null)
            {
                MessageBox.Show($"Doctor Number Is :{_Doctor.PersonInfo.PhoneNumber} ", "Doctor's Number", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
        }

        private void llblEmergencyContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_Patient.EmergemcyContactInfo != null)
            {
                pnlPatientEContact.Visible = true;

            }
            else
            {
                MessageBox.Show("This Patient Doesn't Has Any Emergency Contact Info To Show","Not Found", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlPatientEContact.Visible = false;
        }
    }
}
