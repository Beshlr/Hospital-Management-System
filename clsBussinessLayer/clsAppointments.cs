using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalDataLayer;
namespace clsBussinessLayer
{
    public class clsAppointments
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public clsPatients PatientsInfo { get; set; }
        public int DoctorID { get; set; }
        public clsDoctors DoctorsInfo { get; set; }
        public DateTime Date { get; set; }
        public byte Status { get; set; }
        public enum enStatus
        {
            Scheduled,          // 0
            Confirmed,          // 1
            Pending,            // 2
            CancelledByPatient, // 3
            CancelledByDoctor,  // 4
            Rescheduled,        // 5
            Completed,          // 6
            Missed              // 7
        }

        public enStatus AppStatus = enStatus.Scheduled;
        public int RoomID { get; set; }
        public int TempRoomID {  get; set; }
        public clsRooms RoomsInfo { get; set; }


        public clsAppointments()
        {
            this.AppointmentID = -1;
            this.AppointmentID = -1;
            this.PatientID = -1;
            this.DoctorID = -1;
            this.Date = DateTime.Now;
            this.Status = default(byte);
            this.RoomID = -1;
            Mode = enMode.AddNew;
        }


        private clsAppointments(
int AppointmentID, int PatientID, int DoctorID, DateTime Date, byte Status, int RoomID)
        {
            this.AppointmentID = AppointmentID;
            this.PatientID = PatientID;
            this.PatientsInfo = clsPatients.FindByPatientID(PatientID);
            this.DoctorID = DoctorID;
            this.DoctorsInfo = clsDoctors.FindByDoctorID(DoctorID);
            this.Date = Date;
            this.Status = Status;
            this.AppStatus = (enStatus)this.Status;
            this.RoomID = RoomID;
            this.RoomsInfo = clsRooms.FindByRoomID(RoomID);
            Mode = enMode.Update;
        }


        private bool _AddNewAppointments()
        {
            bool SaveRoomNO = false;
            this.AppointmentID = clsAppointmentsData.AddNewAppointments(
    this.PatientID, this.DoctorID, this.Date, this.Status, this.RoomID);

            SaveRoomNO = clsRoomsData.UpdateRoomReservation(this.RoomID, true);

            return (this.AppointmentID != -1 && SaveRoomNO);

        }


        public static bool AddNewAppointments(
 ref int AppointmentID, int PatientID, int DoctorID, DateTime Date, byte Status, int RoomID)
        {
            AppointmentID = clsAppointmentsData.AddNewAppointments(
    PatientID, DoctorID, Date, Status, RoomID);

            return (AppointmentID != -1);

        }


        private bool _UpdateAppointments()
        {
            bool SaveUpdateApp =
            clsAppointmentsData.UpdateAppointmentsByID(
            this.AppointmentID, this.PatientID, this.DoctorID, this.Date, this.Status, this.RoomID);

            bool SaveNewRoomNO = false;

            if (this.TempRoomID != -1)
            {
                 SaveNewRoomNO = (clsRooms.ChangeRoomReservation(TempRoomID, false) &&
                    clsRooms.ChangeRoomReservation(RoomID, true));
            }

            return (SaveUpdateApp && SaveNewRoomNO);
        }


        public static bool UpdateAppointmentsByID(
 int AppointmentID, int PatientID, int DoctorID, DateTime Date, byte Status, int RoomID)
        {
            return clsAppointmentsData.UpdateAppointmentsByID(
    AppointmentID, PatientID, DoctorID, Date, Status, RoomID);

        }

        public bool UpdateAppointmentStatus(int AppID, enStatus Status)
        {
            bool IsUpdated = false;
            bool ChangeRoomAvaliblity = false;

            IsUpdated = clsAppointmentsData.UpdateAppStatus(AppID, (byte)Status);

            //Change Room Reservation Status According To Appointment Status
            if (Status == enStatus.Missed || Status == enStatus.CancelledByPatient || Status == enStatus.CancelledByDoctor
                || Status == enStatus.Confirmed)
                ChangeRoomAvaliblity = clsRooms.ChangeRoomReservation(this.RoomID, false);

            return (IsUpdated && ChangeRoomAvaliblity);
        }


        public static clsAppointments FindByAppointmentID(int AppointmentID)

        {
            if (AppointmentID == -1)
            {
                return null;
            }
            int PatientID = 0;
            int DoctorID = 0;
            DateTime Date = DateTime.Now;
            byte Status = default(byte);
            int RoomID = 0;
            bool IsFound = clsAppointmentsData.GetAppointmentsInfoByID(AppointmentID,
 ref PatientID, ref DoctorID, ref Date, ref Status, ref RoomID);

            if (IsFound)
                return new clsAppointments(
  AppointmentID, PatientID, DoctorID, Date, Status, RoomID);
            else
                return null;
        }

        public static string GetAppStatusByInt(int AppStatus)
        {
            switch (AppStatus)
            {
                case 0:
                    return "Scheduled";
                case 1:
                    return "Confirmed";
                case 2:
                    return "Pending";
                case 3:
                    return "Cancelled by Patient";
                case 4:
                    return "Cancelled by Doctor";
                case 5:
                    return "Rescheduled";
                case 6:
                    return "Completed";
                default:
                    return "Missed";
            }
        }

        public static DataTable GetAllAppointments()
        {
            DataTable dt1 = clsAppointmentsData.GetAllAppointments();
            DataTable dt2 = new DataTable();

                dt2.Columns.Add("Appointment ID", typeof(int));
                dt2.Columns.Add("Patient Name", typeof(string));
                dt2.Columns.Add("Doctor Name", typeof(string));
                dt2.Columns.Add("Date", typeof(DateTime));
                dt2.Columns.Add("Status", typeof(string));
                dt2.Columns.Add("Room Number", typeof(string));
                dt2.Columns.Add("Department", typeof(string));

            if (dt1.Rows.Count > 0)
            {
                clsPatients patient = new clsPatients();
                clsDoctors doctor = new clsDoctors();
                clsRooms room = new clsRooms();
                clsAppointments app = new clsAppointments();

                foreach (DataRow dr in dt1.Rows)
                {
                    DateTime AppDate = Convert.ToDateTime(dr[3]);
                    if (AppDate < DateTime.Now.AddDays(-30))
                        continue;

                    int AppID = Convert.ToInt32(dr[0]);
                    app = clsAppointments.FindByAppointmentID(AppID);
                    app._UpdateAppStatusToMissed();

                    int patientID = Convert.ToInt32(dr[1]);
                    int doctorID = Convert.ToInt32(dr[2]);
                    int roomID = Convert.ToInt32(dr[5]);
                    
                    patient = app.PatientsInfo;
                    doctor = app.DoctorsInfo;
                    room = app.RoomsInfo;

                    string AppStatus = GetAppStatusByInt(Convert.ToInt32(dr[4]));

                    string Department = doctor.SpecializationInfo.SpecializationName;
                    
                    dt2.Rows.Add(AppID, patient.PersonInfo.FullName, doctor.PersonInfo.FullName, AppDate, AppStatus, room.RoomNumber, Department);
                }
            }

            return dt2;
        }



        public static bool CheckIfAppoimentIsMissed(int AppointmentID)
        {
            return (clsAppointments.FindByAppointmentID(AppointmentID).Date < DateTime.Now &&
                    clsAppointments.FindByAppointmentID(AppointmentID).Status != 7);
            
            
        }

        private bool _UpdateAppStatusToMissed()
        {
            if (!CheckIfAppoimentIsMissed(this.AppointmentID))
                return false;
            this.Status = 7;
            return this._UpdateAppointments();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAppointments())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateAppointments();

            }

            return false;
        }



        public static bool DeleteAppointments(int AppointmentID)
        {
            if (clsRooms.ChangeRoomReservation(clsAppointments.GetRoomIDByAppID(AppointmentID), false))
                return (clsAppointmentsData.DeleteAppointments(AppointmentID));
            else
                return false;

        }


        public enum enAppointmentsColumns
        {
            AppointmentID,
            PatientID,
            DoctorID,
            Date,
            Status,
            RoomID
        }

        public static int GetRoomIDByAppID(int AppID)
        {
            if (AppID == -1) return -1;
            int RoomID = -1;

            return clsAppointmentsData.GetRoomIDByAppID(AppID);
        }

        public static int CheckIfPatientHasActiveApp(int PatientID)
        {
            return clsAppointmentsData.CheckIfPatentHasAnActiveAppointment(PatientID);
        }

        public static DataTable SearchData(enAppointmentsColumns enChose, string Data)
        {
            if (!SqlHelper.IsSafeInput(Data))
                return null;

            return clsAppointmentsData.SearchData(enChose.ToString(), Data);

        }

    }
}
