using clsBussinessLayer;
using Hospital_Management_System.Patients;
using Hospital_Management_System.Appointments;
using Hospital_Management_System.Doctors;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hospital_Management_System.Global.Controls
{
    public partial class ctrlListWithFilter : UserControl
    {
        public ctrlListWithFilter()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This Constracter for user control class that's handle diffrent types of list
        /// </summary>
        /// <param name="listType">list of what?</param>
        public ctrlListWithFilter(enListTypes listType)
        {
            InitializeComponent();
            _HandleFormatScreen(listType);
        }

        // Start Global Variables
        public enum enListTypes { enAppointments = 1, enPatients = 2, enDoctors = 3,
                                                            enNurses = 4,enRooms = 5};

        public enListTypes enListOf = enListTypes.enDoctors;
        private DataTable _ListData = new DataTable();
        private int _NumOfRows = -1;

        // End Global Variables

        //Start Properties

        public static int _InsertedRowID { get; set; }

        //End Properties
        private int _GetNumberOfRows()
        {
            _NumOfRows = _ListData.Rows.Count;

            lblNoData.Visible = !(_NumOfRows > 0);
            
            pnlNumOfRows.Visible = !lblNoData.Visible;

            lblNumOfRows.Text = _NumOfRows.ToString();
            return _NumOfRows;
        }

        private void _HandleFormatScreen(enListTypes listType)
        {
            switch (listType)
            {
                case enListTypes.enAppointments:
                    SetupAppointmentsSettings();
                    enListOf = enListTypes.enAppointments;
                    break;

                case enListTypes.enPatients:
                    SetupPatientsSettings();
                    enListOf = enListTypes.enPatients;
                    break;

                case enListTypes.enNurses:
                    SetupNursesSettings();
                    enListOf = enListTypes.enNurses;
                    break;

                case enListTypes.enDoctors:
                    SetupDoctorsSettings();
                    enListOf = enListTypes.enDoctors;
                    break;

                case enListTypes.enRooms:
                    SetupRoomsSettings();
                    enListOf = enListTypes.enRooms;
                    break;

                default:
                    SetupDefaultSettings();
                    break;
            }

            dgvList.DataSource = _ListData;

            
            _GetNumberOfRows();
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

        private void pbxSearchFilter_Click(object sender, System.EventArgs e)
        {
            _ChangeGbxFilterVisablity(!gbxFilterBy.Visible);
        }

        

        private void _CheckIfUserSelectStatusOption(object sender, System.EventArgs e)
        {
            Guna.UI2.WinForms.Guna2RadioButton radiobutton = (Guna.UI2.WinForms.Guna2RadioButton)sender;
            string text = radiobutton.Text;
            if (text == "Status")
            {
                cbxStatus.Visible = true;
                txtSearchBar.Visible = false;
            }
            else
            {
                cbxStatus.Visible = false;
                txtSearchBar.Visible = true;
            }

        }

        private void _ChangeGbxFilterVisablity(bool visable)
        {
            gbxFilterBy.Visible = visable;
        }

        private void txtSearchBar_Enter(object sender, System.EventArgs e)
        {
            _ChangeGbxFilterVisablity(false);
        }

        private void pnlControls_Click(object sender, System.EventArgs e)
        {
            if(gbxFilterBy.Visible)
                _ChangeGbxFilterVisablity(false);
        }

        

        public void RefreashList()
        {
            switch (enListOf)
            {
                case enListTypes.enAppointments:
                    _ListData = clsAppointments.GetAllAppointments();
                    break;
                case enListTypes.enPatients:
                    _ListData = clsPatients.GetAllPatients();
                    break;
                case enListTypes.enDoctors:
                    _ListData = clsDoctors.GetAllDoctors();
                    break;
                case enListTypes.enNurses:
                    _ListData = null;
                    break;
                case enListTypes.enRooms:
                    _ListData = null;
                    break;
                default:
                    _ListData = clsAppointments.GetAllAppointments();
                    break;
            }
            dgvList.DataSource = _ListData;
            _NumOfRows = _ListData.Rows.Count;
            lblNumOfRows.Text = _NumOfRows.ToString();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            Form frm = new Form();
            _HandleShowAddingRowForm(ref frm);
            frm.ShowDialog();
            RefreashList();
        }



        private void _GetAddingRowID(int insertedID)
        {
            _InsertedRowID = insertedID;
        }

        private void _HandleShowAddingRowForm(ref Form frm)
        {
            switch (enListOf)
            {
                case enListTypes.enAppointments:
                    frm = new frmAddAppointment();
                    break;
                case enListTypes.enPatients:
                    frm = new frmAddNewPatient();
                    ((frmAddNewPatient)frm).BackPatientID += _GetAddingRowID;
                    break;
                case enListTypes.enDoctors:
                    frm = new frmAddNewDoctor();
                    ((frmAddNewDoctor)frm).BackDoctorID += _GetAddingRowID;
                    break;
                case enListTypes.enNurses:
                    frm = null;
                    break;
                case enListTypes.enRooms:
                    frm = null;
                    break;
                default:
                    frm = new frmAddAppointment();
                    break;
            }
        }
    }
}