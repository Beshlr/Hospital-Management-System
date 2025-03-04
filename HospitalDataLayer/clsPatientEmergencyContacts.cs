
using System;
using System.Data.SqlClient;
using System.Data;
using Hospital_DataAccess;

namespace Hospital_DataLayer
{
    public class clsPatientEmergencyContactsData
    {
        #nullable enable

        public static bool GetPatientEmergencyContactsInfoByID(int? EmergencyContactID , ref string ContactName, ref string ContactFirstPhoneNO, ref string? ContactSecondPhoneNO, ref string? RelationshipWithEmergencyContact)
            {
                bool isFound = false;

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM PatientEmergencyContacts WHERE EmergencyContactID = @EmergencyContactID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmergencyContactID", EmergencyContactID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        { 
                            if (reader.Read())
                            {

                                // The record was found
                                isFound = true;

                                ContactName = (string)reader["ContactName"];
                                ContactFirstPhoneNO = (string)reader["ContactFirstPhoneNO"];
                                ContactSecondPhoneNO = reader["ContactSecondPhoneNO"] != DBNull.Value ? reader["ContactSecondPhoneNO"].ToString() : null;
                                RelationshipWithEmergencyContact = reader["RelationshipWithEmergencyContact"] != DBNull.Value ? reader["RelationshipWithEmergencyContact"].ToString() : null;



                            }
                        }

                    }
                }
                return isFound;

            }

        public static DataTable GetAllPatientEmergencyContacts()
{
    DataTable dt = new DataTable();

    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
    {
        string query = "SELECT * FROM PatientEmergencyContacts";

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

         public static int? AddNewPatientEmergencyContacts(string ContactName, string ContactFirstPhoneNO, string? ContactSecondPhoneNO, string? RelationshipWithEmergencyContact)
        {
            int? EmergencyContactID = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Insert Into PatientEmergencyContacts ([ContactName],[ContactFirstPhoneNO],[ContactSecondPhoneNO],[RelationshipWithEmergencyContact])
                            Values (@ContactName,@ContactFirstPhoneNO,@ContactSecondPhoneNO,@RelationshipWithEmergencyContact)
                            SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ContactName", ContactName);
                    command.Parameters.AddWithValue("@ContactFirstPhoneNO", ContactFirstPhoneNO);
                    command.Parameters.AddWithValue("@ContactSecondPhoneNO", ContactSecondPhoneNO ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@RelationshipWithEmergencyContact", RelationshipWithEmergencyContact ?? (object)DBNull.Value);


                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        EmergencyContactID = insertedID;
                    }
                }

            }
            return EmergencyContactID;

        }


         public static bool UpdatePatientEmergencyContactsByID(int? EmergencyContactID, string ContactName, string ContactFirstPhoneNO, string? ContactSecondPhoneNO, string? RelationshipWithEmergencyContact)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Update PatientEmergencyContacts
                                    set 
                                         [ContactName] = @ContactName,
                                         [ContactFirstPhoneNO] = @ContactFirstPhoneNO,
                                         [ContactSecondPhoneNO] = @ContactSecondPhoneNO,
                                         [RelationshipWithEmergencyContact] = @RelationshipWithEmergencyContact
                                  where [EmergencyContactID]= @EmergencyContactID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmergencyContactID", EmergencyContactID);
                    command.Parameters.AddWithValue("@ContactName", ContactName);
                    command.Parameters.AddWithValue("@ContactFirstPhoneNO", ContactFirstPhoneNO);
                    command.Parameters.AddWithValue("@ContactSecondPhoneNO", ContactSecondPhoneNO ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@RelationshipWithEmergencyContact", RelationshipWithEmergencyContact ?? (object)DBNull.Value);


                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }

            }

            return (rowsAffected > 0);
        }


        public static bool DeletePatientEmergencyContacts(int EmergencyContactID)
{
    int rowsAffected = 0;

    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
    {
        string query = @"Delete PatientEmergencyContacts 
                        where EmergencyContactID = @EmergencyContactID";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@EmergencyContactID", EmergencyContactID);


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
        string query = $@"select * from PatientEmergencyContacts
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
