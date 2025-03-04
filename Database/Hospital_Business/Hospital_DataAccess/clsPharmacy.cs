
using System;
using System.Data.SqlClient;
using System.Data;
using Hospital_DataAccess;

namespace Hospital_DataLayer
{
    public class clsPharmacyData
    {
        #nullable enable

        public static bool GetPharmacyInfoByID(int? MedicineID , ref string MedicineName, ref int Stock, ref decimal Price, ref int PrescriptionID)
            {
                bool isFound = false;

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Pharmacy WHERE MedicineID = @MedicineID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MedicineID", MedicineID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        { 
                            if (reader.Read())
                            {

                                // The record was found
                                isFound = true;

                                MedicineName = (string)reader["MedicineName"];
                                Stock = (int)reader["Stock"];
                                Price = (decimal)reader["Price"];
                                PrescriptionID = (int)reader["PrescriptionID"];



                            }
                        }

                    }
                }
                return isFound;

            }

        public static DataTable GetAllPharmacy()
{
    DataTable dt = new DataTable();

    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
    {
        string query = "SELECT * FROM Pharmacy";

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

         public static int? AddNewPharmacy(string MedicineName, int Stock, decimal Price, int PrescriptionID)
        {
            int? MedicineID = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Insert Into Pharmacy ([MedicineName],[Stock],[Price],[PrescriptionID])
                            Values (@MedicineName,@Stock,@Price,@PrescriptionID)
                            SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MedicineName", MedicineName);
                    command.Parameters.AddWithValue("@Stock", Stock);
                    command.Parameters.AddWithValue("@Price", Price);
                    command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);


                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        MedicineID = insertedID;
                    }
                }

            }
            return MedicineID;

        }


         public static bool UpdatePharmacyByID(int? MedicineID, string MedicineName, int Stock, decimal Price, int PrescriptionID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Update Pharmacy
                                    set 
                                         [MedicineName] = @MedicineName,
                                         [Stock] = @Stock,
                                         [Price] = @Price,
                                         [PrescriptionID] = @PrescriptionID
                                  where [MedicineID]= @MedicineID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MedicineID", MedicineID);
                    command.Parameters.AddWithValue("@MedicineName", MedicineName);
                    command.Parameters.AddWithValue("@Stock", Stock);
                    command.Parameters.AddWithValue("@Price", Price);
                    command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);


                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }

            }

            return (rowsAffected > 0);
        }


        public static bool DeletePharmacy(int MedicineID)
{
    int rowsAffected = 0;

    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
    {
        string query = @"Delete Pharmacy 
                        where MedicineID = @MedicineID";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@MedicineID", MedicineID);


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
        string query = $@"select * from Pharmacy
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
