
using System;
using System.Data.SqlClient;
using System.Data;
using Hospital_DataAccess;

namespace Hospital_DataLayer
{
    public class clsPrescriptionData
    {
        #nullable enable

        public static bool GetPrescriptionInfoByID(int? PrescriptionID , ref int PatientID, ref int DoctorID, ref DateTime IssueDate)
            {
                bool isFound = false;

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Prescription WHERE PrescriptionID = @PrescriptionID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        { 
                            if (reader.Read())
                            {

                                // The record was found
                                isFound = true;

                                PatientID = (int)reader["PatientID"];
                                DoctorID = (int)reader["DoctorID"];
                                IssueDate = (DateTime)reader["IssueDate"];



                            }
                        }

                    }
                }
                return isFound;

            }

        public static DataTable GetAllPrescription()
{
    DataTable dt = new DataTable();

    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
    {
        string query = "SELECT * FROM Prescription";

        using (SqlCommand command = new SqlCommand(query, connection))
        {

            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                    dt.Load(reader);
            }
        }
    }
    return dt;

}

         public static int? AddNewPrescription(int PatientID, int DoctorID, DateTime IssueDate)
        {
            int? PrescriptionID = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Insert Into Prescription ([PatientID],[DoctorID],[IssueDate])
                            Values (@PatientID,@DoctorID,@IssueDate)
                            SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientID", PatientID);
                    command.Parameters.AddWithValue("@DoctorID", DoctorID);
                    command.Parameters.AddWithValue("@IssueDate", IssueDate);


                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        PrescriptionID = insertedID;
                    }
                }

            }
            return PrescriptionID;

        }


         public static bool UpdatePrescriptionByID(int? PrescriptionID, int PatientID, int DoctorID, DateTime IssueDate)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Update Prescription
                                    set 
                                         [PatientID] = @PatientID,
                                         [DoctorID] = @DoctorID,
                                         [IssueDate] = @IssueDate
                                  where [PrescriptionID]= @PrescriptionID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
                    command.Parameters.AddWithValue("@PatientID", PatientID);
                    command.Parameters.AddWithValue("@DoctorID", DoctorID);
                    command.Parameters.AddWithValue("@IssueDate", IssueDate);


                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }

            }

            return (rowsAffected > 0);
        }


        public static bool DeletePrescription(int PrescriptionID)
{
    int rowsAffected = 0;

    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
    {
        string query = @"Delete Prescription 
                        where PrescriptionID = @PrescriptionID";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);


            connection.Open();
            
            rowsAffected = command.ExecuteNonQuery();


        }

    }
    
    return (rowsAffected > 0);

}
        
        public static DataTable SearchData(string ColumnName, string Data)
{
    DataTable dt = new DataTable();

    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
    {
        string query = $@"select * from Prescription
                    where {ColumnName} Like '' + @Data + '%';";

        using (SqlCommand Command = new SqlCommand(query, connection))
        {
            Command.Parameters.AddWithValue("@Data", Data);


            connection.Open();

            using (SqlDataReader reader = Command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
        }
        
    }

    return dt;
}
    }
}
