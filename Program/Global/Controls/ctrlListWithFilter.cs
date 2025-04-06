using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using clsBussinessLayer;

namespace Hospital_Management_System.Global.Controls
{
    public partial class ctrlListWithFilter : UserControl
    {
        public ctrlListWithFilter(string listType)
        {
            InitializeComponent();
            HandleFormatScreen(listType);
        }

        private DataTable _ListData = new DataTable();

        private void HandleFormatScreen(string listType)
        {
            switch (listType)
            {
                case "Appointments":
                    SetupAppointmentsSettings();
                    break;

                case "Patients":
                    SetupPatientsSettings();
                    break;

                case "Nurses":
                    SetupNursesSettings();
                    break;

                case "Doctors":
                    SetupDoctorsSettings();
                    break;

                case "Rooms":
                    SetupRoomsSettings();
                    break;

                default:
                    SetupDefaultSettings();
                    break;
            }

            dgvList.DataSource = _ListData;
        }

        private void SetupAppointmentsSettings()
        {
            
            txtSearchBar.PlaceholderText = "Enter Patient's Text";
            rbtnPatientName.Text = "Patient Name";
            rbtnDoctorName.Text = "Doctor Name";
            rbtnStatus.Text = "Status";
            rbtnDepartment.Text = "Department";
            btnAdd.Text = "Add Appointment";

            cbxStatus.Items.Clear();
            cbxStatus.Items.AddRange(new string[] { "Scheduled", "Confirmed", "Pending", "Cancelled", "Rescheduled" });
            
            //Load Data
            _ListData = clsAppointments.GetAllAppointments();
        }

        private void SetupPatientsSettings()
        {
            
            txtSearchBar.PlaceholderText = "Enter Patient's Name";
            rbtnPatientName.Text = "Patient Name";
            rbtnDoctorName.Text = "Doctor Name";
            rbtnStatus.Text = "Status";
            rbtnDepartment.Text = "Department";
            btnAdd.Text = "Add Patient";

            cbxStatus.Items.Clear();
            cbxStatus.Items.AddRange(new string[] { "Active", "Inactive", "Discharged" });

            //Load Data
            _ListData = clsPatients.GetAllPatients();
        }

        private void SetupNursesSettings()
        {
            
            txtSearchBar.PlaceholderText = "Enter Nurse's Name";
            rbtnPatientName.Text = "Nurse Name";
            rbtnDoctorName.Text = "Department";
            rbtnStatus.Text = "Status";
            rbtnDepartment.Text = "Shift";
            btnAdd.Text = "Add Nurse";
            cbxStatus.Items.Clear();
            cbxStatus.Items.AddRange(new string[] { "On Duty", "Off Duty", "On Leave" });

            ////Load Data
            //_ListData = clsPatients.GetAllPatients();
        }

        private void SetupDoctorsSettings()
        {
                        txtSearchBar.PlaceholderText = "Enter Doctor's Name";
            rbtnPatientName.Text = "Doctor Name";
            rbtnDoctorName.Text = "Specialization";
            rbtnStatus.Text = "Status";
            rbtnDepartment.Text = "Department";
            btnAdd.Text = "Add Doctor";

            cbxStatus.Items.Clear();
            cbxStatus.Items.AddRange(new string[] { "Available", "Busy", "On Leave" });

            //Load Data
            _ListData = clsDoctors.GetAllDoctors();
        }

        private void SetupRoomsSettings()
        {
            
            txtSearchBar.PlaceholderText = "Enter Room Number";
            rbtnPatientName.Text = "Room Number";
            rbtnDoctorName.Text = "Room Type";
            rbtnStatus.Text = "Status";
            rbtnDepartment.Text = "Department";
            btnAdd.Text = "Add Room";

            cbxStatus.Items.Clear();
            cbxStatus.Items.AddRange(new string[] { "Available", "Occupied", "Under Maintenance" });

            //Load Data
            _ListData = clsRooms.GetAllRooms();
        }

        private void SetupDefaultSettings()
        {
            
            txtSearchBar.PlaceholderText = "Search...";
            rbtnPatientName.Text = "Name";
            rbtnDoctorName.Text = "Type";
            rbtnStatus.Text = "Status";
            rbtnDepartment.Text = "Category";
            btnAdd.Text = "Add";

            cbxStatus.Items.Clear();
            cbxStatus.Items.AddRange(new string[] { "Active", "Inactive" });
        }

        //private void _
    }
}