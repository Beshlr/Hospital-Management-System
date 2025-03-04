
using System;
using System.Data.SqlClient;
using System.Data;
using Hospital_DataAccess;

namespace Hospital_DataLayer
{
    public class clsLogsData
    {
        #nullable enable

        public static bool GetLogsInfoByID(int? LogID , ref string Action, ref int UserID, ref int? Date, ref string? Details)
            {
                bool isFound = false;

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Logs WHERE LogID = @LogID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LogID", LogID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        { 
                            if (reader.Read())
                            {

                                // The record was found
                                isFound = true;

                                Action = (string)reader["Action"];
                                UserID = (int)reader["UserID"];
                                Date = reader["Date"] != DBNull.Value ? (int?)reader["Date"] : null;
                                Details = reader["Details"] != DBNull.Value ? reader["Details"].ToString() : null;



                            }
                        }

                    }
                }
                return isFound;

            }

        public static DataTable GetAllLogs()
{
    DataTable dt = new DataTable();

    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
    {
        string query = "SELECT * FROM Logs";

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

         public static int? AddNewLogs(string Action, int UserID, int? Date, string? Details)
        {
            int? LogID = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Insert Into Logs ([Action],[UserID],[Date],[Details])
                            Values (@Action,@UserID,@Date,@Details)
                            SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Action", Action);
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@Date", Date ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Details", Details ?? (object)DBNull.Value);


                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        LogID = insertedID;
                    }
                }

            }
            return LogID;

        }


         public static bool UpdateLogsByID(int? LogID, string Action, int UserID, int? Date, string? Details)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Update Logs
                                    set 
                                         [Action] = @Action,
                                         [UserID] = @UserID,
                                         [Date] = @Date,
                                         [Details] = @Details
                                  where [LogID]= @LogID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LogID", LogID);
                    command.Parameters.AddWithValue("@Action", Action);
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@Date", Date ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Details", Details ?? (object)DBNull.Value);


                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }

            }

            return (rowsAffected > 0);
        }


        public static bool DeleteLogs(int LogID)
{
    int rowsAffected = 0;

    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
    {
        string query = @"Delete Logs 
                        where LogID = @LogID";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@LogID", LogID);


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
        string query = $@"select * from Logs
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
