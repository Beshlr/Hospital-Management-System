using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;

namespace HospitalDataLayer
{
    public class clsUsersData
    {

        public static int AddNewUser(string Username, string Password, int RoleID,bool IsActive,string UserEmail,string ImagePath)
        {
            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert Into Users(
                           Username,Password,UserEmail,RoleID,IsActive,ImagePath)
                            
                            Values
                            (
                            @Username,
                            @Password,
                            @UserEmail,
                            @RoleID,
                            @IsActive,
                            @ImagePath
                            )
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@RoleID", RoleID);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@UserEmail", UserEmail);
            if (ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    UserID = InsertedID;
                }

            }
            catch { }
            finally { connection.Close(); }

            return UserID;
        }

        public static bool DeleteUser(int UserID)
        {
            bool IsDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Delete From Users Where UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                IsDeleted = (result > 0);

            }
            catch { }
            finally { connection.Close(); }

            return IsDeleted;
        }

        public static bool UpdateUser(int UserID, string Username, string Password, int RoleID,bool IsActive, string UserEmail,string ImagePath)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update Users
                            Set
                            Username = @Username,
                            Password = @Password,
                            RoleID = @RoleID,
                            IsActive = @IsActive,
                            UserEmail = @UserEmail,
                            ImagePath = @ImagePath
                            Where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@RoleID", RoleID);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@UserEmail", UserEmail);
            if(ImagePath != null)
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
            command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

           
            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                IsUpdated = (result > 0);

            }
            catch { }
            finally { connection.Close(); }

            return IsUpdated;
        }

        public static bool FindUserInfoByID(int UserID, ref string Username,ref string Password,ref int RoleID,ref bool IsActive, ref string UserEmail,ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Users Where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    Username = (string)reader["Username"];
                    Password = (string)reader["Password"];
                    RoleID = (int)reader["RoleID"];
                    IsActive = (bool)reader["IsActive"];
                    UserEmail = (string)reader["UserEmail"];
                    if (reader["ImagePath"] != null)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = null;
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return IsFound;
        }
        
        public static bool FindUserInfoByUsername(ref int UserID, string Username,ref string Password,ref int RoleID,ref bool IsActive,ref string UserEmail,ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Users Where Username COLLATE Latin1_General_BIN = @Username";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];
                    Password = (string)reader["Password"];
                    RoleID = (int)reader["RoleID"];
                    IsActive = (bool)reader["IsActive"];
                    UserEmail = (string)reader["UserEmail"];
                    if (reader["ImagePath"] != null)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = null;

                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return IsFound;
        }
        
        public static bool FindUserInfoByUsernameAndPassword(ref int UserID, string Username,string Password,ref int RoleID,ref bool IsActive,ref string UserEmail,ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Users Where Username = @Username AND Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    UserID = (int)reader["UserID"];
                    RoleID = (int)reader["RoleID"];
                    IsActive = (bool)reader["IsActive"];
                    UserEmail = (string)reader["UserEmail"];
                    if (reader["ImagePath"] != null)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = null;
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return IsFound;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Users";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch { }
            finally { connection.Close(); }

            return dt;
        }

        public static bool CheckUsernameAndPassword(string Username, string Password)
        {
            bool IsCorrect = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select 1 From Users Where Username COLLATE Latin1_General_BIN = @Username
                            AND                        Password COLLATE Latin1_General_BIN = @Password";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                IsCorrect = (result != null);
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return IsCorrect;
        }
    
        public static int GetUserRoleID(int UserID)
        {
            int RoleID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select RoleID From Users Where UserID = @UserID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                    RoleID = (int)result;
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return RoleID;
        }
    
        public static int GetUserRoleID(string Username)
        {
            int RoleID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select RoleID From Users Where Username = @Username ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                    RoleID = (int)result;
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return RoleID;
        }
    
        public static bool IsUserExist(int UserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select Found = 1 From Users Where UserID = @UserID";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                IsFound = (result != null);
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return IsFound;
        }
        
        public static bool IsUserExist(string Username)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select Found = 1 From Users Where Username = @Username";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                IsFound = (result != null);
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return IsFound;
        }
    
        public static int GetUserPermissions(int UserID)
        {
            return clsRolesData.GetRolePermissions(GetUserRoleID(UserID));
        }
        
        public static int AddNewLog(string Action, int UserID, DateTime date, string Details)
        {
            int LogID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert Into Logs(
                           Action,UserID,Date,Details)
                            
                            Values
                            (
                            @Action,
                            @UserID,
                            @date,
                            @Details
                            )
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Action", Action);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@date", date);
            if (Details != null && Details.Length > 0)
                command.Parameters.AddWithValue("@Details", Details);
            else
                command.Parameters.AddWithValue("@Details", DBNull.Value);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    LogID = InsertedID;
                }

            }
            catch { }
            finally { connection.Close(); }

            return LogID;
        }

        public static DataTable GetAllLogsRecords()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Logs";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch { }
            finally { connection.Close(); }

            return dt;
        }

        public static string GetUserEmailByUsername(string username)
        {
            string Email = "";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select UserEmail From Users Where Username = @Username";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                    Email = (string)result;
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return Email;
        }
        
        public static bool ChangePasswordForUser(string Username, string NewPassword)
        {
            bool Changed = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update Users
                            Set
                            Password = @NewPassword
                            Where Username = @Username";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@NewPassword", NewPassword);

            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();

                Changed = (result > 0);
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return Changed;
        }
    
        public static DataTable GetAllUserNotification(int UserID)
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Notifications Where UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch { }
            finally { connection.Close(); }

            return dt;
        }
    
        public static int AddNewNotification(int UserID,string Title,DateTime Date,string Notes)
        {
            int NotifyID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert Into Notifications(
                           NotificationTitle,NotificationDate,UserID,Notes,OpenningSatus)
                            
                            Values
                            (
                            @Title,
                            @Date,
                            @UserID,
                            @Notes,
                            @OpenningStatus
                            
                            )
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@UserID", UserID);
            if (Notes != null && Notes.Length > 0)
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            command.Parameters.AddWithValue("@OpenningStatus", false);

            
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    NotifyID = InsertedID;
                }

            }
            catch { }
            finally { connection.Close(); }


            return NotifyID;
        }
    
        public static bool UpdateNotificationOpenningStatus(int NotificationID,bool OpenningStatus)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update Notifications
                            Set
                            OpenningStatus = @OpenningStatus
                            Where NotificationID = @NotificationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@OpenningStatus", OpenningStatus);
            
            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                IsUpdated = (result > 0);

            }
            catch { }
            finally { connection.Close(); }

            return IsUpdated;
        }

        public static bool FindNotification(int NotificationID, ref string Title, ref string Notes, ref DateTime Date, ref bool OpenningStatus, ref int UserID)
        {
            bool Found = false;

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Notifications Where NotificationID = @NotificationID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NotificationID", NotificationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    UserID = (int)reader["UserID"];
                    Title = (string)reader["NotificationTitle"];
                    OpenningStatus = (bool)reader["OpenningStatus"];
                    Date = (DateTime)reader["NotificationDate"];
                    if (reader["Notes"] != null)
                        Notes = (string)reader["Notes"];
                    else
                        Notes = null;
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            
            return Found;
        }
    }
}
