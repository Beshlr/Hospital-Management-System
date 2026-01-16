using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDataLayer
{
    public class clsAppointmentsData
    {

        public static bool GetAppointmentsInfoByID(int  AppointmentID, ref int PatientID, ref int DoctorID, ref DateTime Date, ref byte Status, ref int RoomID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Appointments WHERE AppointmentID = @AppointmentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            // The record was found
                            isFound = true;

                            PatientID = (int)reader["PatientID"];
                            DoctorID = (int)reader["DoctorID"];
                            Date = (DateTime)reader["Date"];
                            Status = (byte)reader["Status"];
                            RoomID = (int)reader["RoomID"];



                        }
                    }

                }
            }
            return isFound;

        }

        public static DataTable GetAllAppointments()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Appointments";

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

        public static int  AddNewAppointments(int PatientID, int DoctorID, DateTime Date, byte Status, int RoomID)
        {
            int AppointmentID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Insert Into Appointments ([PatientID],[DoctorID],[Date],[Status],[RoomID])
                            Values (@PatientID,@DoctorID,@Date,@Status,@RoomID)
                            SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@PatientID", PatientID);
                command.Parameters.AddWithValue("@DoctorID", DoctorID);
                command.Parameters.AddWithValue("@Date", Date);
                command.Parameters.AddWithValue("@Status", Status);
                command.Parameters.AddWithValue("@RoomID", RoomID);

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        AppointmentID = insertedID;
                    }

                }
                catch (Exception ex) { }
                finally { connection.Close(); }
                

            }
            return AppointmentID;

        }

        public static int CheckIfPatentHasAnActiveAppointment(int PatientID)
        {
            int AppID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT AppointmentID FROM Appointments WHERE PatientID = @PatientID AND (Status = 0 OR 
                                                                                                          Status = 1 OR
                                                                                                          Status = 2 OR
                                                                                                          Status = 5)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientID", PatientID);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int appID))
                    {
                        AppID = appID;
                    }
                    

                }
            }
            return AppID;

        }

        public static bool UpdateAppointmentsByID(int  AppointmentID, int PatientID, int DoctorID, DateTime Date, byte Status, int RoomID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Update Appointments
                                    set 
                                         [PatientID] = @PatientID,
                                         [DoctorID] = @DoctorID,
                                         [Date] = @Date,
                                         [Status] = @Status,
                                         [RoomID] = @RoomID
                                  where [AppointmentID]= @AppointmentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                    command.Parameters.AddWithValue("@PatientID", PatientID);
                    command.Parameters.AddWithValue("@DoctorID", DoctorID);
                    command.Parameters.AddWithValue("@Date", Date);
                    command.Parameters.AddWithValue("@Status", Status);
                    command.Parameters.AddWithValue("@RoomID", RoomID);


                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }

            }

            return (rowsAffected > 0);
        }

        public static bool DeleteAppointments(int AppointmentID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Delete Appointments 
                        where AppointmentID = @AppointmentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AppointmentID", AppointmentID);


                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();


                }

            }

            return (rowsAffected > 0);

        }

        public static bool UpdateAppStatus(int AppID, byte Status)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Update Appointments
                                    set 
                                         [Status] = @Status
                                  where [AppointmentID]= @AppointmentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@Status", Status);
                    command.Parameters.AddWithValue("@AppointmentID", AppID);

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
                string query = $@"select * from Appointments
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
        
        public static int GetRoomIDByAppID(int AppID)
        {
            int RoomID = -1;
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select RoomID From Appointments Where AppointmentID = @AppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppID", AppID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null)
                    RoomID = (int)result;
            }
            catch(Exception ex) { }
            finally { connection.Close(); }

            return RoomID;
        }
    }
}

