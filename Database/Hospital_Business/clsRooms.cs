
using System;
using System.Data;
using Hospital_DataLayer;

namespace Hospital_BusinessLayer
{
    public class clsRooms
    {
        #nullable enable

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string Floor { get; set; }
        public string RoomType { get; set; }
        public string BedCount { get; set; }
        public bool IsOccupied { get; set; }
        public int OccupiedBy { get; set; }
        public clsPatients? PatientsInfo { get; set; }
        public byte AvailabilityStatus { get; set; }
        public decimal DailyRate { get; set; }


        public clsRooms()
        {
            this.RoomID = null;
            this.RoomID = null;
            this.RoomNumber = "";
            this.Floor = "";
            this.RoomType = "";
            this.BedCount = "";
            this.IsOccupied = false;
            this.OccupiedBy = 0;
            this.AvailabilityStatus = default(byte);
            this.DailyRate = 0m;
            Mode = enMode.AddNew;
        }


        private clsRooms(
int? RoomID,string RoomNumber, string Floor, string RoomType, string BedCount, bool IsOccupied, int OccupiedBy, byte AvailabilityStatus, decimal DailyRate          )
        {
            this.RoomID = RoomID;
            this.RoomNumber = RoomNumber;
            this.Floor = Floor;
            this.RoomType = RoomType;
            this.BedCount = BedCount;
            this.IsOccupied = IsOccupied;
            this.OccupiedBy = OccupiedBy;
            this.PatientsInfo = clsPatients.FindByPatientID(OccupiedBy);
            this.AvailabilityStatus = AvailabilityStatus;
            this.DailyRate = DailyRate;
            Mode = enMode.Update;
        }


       private bool _AddNewRooms()
       {
        this.RoomID = clsRoomsData.AddNewRooms(
this.RoomNumber, this.Floor, this.RoomType, this.BedCount, this.IsOccupied, this.OccupiedBy, this.AvailabilityStatus, this.DailyRate);

            return (this.RoomID != null);

       }


       public static bool AddNewRooms(
ref int? RoomID,string RoomNumber, string Floor, string RoomType, string BedCount, bool IsOccupied, int OccupiedBy, byte AvailabilityStatus, decimal DailyRate)
        {
        RoomID = clsRoomsData.AddNewRooms(
RoomNumber, Floor, RoomType, BedCount, IsOccupied, OccupiedBy, AvailabilityStatus, DailyRate);

            return (RoomID != null);

       }


       private bool _UpdateRooms()
       {
        return clsRoomsData.UpdateRoomsByID(
this.RoomID, this.RoomNumber, this.Floor, this.RoomType, this.BedCount, this.IsOccupied, this.OccupiedBy, this.AvailabilityStatus, this.DailyRate       );
       }


       public static bool UpdateRoomsByID(
int? RoomID,string RoomNumber, string Floor, string RoomType, string BedCount, bool IsOccupied, int OccupiedBy, byte AvailabilityStatus, decimal DailyRate          )
        {
        return clsRoomsData.UpdateRoomsByID(
RoomID, RoomNumber, Floor, RoomType, BedCount, IsOccupied, OccupiedBy, AvailabilityStatus, DailyRate);

        }


       public static clsRooms? FindByRoomID(int? RoomID)

        {
            if (RoomID == null)
            {
                return null;
            }
            string RoomNumber = "";
            string Floor = "";
            string RoomType = "";
            string BedCount = "";
            bool IsOccupied = false;
            int OccupiedBy = 0;
            byte AvailabilityStatus = default(byte);
            decimal DailyRate = 0m;
            bool IsFound = clsRoomsData.GetRoomsInfoByID(RoomID,
 ref RoomNumber,  ref Floor,  ref RoomType,  ref BedCount,  ref IsOccupied,  ref OccupiedBy,  ref AvailabilityStatus,  ref DailyRate);

           if(IsFound)
               return new clsRooms(
 RoomID,  RoomNumber,  Floor,  RoomType,  BedCount,  IsOccupied,  OccupiedBy,  AvailabilityStatus,  DailyRate);
            else
                return  null;
        }


       public static DataTable? GetAllRooms()
       {

        return clsRoomsData.GetAllRooms();

       }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewRooms())
                    {
                        Mode = enMode.Update;
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateRooms();

            }
        
            return false;
        }



       public static bool DeleteRooms(int RoomID)
       {

        return clsRoomsData.DeleteRooms(RoomID);

       }


        public enum enRoomsColumns
         {
            RoomID,
            RoomNumber,
            Floor,
            RoomType,
            BedCount,
            IsOccupied,
            OccupiedBy,
            AvailabilityStatus,
            DailyRate
         }


        public static DataTable? SearchData(enRoomsColumns enChose, string Data)
        {
            if(!SqlHelper.IsSafeInput(Data))
                return null;
            
            return clsRoomsData.SearchData(enChose.ToString(), Data);

        }        



    }
}
