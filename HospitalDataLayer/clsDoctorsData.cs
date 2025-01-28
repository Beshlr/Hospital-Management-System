using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HospitalDataLayer
{
    public class clsDoctorsData
    {
        public static int AddNewDoctor(int PersonID, int SpecializationID, int WorkingHours)
        {
            int DoctorID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert Into Doctors(
                           Username,Password,RoleID)
                            
                            Values:
                            (
                            @PersonID,
                            @SpecializationID,
                            @WorkingHours
                            )
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@SpecializationID", SpecializationID);
            command.Parameters.AddWithValue("@WorkingHours", WorkingHours);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    DoctorID = InsertedID;
                }

            }
            catch { }
            finally { connection.Close(); }

            return DoctorID;
        }
    
        public static bool DeleteDoctorByDoctorID(int DoctorID)
        {
            bool IsDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Delete From Doctors Where DoctorID = @DoctorID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DoctorID", DoctorID);

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
    
        public static bool DeleteDoctorByPersonID(int PersonID)
        {
            bool IsDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Delete From Doctors Where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool UpdateDoctorByDoctorID(int DoctorID,int SpecializationID, int WorkingHours)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update Doctors
                            Set
                            SpecializationID = @SpecializationID
                            WorkingHours = @WorkingHours
                            Where DoctorID = @DoctorID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DoctorID", DoctorID);
            command.Parameters.AddWithValue("@SpecializationID", SpecializationID);
            command.Parameters.AddWithValue("@WorkingHours", WorkingHours);

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
    
        public static bool UpdateDoctorByPersonID(int PersonID,int SpecializationID, int WorkingHours)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update Doctors
                            Set
                            SpecializationID = @SpecializationID
                            WorkingHours = @WorkingHours
                            Where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@SpecializationID", SpecializationID);
            command.Parameters.AddWithValue("@WorkingHours", WorkingHours);

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
    
        public static bool GetDoctorInfoByDoctorID(int DoctorID, ref int PersonID,ref  int SpecializationID,ref int WorkingHours)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Doctors Where DoctorID = @DoctorID";

            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@DoctorID", DoctorID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)reader["PersonID"];
                    SpecializationID = (int)reader["SpecializationID"];
                    WorkingHours = (int)reader["WorkingHours"];
                }

                reader.Close();
            }
            catch { Exception ex; }
            finally { connection.Close(); }

            return IsFound;
        }
    
        public static bool GetDoctorInfoByPersonID(ref int DoctorID, int PersonID,ref  int SpecializationID,ref int WorkingHours)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Doctors Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    IsFound = true;
                    DoctorID = (int)reader["DoctorID"];
                    SpecializationID = (int)reader["SpecializationID"];
                    WorkingHours = (int)reader["WorkingHours"];
                }

                reader.Close();
            }
            catch { Exception ex; }
            finally { connection.Close(); }

            return IsFound;
        }
    
        public static bool IsDoctorInThisSpecialization(int DoctorID, int SpecializationID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select Found = 1 From Doctors Where DoctorID = @DoctorID AND SpecializationID = @SpecializationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DoctorID", DoctorID);
            command.Parameters.AddWithValue("@SpecializationID", SpecializationID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                IsFound = (result != null);

            }
            catch { Exception ex; }
            finally { connection.Close(); }

            return IsFound;
        }
    
        public static DataTable GetAllDoctors()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Doctors";
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
    
    }

    public class clsSpecializationsData
    {
        public static int AddNewSpecialization(string SpecializationName, string SpecializationDescription, int NumOfDoctors)
        {
            int SpecializationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert Into Specializations(
                           SpecializationName,SpecializationDescr,NumOfDoctors)
                            
                            Values:
                            (
                            @SpecializationName,
                            @SpecializationDescription,
                            @NumOfDoctors,
                            )
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SpecializationName", SpecializationName);
            command.Parameters.AddWithValue("@SpecializationDescription", SpecializationDescription);
            command.Parameters.AddWithValue("@NumOfDoctors", NumOfDoctors);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    SpecializationID = InsertedID;
                }

            }
            catch { }
            finally { connection.Close(); }

            return SpecializationID;
        }
    
        public static bool UpdateSpecialization(int SpecializationID, string SpecializationName,string SpecializationDescription, int NumOfDoctors)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update Specializations
                            Set
                            SpecializationName = @SpecializationName
                            SpecializationDescription = @SpecializationDescription
                            NumOfDoctors = @NumOfDoctors
                            Where SpecializationID = @SpecializationID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SpecializationName", SpecializationName);
            command.Parameters.AddWithValue("@SpecializationDescription", SpecializationDescription);
            command.Parameters.AddWithValue("@NumOfDoctors", NumOfDoctors);
            command.Parameters.AddWithValue("@SpecializationID", SpecializationID);

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
    
        public static int GetNumOfDoctorsInASpecialization(int SpecializationID)
        {
            int NumOfDoctors = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select NumOfDoctors From Specializations Where SpecializationID = @SpecializationID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SpecializationID", SpecializationID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                NumOfDoctors = (int)result ;

            }
            catch { }
            finally { connection.Close(); }

            return NumOfDoctors;

        }
    
        public static DataTable GetAllSpecializationsRecords()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Specializations";
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

        public static bool GetSpecializationInfo(int SpecializationID, ref string SpecializationName, ref string SpecializationDescr, ref int NumOfDoctors)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Specializations Where SpecializationID = @SpecializationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SpecializationID", SpecializationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    SpecializationName = (string)reader["SpecializationName"];
                    SpecializationDescr = (string)reader["SpecializationDescr"];
                    NumOfDoctors = (int)reader["NumOfDoctors"];
                }

                reader.Close();
            }
            catch { Exception ex; }
            finally { connection.Close(); }

            return IsFound;
        }
    
    }
}
