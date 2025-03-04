
using System;
using System.Data;
using Hospital_DataLayer;

namespace Hospital_BusinessLayer
{
    public class clsAppointments
    {
        #nullable enable

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? AppointmentID { get; set; }
        public int PatientID { get; set; }
        public clsPatients? PatientsInfo { get; set; }
        public int DoctorID { get; set; }
        public clsDoctors? DoctorsInfo { get; set; }
        public DateTime Date { get; set; }
        public byte Status { get; set; }
        public int RoomID { get; set; }
        public clsRooms? RoomsInfo { get; set; }


        public clsAppointments()
        {
            this.AppointmentID = null;
            this.AppointmentID = null;
            this.PatientID = 0;
            this.DoctorID = 0;
            this.Date = DateTime.Now;
            this.Status = default(byte);
            this.RoomID = 0;
            Mode = enMode.AddNew;
        }


        private clsAppointments(
int? AppointmentID,int PatientID, int DoctorID, DateTime Date, byte Status, int RoomID          )
        {
            this.AppointmentID = AppointmentID;
            this.PatientID = PatientID;
            this.PatientsInfo = clsPatients.FindByPatientID(PatientID);
            this.DoctorID = DoctorID;
            this.DoctorsInfo = clsDoctors.FindByDoctorID(DoctorID);
            this.Date = Date;
            this.Status = Status;
            this.RoomID = RoomID;
            this.RoomsInfo = clsRooms.FindByRoomID(RoomID);
            Mode = enMode.Update;
        }


       private bool _AddNewAppointments()
       {
        this.AppointmentID = clsAppointmentsData.AddNewAppointments(
this.PatientID, this.DoctorID, this.Date, this.Status, this.RoomID);

            return (this.AppointmentID != null);

       }


       public static bool AddNewAppointments(
ref int? AppointmentID,int PatientID, int DoctorID, DateTime Date, byte Status, int RoomID)
        {
        AppointmentID = clsAppointmentsData.AddNewAppointments(
PatientID, DoctorID, Date, Status, RoomID);

            return (AppointmentID != null);

       }


       private bool _UpdateAppointments()
       {
        return clsAppointmentsData.UpdateAppointmentsByID(
this.AppointmentID, this.PatientID, this.DoctorID, this.Date, this.Status, this.RoomID       );
       }


       public static bool UpdateAppointmentsByID(
int? AppointmentID,int PatientID, int DoctorID, DateTime Date, byte Status, int RoomID          )
        {
        return clsAppointmentsData.UpdateAppointmentsByID(
AppointmentID, PatientID, DoctorID, Date, Status, RoomID);

        }


       public static clsAppointments? FindByAppointmentID(int? AppointmentID)

        {
            if (AppointmentID == null)
            {
                return null;
            }
            int PatientID = 0;
            int DoctorID = 0;
            DateTime Date = DateTime.Now;
            byte Status = default(byte);
            int RoomID = 0;
            bool IsFound = clsAppointmentsData.GetAppointmentsInfoByID(AppointmentID,
 ref PatientID,  ref DoctorID,  ref Date,  ref Status,  ref RoomID);

           if(IsFound)
               return new clsAppointments(
 AppointmentID,  PatientID,  DoctorID,  Date,  Status,  RoomID);
            else
                return  null;
        }


       public static DataTable? GetAllAppointments()
       {

        return clsAppointmentsData.GetAllAppointments();

       }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewAppointments())
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

        return clsAppointmentsData.DeleteAppointments(AppointmentID);

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


        public static DataTable? SearchData(enAppointmentsColumns enChose, string Data)
        {
            if(!SqlHelper.IsSafeInput(Data))
                return null;
            
            return clsAppointmentsData.SearchData(enChose.ToString(), Data);

        }        



    }
}
