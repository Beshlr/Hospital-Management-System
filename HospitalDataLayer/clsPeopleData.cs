using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace HospitalDataLayer
{
    public class clsPeopleData
    {
        public static int AddNewPerson(string FirstName, string SecondName, string LastName, DateTime DateOfBirth,
                                         byte Gendor, string Address, string PhoneNumber,string ImagePath)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert Into People(
                            FirstName,
                            SecondName,
                            ThirdName,
                            LastName,
                            DateOfBirth, 
                            Age,
                            Gendor,
                            Address,
                            PhonNumber,
                            ImagePath)
                            
                            Values:
                            (
                            @FirstName,
                            @SecondName,
                            @ThirdName,
                            @LastName,
                            @DateOfBirth,
                            @Age,
                            @Gendor,
                            @Address,
                            @PhonNumber,
                            @ImagePath)
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@PhonNumber", PhoneNumber);
            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    PersonID = InsertedID;
                }

            }
            catch { }
            finally { connection.Close(); }

            return PersonID;
        }

        public static bool DeletePerson(int PersonID)
        {
            bool IsDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Delete From People Where PersonID = @PersonID";
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

        public static bool UpdatePerson(int PersonID,string FirstName, string SecondName, string LastName, DateTime DateOfBirth,
                                       byte Gendor, string Address, string PhoneNumber, string ImagePath)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update People
                            Set
                            FirstName = @FirstName,
                            SecondName = @SecondName,
                            LastName = @LastName,
                            DateOfBirth = @DateOfBirth,
                            Age = @Age,
                            Gendor = @Gendor,
                            Address = @Address,
                            PhonNumber = @PhonNumber,
                            ImagePath = @ImagePath
                            Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
           

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@PhonNumber", PhoneNumber);
            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

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
    
        public static bool FindPersonInfoByID(int PersonID, ref string FirstName, ref string SecondName, ref string LastName,
                                         ref DateTime DateOfBirth,ref  byte Gendor,ref  string Address,ref  string PhoneNumber,ref  string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From People Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                   
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    PhoneNumber = (string)reader["PhoneNumber"];

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";

                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return IsFound;
        }
    
        public static DataTable GetAllPersons()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From People";
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

}

