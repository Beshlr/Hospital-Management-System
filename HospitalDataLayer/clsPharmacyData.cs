using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HospitalDataLayer
{
    public class clsPharmacyData
    {
        public static int AddNewMedicien(string MedicineName,int AmountInStock,decimal Price, int PrescriptionID)
        {
            int MedicienID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert Into Pharmacy(
                           MedicineName,AmountInStock,Price,PrescriptionID)
                            
                            Values:
                            (
                            @MedicineName,
                            @AmountInStock,
                            @Price,
                            @PrescriptionID
                            )
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MedicineName", MedicineName);
            command.Parameters.AddWithValue("@AmountInStock", AmountInStock);
            command.Parameters.AddWithValue("@Price", Price);
            command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    MedicienID = InsertedID;
                }

            }
            catch { }
            finally { connection.Close(); }

            return MedicienID;
        }

        public static bool DeleteMedicienByMedicienID(int MedicienID)
        {
            bool IsDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Delete From Pharmacy Where MedicienID = @MedicienID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MedicienID", MedicienID);

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

        public static bool UpdateMedicienByMedicienID(int MedicienID, string MedicineName, int AmountInStock, decimal Price, int PrescriptionID)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update Pharmacy
                            Set
                            MedicineName = @MedicineName,
                            AmountInStock = @AmountInStock,
                            Price = @Price,
                            PrescriptionID = @PrescriptionID
                            Where MedicienID = @MedicienID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MedicienID", MedicienID);
            command.Parameters.AddWithValue("@MedicineName", MedicineName);
            command.Parameters.AddWithValue("@AmountInStock", AmountInStock);
            command.Parameters.AddWithValue("@Price", Price);
            command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);

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

        public static bool GetMedicienInfoByMedicienID(int MedicienID, string MedicineName, int AmountInStock, decimal Price, int PrescriptionID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Pharmacy Where MedicienID = @MedicienID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MedicienID", MedicienID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    MedicineName = (string)reader["MedicineName"];
                    AmountInStock = (int)reader["AmountInStock"];
                    Price = (decimal)reader["Price"];
                    PrescriptionID = (int)reader["PrescriptionID"];
                }

                reader.Close();
            }
            catch { Exception ex; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static DataTable GetAllMediciens()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Pharmacy";
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
