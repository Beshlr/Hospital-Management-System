using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDataLayer
{
    public class clsRolesData
    {
        public static int AddNewRole(string RoleName, string RoleDescription, int Permissions)
        {
            int RoleID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert Into Roles(RoleName,RoleDescription,Permissions)
                            
                            Values:
                            (
                            @RoleName,                            
                            @RoleDescription,
                            @Permissions
                            )
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoleName", RoleName);
            command.Parameters.AddWithValue("@RoleDescription", RoleDescription);
            command.Parameters.AddWithValue("@Permissions", Permissions);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    RoleID = InsertedID;
                }

            }
            catch { }
            finally { connection.Close(); }

            return RoleID;
        }

        public static int GetRolePermissions(int RoleID)
        {
            int Permissions = -33;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select Permissions from Roles Where RoleID = @RoleID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RoleID", RoleID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                    Permissions = (int)result;

            }
            catch { Exception ex; }
            finally { connection.Close(); }

            return Permissions;
        }

        public static int GetRolePermissions(string RoleName)
        {
            int Permissions = -33;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select Permissions from Roles Where RoleName = @RoleName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RoleName", RoleName);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                    Permissions = (int)result;

            }
            catch { Exception ex; }
            finally { connection.Close(); }

            return Permissions;
        }

        public static bool UpdataRole(int RoleID,string RoleName, string RoleDescription, int Permissions)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update Doctors
                            Set
                            RoleName = @RoleName,
                            RoleDescription = @RoleDescription,
                            Permissions = @Permissions,
                            Where RoleID = @RoleID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoleName", RoleName);
            command.Parameters.AddWithValue("@RoleDescription", RoleDescription);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@RoleID", RoleID);


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
    
    
    }
}
