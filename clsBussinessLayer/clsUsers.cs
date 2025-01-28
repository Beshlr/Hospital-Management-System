using HospitalDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HospitalDataLayer;

namespace clsBussinessLayer
{
    public class clsUsers
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserEmail { get; set; }
        public int RoleID { get; set; }
        public bool IsActive {  get; set; }
        public enum enRole { Admin = 1,Doctor = 2, Receptionist = 3, Patient = 4}
        private enRole Role { get { return (enRole)RoleID; } }
        public string RoleName { 
            get
            {
                switch(Role)
                {
                    case enRole.Admin:
                        return "Admin";
                    case enRole.Doctor:
                        return "Doctor";
                    case enRole.Receptionist:
                        return "Receptionist";
                    case enRole.Patient:
                        return "Patient";
                }
                return "Admin";
            }

        }
        public enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode = enMode.AddNew;

        public clsUsers()
        {
            UserID = -1;
            UserName = "";
            Password = "";
            UserEmail = "";
            RoleID = -1;
            IsActive = true;
            _Mode = enMode.AddNew;
        }

        private clsUsers(int userID,string username,string password, int roleID,bool isActive,string userEmail)
        {
            UserID = userID;
            UserName = username;
            Password = password;
            UserEmail = userEmail;
            RoleID = roleID;
            IsActive = isActive;
            _Mode = enMode.Update;
        }

        private bool AddNewUser(string username, string password, enRole Role,bool isActive,string userEmail)
        {
            int UserID = clsUsersData.AddNewUser(username,password, (int)Role,isActive,userEmail);

            this.UserID = UserID;

            return UserID != -1;
        }
        
        private bool UpdateUser(int UserID)
        {
            return clsUsersData.UpdateUser(UserID, this.UserName,this.Password,this.RoleID,this.IsActive,this.UserEmail);
        }

        public static clsUsers Find(string Username)
        {
            string Password = "",UserEmail = "";
            int RoleID = -1,UserID = -1;
            bool isActive = false;

            bool IsFound = clsUsersData.FindUserInfoByUsername(ref UserID, Username,ref Password,ref RoleID,ref isActive,ref UserEmail);

            if (IsFound)
            {
                return new clsUsers(UserID, Username, Password, RoleID,isActive,UserEmail);
            }

            return null;
        }

        public static clsUsers Find(int UserID)
        {
            string Username = "", Password = "",UserEmail = "";
            int RoleID = -1;
            bool isActive = false;

            bool IsFound = clsUsersData.FindUserInfoByID(UserID,ref Username,ref Password,ref RoleID,ref isActive,ref UserEmail);

            if (IsFound)
            {
                return new clsUsers(UserID, Username, Password, RoleID,isActive,UserEmail);
            }

            return null;
        }

        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }

        public bool Save()
        {
            switch (this._Mode)
            {
                case enMode.AddNew:

                    if (AddNewUser(this.UserName,this.Password,this.Role,this.IsActive,this.UserEmail) == true)
                    {
                        this._Mode = enMode.Update;
                        return true;

                    }
                    return false;
                case enMode.Update:
                    return UpdateUser(this.UserID);

            }

            return false;
        }
    
        
        public static bool IsUsernameAndPasswordCorrect(string Username,string Password)
        {
            return clsUsersData.CheckUsernameAndPassword(Username, Password);
        }

        public static clsUsers FindByUsernameAndPassword(string Username,string Password)
        {
            int UserID = -1,RoleID = -1; bool IsActive = false;
            string UserEmail = "";
            if(IsUsernameAndPasswordCorrect(Username,Password))
            {
                clsUsersData.FindUserInfoByUsernameAndPassword(ref UserID, Username, Password, ref RoleID,ref IsActive,ref UserEmail);
                
                return new clsUsers(UserID,Username,Password,RoleID,IsActive, UserEmail);
            }

            return null;
        }

        public static bool IsUserExist(string Username)
        {
            return clsUsersData.IsUserExist(Username);
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUsersData.IsUserExist(UserID);
        }

        public static int GetUserRoleID(string Username)
        {
            return clsUsersData.GetUserRoleID(Username);
        }

        public static int GetUserRoleID(int UserID)
        {
            return clsUsersData.GetUserRoleID(UserID);
        }

        public static string GetUserEmail(string Username)
        {
            return clsUsersData.GetUserEmailByUsername(Username);
        }
    }

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

        public bool AddNewLogRecord(string action, int userID,DateTime date,string details)
        {
            this.LogID = clsUsersData.AddNewLog(action,userID,date,details);

            return (this.LogID != -1);
        }

        public DataTable GetAllLogRecords()
        {
            return clsUsersData.GetAllLogsRecords(); 
        }
    }
}
