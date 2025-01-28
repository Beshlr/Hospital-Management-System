using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HospitalDataLayer
{
    public class clsPatientsData
    {
        public static int AddNewPatient(int PersonID, int BloodType,string Allergies, int EmergencyContactID,DateTime LastVisitDate,
                                        bool PatientStatus, string Notes)
        {
            int PatientID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert Into Patients(PersonID,BloodType,Allergies,EmergencyContactID,LastVisitDate,PatientStatus,Notes)
                            Values
                            (
                            @PersonID,
                            @BloodType,
                            @Allergies,
                            @EmergencyContactID,
                            @LastVisitDate,
                            @PatientStatus,
                            @Notes
                            )
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@BloodType", BloodType);
            command.Parameters.AddWithValue("@LastVisitDate", LastVisitDate);
            command.Parameters.AddWithValue("@PatientStatus", PatientStatus);

            //Checking For Nullable Values
            if (Allergies != null || Allergies.Length > 0)
                command.Parameters.AddWithValue("@Allergies", Allergies);
            else
                command.Parameters.AddWithValue("@Allergies", DBNull.Value);
            if (EmergencyContactID != -1)
                command.Parameters.AddWithValue("@EmergencyContactID", EmergencyContactID);
            else
                command.Parameters.AddWithValue("@EmergencyContactID", DBNull.Value);

            if (Notes != null || Notes.Length > 0)
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", DBNull.Value);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    PatientID = InsertedID;
                }

            }
            catch { }
            finally { connection.Close(); }

            return PatientID;
        }
        
        public static bool DeletePatientByPatientID(int PatientID)
        {
            bool IsDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Delete From Patients Where PatientID = @PatientID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PatientID", PatientID);

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

        public static bool DeletePatientByPersonID(int PersonID)
        {
            bool IsDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Delete From Patients Where PersonID = @PersonID";
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

        public static bool UpdatePatientByPatientID(int PatientID, int BloodType,string Allergies, int EmergencyContactID,
                                                    bool PatientStatus,string Notes)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update Patients
                            Set
                            BloodType = @BloodType
                            Allergies = @Allergies
                            EmergencyContactID = @EmergencyContactID
                            PatientStatus = @PatientStatus
                            Notes = @Notes
                            Where PatientID = @PatientID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PatientID", PatientID);
            command.Parameters.AddWithValue("@BloodType", BloodType);
            command.Parameters.AddWithValue("@PatientStatus", PatientStatus);

            //Checking For Nullable Values
            if (Allergies != null || Allergies != "")
                command.Parameters.AddWithValue("@Allergies", Allergies);
            else
                command.Parameters.AddWithValue("@Allergies", DBNull.Value);
            if (EmergencyContactID != -1)
                command.Parameters.AddWithValue("@EmergencyContactID", EmergencyContactID);
            else
                command.Parameters.AddWithValue("@EmergencyContactID", DBNull.Value);
            if (Notes.Length > 0 || Notes != null)
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", DBNull.Value);

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

        public static bool UpdatePatientByPersonID(int PersonID, int BloodType,string Allergies, int EmergencyContactID,
                                                    bool PatientStatus,string Notes)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update Patients
                            Set
                            BloodType = @BloodType
                            Allergies = @Allergies
                            EmergencyContactID = @EmergencyContactID
                            PatientStatus = @PatientStatus
                            Notes = @Notes
                            Where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@BloodType", BloodType);
            command.Parameters.AddWithValue("@PatientStatus", PatientStatus);

            //Checking For Nullable Values
            if (Allergies != null || Allergies != "")
                command.Parameters.AddWithValue("@Allergies", Allergies);
            else
                command.Parameters.AddWithValue("@Allergies", DBNull.Value);
            if (EmergencyContactID != -1)
                command.Parameters.AddWithValue("@EmergencyContactID", EmergencyContactID);
            else
                command.Parameters.AddWithValue("@EmergencyContactID", DBNull.Value);
            if (Notes.Length> 0 || Notes != null)
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", DBNull.Value);

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

        public static bool GetPatientInfoByPatientID(int PatientID,ref int PersonID,ref int BloodType,ref string Allergies,ref int EmergencyContactID,
                                                   DateTime LastVisitDate,ref bool PatientStatus,ref string Notes)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Patients Where PatientID = @PatientID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PatientID", PatientID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)reader["PersonID"];
                    BloodType = (int)reader["BloodType"];
                    LastVisitDate = (DateTime)reader["LastVisitDate"];
                    PatientStatus = (bool)reader["PatientStatus"];

                    //Checking For Nullable Values
                    if (reader["Allergies"] != DBNull.Value)
                        Allergies = (string)reader["Allergies"];
                    else
                        Allergies = "";
                    if (reader["EmergencyContactID"] != DBNull.Value)
                        EmergencyContactID = (int)reader["EmergencyContactID"];
                    else
                        EmergencyContactID = -1;

                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];
                    else
                        Notes = "";

                }

                reader.Close();
            }
            catch { Exception ex; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool GetPatientInfoByPersonID(ref int PatientID, int PersonID, ref int BloodType, ref string Allergies, ref int EmergencyContactID,
                                                   DateTime LastVisitDate,ref bool PatientStatus, ref string Notes)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Patients Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    PatientID = (int)reader["PatientID"];
                    BloodType = (int)reader["BloodType"];
                    LastVisitDate = (DateTime)reader["LastVisitDate"];
                    PatientStatus = (bool)reader["PatientStatus"];

                    //Checking For Nullable Values
                    if (reader["Allergies"] != DBNull.Value)
                        Allergies = (string)reader["Allergies"];
                    else
                        Allergies = "";
                    if (reader["EmergencyContactID"] != DBNull.Value)
                        EmergencyContactID = (int)reader["EmergencyContactID"];
                    else
                        EmergencyContactID = -1;

                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];
                    else
                        Notes = "";
                }

                reader.Close();
            }
            catch { Exception ex; }
            finally { connection.Close(); }

            return IsFound;
        }
        
        public static DataTable GetAllPatients()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Patients";
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

        public static int AddEmergencyContact(string ContactName,string ContactFirstPhoneNO,string ContactSecondPhoneNO,string RelationshipWithEmergencyContact)
        {
            int PatientID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert Into PatientEmergencyContacts(
                            ContactName,
                            ContactFirstPhoneNO,
                            ContactSecondPhoneNO,
                            RelationshipWithEmergencyContact
                            )

                            Values
                            (
                            @ContactName,
                            @ContactFirstPhoneNO,
                            @ContactSecondPhoneNO,
                            @RelationshipWithEmergencyContact
                            )
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactName", ContactName);
            command.Parameters.AddWithValue("@ContactFirstPhoneNO", ContactFirstPhoneNO);

            //Checking For Nullable Values
            if (ContactSecondPhoneNO != null || ContactSecondPhoneNO.Length > 0)
                command.Parameters.AddWithValue("@ContactSecondPhoneNO", ContactSecondPhoneNO);
            else
                command.Parameters.AddWithValue("@ContactSecondPhoneNO", DBNull.Value);
            if (RelationshipWithEmergencyContact != null || RelationshipWithEmergencyContact.Length > 0)
                command.Parameters.AddWithValue("@RelationshipWithEmergencyContact", RelationshipWithEmergencyContact);
            else
                command.Parameters.AddWithValue("@RelationshipWithEmergencyContact", DBNull.Value);

            
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    PatientID = InsertedID;
                }

            }
            catch { }
            finally { connection.Close(); }

            return PatientID;
        }
    
        public static bool GetEmergemcyContactInfo(int EmergemcyContactID,ref string ContactName,ref string ContactFirstPhoneNO,ref string ContactSecondPhoneNO,ref string RelationshipWithEmergencyContact)
        {
            bool IsFound = false;
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From PatientEmergencyContacts Where EmergemcyContactID = @EmergemcyContactID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmergemcyContactID", EmergemcyContactID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    ContactName = (string)reader["ContactName"];
                    ContactFirstPhoneNO = (string)reader["ContactFirstPhoneNO"];
                    if (reader["ContactSecondPhoneNO"] != DBNull.Value)
                        ContactSecondPhoneNO = (string)reader["ContactSecondPhoneNO"];
                    else
                        ContactSecondPhoneNO = "";
                    if (reader["RelationshipWithEmergencyContact"] != DBNull.Value)
                        RelationshipWithEmergencyContact = (string)reader["RelationshipWithEmergencyContact"];
                    else
                        RelationshipWithEmergencyContact = "";


                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return IsFound;

        }
    
        public static int AddNewMedicalHistoryRecordToAPatient(int PatientID,string Condition, DateTime StartDate, DateTime EndDate, string Notes)
        {
            int MedicalHistoryID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert Into PatientEmergencyContacts(
                            PatientID,
                            Condition,
                            StartDate,
                            EndDate,
                            Notes
                            )

                            Values
                            (
                            @PatientID,
                            @Condition,
                            @StartDate,
                            @EndDate,
                            @Notes
                            )
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PatientID", PatientID);
            command.Parameters.AddWithValue("@Condition", Condition);
            command.Parameters.AddWithValue("@StartDate", StartDate);

            //Checking For Nullable Values
            if (EndDate != null )
                command.Parameters.AddWithValue("@EndDate", EndDate);
            else
                command.Parameters.AddWithValue("EndDate", DBNull.Value);
            if (Notes != null || Notes.Length > 0)
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", DBNull.Value);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    MedicalHistoryID = InsertedID;
                }

            }
            catch { }
            finally { connection.Close(); }

            return MedicalHistoryID;
        }
    
        public static DataTable GetAllMedicalHistoryRecordsToPatient(int PatientID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From PatientMedicalHistory Where PatientID = @PatientID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PatientID", PatientID);

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
    
        public static bool UpdatePatientMedicalHistory(int MedicalHistoryID, string Condition, DateTime StartDate, DateTime EndDate, string Notes)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update PatientMedicalHistory
                            Set
                            Condition = @Condition
                            StartDate = @StartDate
                            EndDate = @EndDate
                            Notes = @Notes
                            Where MedicalHistoryID = @MedicalHistoryID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MedicalHistoryID", MedicalHistoryID);
            command.Parameters.AddWithValue("@Condition", Condition);
            command.Parameters.AddWithValue("@StartDate", StartDate);
            
            //Checking For Nullable Values
            if (EndDate != null)
                command.Parameters.AddWithValue("@EndDate", EndDate);
            else
                command.Parameters.AddWithValue("EndDate", DBNull.Value);
            if (Notes != null || Notes.Length > 0)
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", DBNull.Value);

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
    
        public static bool GetMedicalHistoryInfo(int MedicalHistoryID,ref int PatientID, ref string Condition,ref DateTime StartDate,ref DateTime EndDate,ref string Notes)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From PatientMedicalHistory Where MedicalHistoryID = @MedicalHistoryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MedicalHistoryID", MedicalHistoryID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    PatientID = (int)reader["PatientID"];
                    Condition = (string)reader["Condition"];
                    StartDate = (DateTime)reader["StartDate"];
                    if (reader["EndDate"] != DBNull.Value)
                        EndDate = (DateTime)reader["EndDate"];
                    else
                        EndDate = DateTime.MinValue;
                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];
                    else
                        Notes = "";


                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return IsFound;
        }
    }
}
