using HospitalDataLayer;
using System;
using System.Data;

namespace clsBussinessLayer
{
    public class clsLogs
    {
        public int LogID { get; set; }
        public string Action { get; set; }
        public int UserID { get; set; }
        public clsUsers UserInfo { get; set; }
        public DateTime Date { get; set; }
        public string Details { get; set; }

        public clsLogs()
        {
            this.LogID = -1;
            this.Action = "";
            this.UserID = -1;
            this.Date = DateTime.Now;
            this.Details = "";
        }

        private clsLogs(int logID, string action, int userID, DateTime date, string details)
        {
            this.LogID = logID;
            this.Action = action;
            this.UserID = userID;
            this.UserInfo = clsUsers.Find(this.UserID);
            this.Date = date;
            this.Details = details;
        }

        public static bool AddNewLogRecord(string action, int userID,DateTime date,string details)
        {
            int LogID = clsUsersData.AddNewLog(action,userID,date,details);

            return (LogID != -1);
        }

        public static DataTable GetAllLogRecords()
        {
            return clsUsersData.GetAllLogsRecords(); 
        }
    }
}
