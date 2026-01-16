using HospitalDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBussinessLayer
{
    public class clsRooms
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int  RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string Floor { get; set; }
        public string RoomType { get; set; }
        public string BedCount { get; set; }
        public bool IsOccupied { get; set; }
        public byte AvailabilityStatus { get; set; }
        public decimal DailyRate { get; set; }


        public clsRooms()
        {
            this.RoomID = -1;
            this.RoomNumber = "";
            this.Floor = "";
            this.RoomType = "";
            this.BedCount = "";
            this.IsOccupied = false;
            this.AvailabilityStatus = default(byte);
            this.DailyRate = 0m;
            Mode = enMode.AddNew;
        }


        private clsRooms(
int  RoomID, string RoomNumber, string Floor, string RoomType, string BedCount, bool IsOccupied, byte AvailabilityStatus, decimal DailyRate)
        {
            this.RoomID = RoomID;
            this.RoomNumber = RoomNumber;
            this.Floor = Floor;
            this.RoomType = RoomType;
            this.BedCount = BedCount;
            this.IsOccupied = IsOccupied;
            this.AvailabilityStatus = AvailabilityStatus;
            this.DailyRate = DailyRate;
            Mode = enMode.Update;
        }


        private bool _AddNewRooms()
        {
            this.RoomID = clsRoomsData.AddNewRooms(
    this.RoomNumber, this.Floor, this.RoomType, this.BedCount, this.IsOccupied, this.AvailabilityStatus, this.DailyRate);

            return (this.RoomID != -1);

        }


        public static bool AddNewRooms(
 ref int  RoomID, string RoomNumber, string Floor, string RoomType, string BedCount, bool IsOccupied, byte AvailabilityStatus, decimal DailyRate)
        {
            RoomID = clsRoomsData.AddNewRooms(
    RoomNumber, Floor, RoomType, BedCount, IsOccupied, AvailabilityStatus, DailyRate);

            return (RoomID != -1);

        }


        private bool _UpdateRooms()
        {
            return clsRoomsData.UpdateRoomsByID(
    this.RoomID, this.RoomNumber, this.Floor, this.RoomType, this.BedCount, this.IsOccupied, this.AvailabilityStatus, this.DailyRate);
        }


        public static bool UpdateRoomsByID(
 int  RoomID, string RoomNumber, string Floor, string RoomType, string BedCount, bool IsOccupied, byte AvailabilityStatus, decimal DailyRate)
        {
            return clsRoomsData.UpdateRoomsByID(
    RoomID, RoomNumber, Floor, RoomType, BedCount, IsOccupied, AvailabilityStatus, DailyRate);

        }


        public static clsRooms  FindByRoomID(int  RoomID)

        {
            if (RoomID == -1)
            {
                return null;
            }
            string RoomNumber = "";
            string Floor = "";
            string RoomType = "";
            string BedCount = "";
            bool IsOccupied = false;
            byte AvailabilityStatus = default(byte);
            decimal DailyRate = 0m;
            bool IsFound = clsRoomsData.GetRoomsInfoByID(RoomID,
 ref RoomNumber, ref Floor, ref RoomType, ref BedCount, ref IsOccupied, ref AvailabilityStatus, ref DailyRate);

            if (IsFound)
                return new clsRooms(
  RoomID, RoomNumber, Floor, RoomType, BedCount, IsOccupied, AvailabilityStatus, DailyRate);
            else
                return null;
        }


        public static DataTable  GetAllRooms()
        {

            return clsRoomsData.GetAllRooms();

        }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRooms())
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
            AvailabilityStatus,
            DailyRate
        }


        public static DataTable  SearchData(enRoomsColumns enChose, string Data)
        {
            if (!SqlHelper.IsSafeInput(Data))
                return null;

            return clsRoomsData.SearchData(enChose.ToString(), Data);

        }

        public static int GetRoomIDByRoomNO(string roomNumber)
        {
            if (roomNumber == "")
            {
                return -1;
            }
            int RoomID = -1;
            
            bool IsFound = clsRoomsData.GetRoomIDByRoomNumber(ref RoomID,roomNumber);

            if (IsFound)
                return RoomID;
            else
                return -1;
        }

        

        public static List<string> GetAllRoomsNumbers()
        {
            DataTable dt = clsRoomsData.GetAllRoomsNumbers();
            List<string> roomNumbers = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                roomNumbers.Add(row["RoomNumber"].ToString());
            }

            return roomNumbers;
        }
    
        public static bool ChangeRoomReservation(int RoomID, bool Reservate)
        {
            return clsRoomsData.UpdateRoomReservation(RoomID, Reservate);
        }
        
        
    }
}
