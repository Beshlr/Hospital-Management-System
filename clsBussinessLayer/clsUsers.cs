using System;
using HospitalDataLayer;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
        public string ImagePath;
        public enum enRole { Admin = 1, Secretary = 2, Doctor = 3, Patient = 4}
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
                    case enRole.Secretary:
                        return "Secretary";
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
            ImagePath = "";
            RoleID = -1;
            IsActive = true;
            _Mode = enMode.AddNew;
        }

        private clsUsers(int userID,string username,string password, int roleID,bool isActive,string userEmail, string imagePath)
        {
            UserID = userID;
            UserName = username;
            Password = password;
            UserEmail = userEmail;
            ImagePath = imagePath;
            RoleID = roleID;
            IsActive = isActive;
            _Mode = enMode.Update;
        }

        private bool AddNewUser(string username, string password, enRole Role,bool isActive,string userEmail,string ImagePath)
        {
            int UserID = clsUsersData.AddNewUser(username,password, (int)Role,isActive,userEmail,ImagePath);

            this.UserID = UserID;

            return UserID != -1;
        }
        
        private bool UpdateUser(int UserID)
        {
            return clsUsersData.UpdateUser(UserID, this.UserName,this.Password,this.RoleID,this.IsActive,this.UserEmail,this.ImagePath);
        }

        public static clsUsers Find(string Username)
        {
            string Password = null,UserEmail = null,ImagePath = null;
            int RoleID = -1,UserID = -1;
            bool isActive = false;

            bool IsFound = clsUsersData.FindUserInfoByUsername(ref UserID, Username,ref Password,ref RoleID,ref isActive,ref UserEmail,ref ImagePath);

            if (IsFound)
            {
                return new clsUsers(UserID, Username, Password, RoleID,isActive,UserEmail,ImagePath);
            }

            return null;
        }

        public static clsUsers Find(int UserID)
        {
            string Username = null, Password = null, UserEmail = null, ImagePath = null;
            int RoleID = -1;
            bool isActive = false;

            bool IsFound = clsUsersData.FindUserInfoByID(UserID, ref Username, ref Password, ref RoleID, ref isActive, ref UserEmail, ref ImagePath);

            if (IsFound)
            {
                return new clsUsers(UserID, Username, Password, RoleID, isActive, UserEmail, ImagePath);
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

                    if (AddNewUser(this.UserName,this.Password,this.Role,this.IsActive,this.UserEmail,this.ImagePath) == true)
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

        public static clsUsers FindByUsernameAndPassword(string Username, string Password)
        {
            int UserID = -1, RoleID = -1;
            bool IsActive = false;
            string UserEmail = "", ImagePath = "";

            if (IsUsernameAndPasswordCorrect(Username, Password))
            {
                clsUsersData.FindUserInfoByUsernameAndPassword(ref UserID, Username, Password, ref RoleID, ref IsActive, ref UserEmail, ref ImagePath);

                return new clsUsers(UserID, Username, Password, RoleID, IsActive, UserEmail, ImagePath);
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

    public class clsNotifications
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date {  get; set; }
        public string Notes { get; set; }
        public bool OpenningStatus {  get; set; }
        public enum enMode { enAddNew = 0, enUpdate = 1}
        private enMode _Mode = enMode.enAddNew;
        public clsUsers UserInfo {  get; set; }
        private clsNotifications(int iD, string title,int UserID, DateTime date, string notes)
        {
            ID = iD;
            Title = title;
            Date = date;
            Notes = notes;
            UserInfo = clsUsers.Find(UserID);

            _Mode = enMode.enUpdate;
        }

        public clsNotifications()
        {
            ID = -1;
            Title = "";
            Date = DateTime.MinValue;
            Notes = "";

            _Mode = enMode.enAddNew;
        }

        private bool AddNewNotification()
        {
            this.ID = clsUsersData.AddNewNotification(this.UserInfo.UserID, this.Title, this.Date, this.Notes);

            return this.ID != -1;
        }

        public static bool UpdateNotificationOpenningStatus(int NotifyID , bool OpenningStatus)
        {

            return clsUsersData.UpdateNotificationOpenningStatus(NotifyID, OpenningStatus);
        }

        private bool UpdateNotification()
        {
            return false;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.enAddNew:
                    {
                        if (AddNewNotification())
                        {
                            _Mode = enMode.enUpdate;
                            return true;
                        }
                        return false;
                    }
                case enMode.enUpdate:
                    {
                        return UpdateNotification();
                    }

            }

            return false;
        }

        public static clsNotifications[] GetAllNotificationsForUser(int UserID)
        {
            DataTable dt1 = new DataTable();

            dt1 = clsUsersData.GetAllUserNotification(UserID);

            clsNotifications[] notifications = new clsNotifications[dt1.Rows.Count];

            int Counter = 0;

            foreach (DataRow row in dt1.Rows)
            {
                int NotifyID = -1;
                foreach(DataColumn column in dt1.Columns)
                {
                    if(column.ColumnName == "NotificationID")
                        NotifyID = (int)row[column];
                }

                notifications[0] = clsNotifications.Find(NotifyID);

                Counter++;
            }

            return notifications;
        }

        public static clsNotifications Find(int NotificationID)
        {
            string Title = "",Notes = ""; DateTime Date = DateTime.Now;
            bool OpenningStatus = false; int UserID = -1;

            clsUsersData.FindNotification(NotificationID, ref Title, ref Notes, ref Date, ref OpenningStatus, ref UserID);

            return new clsNotifications(NotificationID,Title, UserID, Date, Notes);
        }
    }
}
