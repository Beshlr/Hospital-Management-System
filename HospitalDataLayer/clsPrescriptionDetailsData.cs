using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDataLayer
{
    public class clsPrescriptionDetailsData
    {
        public static bool GetPrescriptionDetailsInfoByID(int PrescriptionID, ref int MedicineID, ref string Dosage)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM PrescriptionDetails WHERE PrescriptionID = @PrescriptionID";

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

                            MedicineID = (int)reader["MedicineID"];
                            Dosage = (string)reader["Dosage"];



                        }
                    }

                }
            }
            return isFound;

        }

        public static DataTable GetAllPrescriptionDetails()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM PrescriptionDetails";

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

        public static int AddNewPrescriptionDetails(int MedicineID, string Dosage)
        {
            int PrescriptionID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Insert Into PrescriptionDetails ([MedicineID],[Dosage])
                            Values (@MedicineID,@Dosage)
                            SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MedicineID", MedicineID);
                    command.Parameters.AddWithValue("@Dosage", Dosage);


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


        public static bool UpdatePrescriptionDetailsByID(int PrescriptionID, int MedicineID, string Dosage)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Update PrescriptionDetails
                                    set 
                                         [MedicineID] = @MedicineID,
                                         [Dosage] = @Dosage
                                  where [PrescriptionID]= @PrescriptionID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
                    command.Parameters.AddWithValue("@MedicineID", MedicineID);
                    command.Parameters.AddWithValue("@Dosage", Dosage);


                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }

            }

            return (rowsAffected > 0);
        }


        public static bool DeletePrescriptionDetails(int PrescriptionID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Delete PrescriptionDetails 
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
                string query = $@"select * from PrescriptionDetails
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
