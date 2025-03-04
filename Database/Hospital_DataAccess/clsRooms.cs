
using System;
using System.Data.SqlClient;
using System.Data;
using Hospital_DataAccess;

namespace Hospital_DataLayer
{
    public class clsRoomsData
    {
        #nullable enable

        public static bool GetRoomsInfoByID(int? RoomID , ref string RoomNumber, ref string Floor, ref string RoomType, ref string BedCount, ref bool IsOccupied, ref int OccupiedBy, ref byte AvailabilityStatus, ref decimal DailyRate)
            {
                bool isFound = false;

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Rooms WHERE RoomID = @RoomID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomID", RoomID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        { 
                            if (reader.Read())
                            {

                                // The record was found
                                isFound = true;

                                RoomNumber = (string)reader["RoomNumber"];
                                Floor = (string)reader["Floor"];
                                RoomType = (string)reader["RoomType"];
                                BedCount = (string)reader["BedCount"];
                                IsOccupied = (bool)reader["IsOccupied"];
                                OccupiedBy = (int)reader["OccupiedBy"];
                                AvailabilityStatus = (byte)reader["AvailabilityStatus"];
                                DailyRate = (decimal)reader["DailyRate"];



                            }
                        }

                    }
                }
                return isFound;

            }

        public static DataTable GetAllRooms()
{
    DataTable dt = new DataTable();

    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
    {
        string query = "SELECT * FROM Rooms";

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

         public static int? AddNewRooms(string RoomNumber, string Floor, string RoomType, string BedCount, bool IsOccupied, int OccupiedBy, byte AvailabilityStatus, decimal DailyRate)
        {
            int? RoomID = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Insert Into Rooms ([RoomNumber],[Floor],[RoomType],[BedCount],[IsOccupied],[OccupiedBy],[AvailabilityStatus],[DailyRate])
                            Values (@RoomNumber,@Floor,@RoomType,@BedCount,@IsOccupied,@OccupiedBy,@AvailabilityStatus,@DailyRate)
                            SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomNumber", RoomNumber);
                    command.Parameters.AddWithValue("@Floor", Floor);
                    command.Parameters.AddWithValue("@RoomType", RoomType);
                    command.Parameters.AddWithValue("@BedCount", BedCount);
                    command.Parameters.AddWithValue("@IsOccupied", IsOccupied);
                    command.Parameters.AddWithValue("@OccupiedBy", OccupiedBy);
                    command.Parameters.AddWithValue("@AvailabilityStatus", AvailabilityStatus);
                    command.Parameters.AddWithValue("@DailyRate", DailyRate);


                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        RoomID = insertedID;
                    }
                }

            }
            return RoomID;

        }


         public static bool UpdateRoomsByID(int? RoomID, string RoomNumber, string Floor, string RoomType, string BedCount, bool IsOccupied, int OccupiedBy, byte AvailabilityStatus, decimal DailyRate)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Update Rooms
                                    set 
                                         [RoomNumber] = @RoomNumber,
                                         [Floor] = @Floor,
                                         [RoomType] = @RoomType,
                                         [BedCount] = @BedCount,
                                         [IsOccupied] = @IsOccupied,
                                         [OccupiedBy] = @OccupiedBy,
                                         [AvailabilityStatus] = @AvailabilityStatus,
                                         [DailyRate] = @DailyRate
                                  where [RoomID]= @RoomID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomID", RoomID);
                    command.Parameters.AddWithValue("@RoomNumber", RoomNumber);
                    command.Parameters.AddWithValue("@Floor", Floor);
                    command.Parameters.AddWithValue("@RoomType", RoomType);
                    command.Parameters.AddWithValue("@BedCount", BedCount);
                    command.Parameters.AddWithValue("@IsOccupied", IsOccupied);
                    command.Parameters.AddWithValue("@OccupiedBy", OccupiedBy);
                    command.Parameters.AddWithValue("@AvailabilityStatus", AvailabilityStatus);
                    command.Parameters.AddWithValue("@DailyRate", DailyRate);


                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }

            }

            return (rowsAffected > 0);
        }


        public static bool DeleteRooms(int RoomID)
{
    int rowsAffected = 0;

    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
    {
        string query = @"Delete Rooms 
                        where RoomID = @RoomID";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@RoomID", RoomID);


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
        string query = $@"select * from Rooms
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
