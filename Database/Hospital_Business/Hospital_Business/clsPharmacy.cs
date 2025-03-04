
using System;
using System.Data;
using Hospital_DataLayer;

namespace Hospital_BusinessLayer
{
    public class clsPharmacy
    {
        #nullable enable

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? MedicineID { get; set; }
        public string MedicineName { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int PrescriptionID { get; set; }
        public clsPrescription? PrescriptionInfo { get; set; }


        public clsPharmacy()
        {
            this.MedicineID = null;
            this.MedicineID = null;
            this.MedicineName = "";
            this.Stock = 0;
            this.Price = 0m;
            this.PrescriptionID = 0;
            Mode = enMode.AddNew;
        }


        private clsPharmacy(
int? MedicineID,string MedicineName, int Stock, decimal Price, int PrescriptionID          )
        {
            this.MedicineID = MedicineID;
            this.MedicineName = MedicineName;
            this.Stock = Stock;
            this.Price = Price;
            this.PrescriptionID = PrescriptionID;
            this.PrescriptionInfo = clsPrescription.FindByPrescriptionID(PrescriptionID);
            Mode = enMode.Update;
        }


       private bool _AddNewPharmacy()
       {
        this.MedicineID = clsPharmacyData.AddNewPharmacy(
this.MedicineName, this.Stock, this.Price, this.PrescriptionID);

            return (this.MedicineID != null);

       }


       public static bool AddNewPharmacy(
ref int? MedicineID,string MedicineName, int Stock, decimal Price, int PrescriptionID)
        {
        MedicineID = clsPharmacyData.AddNewPharmacy(
MedicineName, Stock, Price, PrescriptionID);

            return (MedicineID != null);

       }


       private bool _UpdatePharmacy()
       {
        return clsPharmacyData.UpdatePharmacyByID(
this.MedicineID, this.MedicineName, this.Stock, this.Price, this.PrescriptionID       );
       }


       public static bool UpdatePharmacyByID(
int? MedicineID,string MedicineName, int Stock, decimal Price, int PrescriptionID          )
        {
        return clsPharmacyData.UpdatePharmacyByID(
MedicineID, MedicineName, Stock, Price, PrescriptionID);

        }


       public static clsPharmacy? FindByMedicineID(int? MedicineID)

        {
            if (MedicineID == null)
            {
                return null;
            }
            string MedicineName = "";
            int Stock = 0;
            decimal Price = 0m;
            int PrescriptionID = 0;
            bool IsFound = clsPharmacyData.GetPharmacyInfoByID(MedicineID,
 ref MedicineName,  ref Stock,  ref Price,  ref PrescriptionID);

           if(IsFound)
               return new clsPharmacy(
 MedicineID,  MedicineName,  Stock,  Price,  PrescriptionID);
            else
                return  null;
        }


       public static DataTable? GetAllPharmacy()
       {

        return clsPharmacyData.GetAllPharmacy();

       }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewPharmacy())
                    {
                        Mode = enMode.Update;
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdatePharmacy();

            }
        
            return false;
        }



       public static bool DeletePharmacy(int MedicineID)
       {

        return clsPharmacyData.DeletePharmacy(MedicineID);

       }


        public enum enPharmacyColumns
         {
            MedicineID,
            MedicineName,
            Stock,
            Price,
            PrescriptionID
         }


        public static DataTable? SearchData(enPharmacyColumns enChose, string Data)
        {
            if(!SqlHelper.IsSafeInput(Data))
                return null;
            
            return clsPharmacyData.SearchData(enChose.ToString(), Data);

        }        



    }
}
