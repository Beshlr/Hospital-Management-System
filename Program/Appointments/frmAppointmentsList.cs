using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsBussinessLayer;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;

namespace Hospital_Management_System.Appointments
{
    public partial class frmAppointmentsList : Form
    {
        public frmAppointmentsList()
        {
            InitializeComponent();
        }

        private string _FilterText = "Patient Name";
        private DataTable _Appointments = new DataTable();
        private int _AppID = -1;
        private clsAppointments _AppInfo = null;

        private Dictionary<int, Image> patientImages = new Dictionary<int, Image>();
        private Dictionary<int, Image> doctorImages = new Dictionary<int, Image>();

        private void frmAppointments_Load(object sender, EventArgs e)
        {
            cbxStatus.Visible = false;
            _LoadDataToList();
            gbxFilterBy.Visible = false;
            LoadAppointmentImages();
        }

        private void _LoadDataToList()
        {
            _Appointments = clsAppointments.GetAllAppointments();
            dgvAppointments.DataSource = _Appointments;
            if (_Appointments.Rows.Count > 0)
            {
                _AppID = Convert.ToInt32(dgvAppointments.CurrentCell.Value);
                _AppInfo = clsAppointments.FindByAppointmentID(_AppID);
            }
            else
            {

            }
            cbxStatus.SelectedIndex = 0;
        }

        private void pbxSearchFilter_Click(object sender, EventArgs e)
        {
            gbxFilterBy.Visible = !gbxFilterBy.Visible;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddAppointment frm = new frmAddAppointment();
            frm.ShowDialog();
            _LoadDataToList();
        }

        private void EditFilterText(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2RadioButton radioButton = (Guna.UI2.WinForms.Guna2RadioButton)sender;
            string rbtnText = radioButton.Text;

            switch (rbtnText)
            {
                case "Patient Name":
                    txtSearchBar.PlaceholderText = "Enter Patient's Name";
                    _FilterText = "Patient Name";
                    break;
                case "Doctor Name":
                    txtSearchBar.PlaceholderText = "Enter Doctor's Name";
                    _FilterText = "Doctor Name";
                    break;
                case "Status":
                    _FilterText = "Status";
                    break;
                case "Department":
                    _FilterText = "Department";
                    break;
                default:
                    _FilterText = "Noun";
                    break;
            }

            ToggleFilterVisibility(radioButton.Tag?.ToString());
        }

        private void ToggleFilterVisibility(string tag)
        {
            if (tag == "Status")
            {
                string[] Status = { "Noun", "Scheduled", "Confirmed", "Pending", "Cancelled by Patient", "Cancelled by Doctor", "Rescheduled", "Completed", "Missed" };
                cbxStatus.DataSource = Status;
                cbxStatus.Visible = !cbxStatus.Visible;
                txtSearchBar.Visible = !cbxStatus.Visible;
            }
            else if (tag == "Department")
            {
                List<string> Specializations = new List<string> { "Noun" };
                Specializations.AddRange(clsSpecializations.GetAllSpecializationName());
                cbxStatus.DataSource = Specializations;
                cbxStatus.Visible = !cbxStatus.Visible;
                txtSearchBar.Visible = !cbxStatus.Visible;
            }
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_FilterText) || _FilterText == "Noun")
            {
                _Appointments.DefaultView.RowFilter = "";
            }
            else if (_FilterText == "Status" || _FilterText == "Department")
            {
                _Appointments.DefaultView.RowFilter = cbxStatus.Text == "Noun" ? "" : $"[{_FilterText}] = '{cbxStatus.Text}'";
            }
            else
            {
                _Appointments.DefaultView.RowFilter = $"[{_FilterText}] LIKE '{txtSearchBar.Text.Trim()}%'";
            }

        }

        private void txtSearchBar_Click(object sender, EventArgs e)
        {
            if (gbxFilterBy.Visible)
            {
                gbxFilterBy.Visible = false;
            }
        }

        private void LoadAppointmentImages()
        {
            foreach (DataGridViewRow row in dgvAppointments.Rows)
            {
                if (row.Cells[0].Value == null) continue;

                int appointmentID = Convert.ToInt32(row.Cells[0].Value);
                clsAppointments appointment = clsAppointments.FindByAppointmentID(appointmentID);

                if (!patientImages.ContainsKey(appointment.PatientsInfo.PersonInfo.PersonID))
                {
                    patientImages[appointment.PatientsInfo.PersonInfo.PersonID] = LoadImage(appointment.PatientsInfo.PersonInfo.ImagePath);
                }

                if (!doctorImages.ContainsKey(appointment.DoctorsInfo.PersonInfo.PersonID))
                {
                    doctorImages[appointment.DoctorsInfo.PersonInfo.PersonID] = LoadImage(appointment.DoctorsInfo.PersonInfo.ImagePath);
                }
            }
        }

        private Image LoadImage(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                using (Image original = Image.FromFile(imagePath))
                {
                    return CropToSquare(original, 30);
                }
            }
            return CropToSquare(Properties.Resources.Patient_128, 30);
        }

        private Image CropToSquare(Image original, int size)
        {
            int cropSize = Math.Min(original.Width, original.Height);
            int x = (original.Width - cropSize) / 2;
            int y = (original.Height - cropSize) / 2;

            Bitmap croppedImage = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(croppedImage))
            {
                g.DrawImage(original, new Rectangle(0, 0, size, size), new Rectangle(x, y, cropSize, cropSize), GraphicsUnit.Pixel);
            }
            return croppedImage;
        }

        private void dgvAppointments_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (!int.TryParse(dgvAppointments.Rows[e.RowIndex].Cells[0].Value?.ToString(), out int appointmentID))
                return;

            clsAppointments appointment = clsAppointments.FindByAppointmentID(appointmentID);

            if (appointment == null) return;

            if (e.ColumnIndex == dgvAppointments.Columns["Patient Name"].Index)
            {
                if (patientImages.TryGetValue(appointment.PatientsInfo.PersonInfo.PersonID, out Image patientImage))
                {
                    DrawCellWithImage(e, patientImage, appointment.PatientsInfo.PersonInfo.FullName);
                }
            }
            else if (e.ColumnIndex == dgvAppointments.Columns["Doctor Name"].Index)
            {
                if (doctorImages.TryGetValue(appointment.DoctorsInfo.PersonInfo.PersonID, out Image doctorImage))
                {
                    DrawCellWithImage(e, doctorImage, appointment.DoctorsInfo.PersonInfo.FullName);
                }
            }
        }

        private void DrawCellWithImage(DataGridViewCellPaintingEventArgs e, Image img, string name)
        {
            e.PaintBackground(e.ClipBounds, true);

            if (img != null)
            {
                Rectangle imgRect = new Rectangle(e.CellBounds.Left + 5, e.CellBounds.Top + 5, 30, 30);
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(imgRect);
                    e.Graphics.SetClip(path);
                    e.Graphics.DrawImage(img, imgRect);
                    e.Graphics.ResetClip();
                }
            }

            Rectangle textRect = new Rectangle(e.CellBounds.Left + 40, e.CellBounds.Top, e.CellBounds.Width - 40, e.CellBounds.Height);
            TextRenderer.DrawText(e.Graphics, name, e.CellStyle.Font, textRect, e.CellStyle.ForeColor, TextFormatFlags.VerticalCenter);

            e.Handled = true;
        }

        private void cmsUpdate_Click(object sender, EventArgs e)
        {
            frmAddAppointment frm = new frmAddAppointment(Convert.ToInt32(dgvAppointments.SelectedCells[0].Value));
            frm.ShowDialog();
            _LoadDataToList();
        }

        private void cmsAdd_Click(object sender, EventArgs e)
        {
            frmAddAppointment frm = new frmAddAppointment();
            frm.ShowDialog();
            _LoadDataToList();
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            GetSelectedAppID();
            if (MessageBox.Show($"Are You Sure You Want To Cancel Appointment With ID : {_AppID} ?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_AppInfo.UpdateAppointmentStatus(_AppID, clsAppointments.enStatus.CancelledByPatient))
                {
                    MessageBox.Show("Appointment Cancelled Successfully", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadDataToList();
                }
                else
                {
                    MessageBox.Show("Appointment Cancellation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GetSelectedAppID()
        {
            if (dgvAppointments.Rows.Count > 0)
            {
                _AppID = Convert.ToInt32(dgvAppointments.SelectedCells[0].Value);
                _AppInfo = clsAppointments.FindByAppointmentID(_AppID);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_AppID == -1)
                GetSelectedAppID();

            if (clsAppointments.DeleteAppointments(_AppID))
            {
                if (MessageBox.Show($"Are You Sure You Want To Delete This Appointment With ID :[{_AppID}]", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("This Appointment Is Deleted Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadDataToList();
                }
            }
            else
            {
                MessageBox.Show("Appointment Deletion Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAppointments_Click(object sender, EventArgs e)
        {
            GetSelectedAppID();
        }

        private void cmsMenuList_Opening(object sender, CancelEventArgs e)
        {
            if(_AppInfo == null)
            {
                cmsEdit.Enabled = false;
                cmsCancel.Enabled = false;
                cmsConfirm.Enabled = false;
                cmsInfo.Enabled = false;

                return;
            }
                if (_AppInfo.AppStatus == clsAppointments.enStatus.CancelledByPatient || _AppInfo.AppStatus == clsAppointments.enStatus.CancelledByDoctor
                || _AppInfo.AppStatus == clsAppointments.enStatus.Missed || _AppInfo.AppStatus == clsAppointments.enStatus.Confirmed)
            {
                cmsEdit.Enabled = false;
                cmsCancel.Enabled = false;
                cmsConfirm.Enabled = false;
            }
            else
            {
                cmsEdit.Enabled = true;
                cmsCancel.Enabled = true;
                cmsConfirm.Enabled = true;
            }
        }

        private void cmsConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Confirm This Appointment With ID : {_AppID} ?", "Confirm",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_AppInfo.UpdateAppointmentStatus(_AppID, clsAppointments.enStatus.Confirmed))
                {
                    MessageBox.Show("Appointment Confirmed Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadDataToList();
                }
                else
                {
                    MessageBox.Show("Appointment Confirmation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmsInfo_Click(object sender, EventArgs e)
        {
            if(_AppID == -1)
            {
            MessageBox.Show("This Appointment Info Does't Exist, Please Try Again Or Call Admin", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmAppointmentInfo frm = new frmAppointmentInfo(_AppID);
            frm.ShowDialog();
            _LoadDataToList();
        }

        private void dgvAppointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAppointmentInfo frm = new frmAppointmentInfo(_AppID);
            frm.ShowDialog();
            _LoadDataToList();
        }
       
    }
}
