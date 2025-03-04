using HospitalDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBussinessLayer
{
    public class clsPharmacy
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int MedicineID { get; set; }
        public string MedicineName { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int PrescriptionID { get; set; }
        public clsPrescription PrescriptionInfo { get; set; }


        public clsPharmacy()
        {
            this.MedicineID = -1;
            this.MedicineName = "";
            this.Stock = 0;
            this.Price = 0m;
            this.PrescriptionID = 0;
            Mode = enMode.AddNew;
        }


        private clsPharmacy(
int MedicineID, string MedicineName, int Stock, decimal Price, int PrescriptionID)
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

            return (this.MedicineID != -1);

        }


        public static bool AddNewPharmacy(
 ref int MedicineID, string MedicineName, int Stock, decimal Price, int PrescriptionID)
        {
            MedicineID = clsPharmacyData.AddNewPharmacy(
    MedicineName, Stock, Price, PrescriptionID);

            return (MedicineID != -1);

        }


        private bool _UpdatePharmacy()
        {
            return clsPharmacyData.UpdatePharmacyByID(
    this.MedicineID, this.MedicineName, this.Stock, this.Price, this.PrescriptionID);
        }


        public static bool UpdatePharmacyByID(
 int MedicineID, string MedicineName, int Stock, decimal Price, int PrescriptionID)
        {
            return clsPharmacyData.UpdatePharmacyByID(
    MedicineID, MedicineName, Stock, Price, PrescriptionID);

        }


        public static clsPharmacy FindByMedicineID(int MedicineID)

        {
            if (MedicineID == -1)
            {
                return null;
            }
            string MedicineName = "";
            int Stock = 0;
            decimal Price = 0m;
            int PrescriptionID = 0;
            bool IsFound = clsPharmacyData.GetPharmacyInfoByID(MedicineID,
 ref MedicineName, ref Stock, ref Price, ref PrescriptionID);

            if (IsFound)
                return new clsPharmacy(
  MedicineID, MedicineName, Stock, Price, PrescriptionID);
            else
                return null;
        }


        public static DataTable GetAllPharmacy()
        {

            return clsPharmacyData.GetAllPharmacy();

        }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPharmacy())
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


        public static DataTable SearchData(enPharmacyColumns enChose, string Data)
        {
            if (!SqlHelper.IsSafeInput(Data))
                return null;

            return clsPharmacyData.SearchData(enChose.ToString(), Data);

        }

    }

    public class clsPrescriptionDetails
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PrescriptionID { get; set; }
        public int MedicineID { get; set; }
        public clsPharmacy PharmacyInfo { get; set; }
        public string Dosage { get; set; }


        public clsPrescriptionDetails()
        {
            this.PrescriptionID = -1;
            this.MedicineID = 0;
            this.Dosage = "";
            Mode = enMode.AddNew;
        }


        private clsPrescriptionDetails(
int PrescriptionID, int MedicineID, string Dosage)
        {
            this.PrescriptionID = PrescriptionID;
            this.MedicineID = MedicineID;
            this.PharmacyInfo = clsPharmacy.FindByMedicineID(MedicineID);
            this.Dosage = Dosage;
            Mode = enMode.Update;
        }


        private bool _AddNewPrescriptionDetails()
        {
            this.PrescriptionID = clsPrescriptionDetailsData.AddNewPrescriptionDetails(
    this.MedicineID, this.Dosage);

            return (this.PrescriptionID != null);

        }


        public static bool AddNewPrescriptionDetails(
 ref int PrescriptionID, int MedicineID, string Dosage)
        {
            PrescriptionID = clsPrescriptionDetailsData.AddNewPrescriptionDetails(
    MedicineID, Dosage);

            return (PrescriptionID != null);

        }


        private bool _UpdatePrescriptionDetails()
        {
            return clsPrescriptionDetailsData.UpdatePrescriptionDetailsByID(
    this.PrescriptionID, this.MedicineID, this.Dosage);
        }


        public static bool UpdatePrescriptionDetailsByID(
 int PrescriptionID, int MedicineID, string Dosage)
        {
            return clsPrescriptionDetailsData.UpdatePrescriptionDetailsByID(
    PrescriptionID, MedicineID, Dosage);

        }


        public static clsPrescriptionDetails FindByPrescriptionID(int PrescriptionID)

        {
            if (PrescriptionID == null)
            {
                return null;
            }
            int MedicineID = 0;
            string Dosage = "";
            bool IsFound = clsPrescriptionDetailsData.GetPrescriptionDetailsInfoByID(PrescriptionID,
 ref MedicineID, ref Dosage);

            if (IsFound)
                return new clsPrescriptionDetails(
  PrescriptionID, MedicineID, Dosage);
            else
                return null;
        }


        public static DataTable GetAllPrescriptionDetails()
        {

            return clsPrescriptionDetailsData.GetAllPrescriptionDetails();

        }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPrescriptionDetails())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdatePrescriptionDetails();

            }

            return false;
        }



        public static bool DeletePrescriptionDetails(int PrescriptionID)
        {

            return clsPrescriptionDetailsData.DeletePrescriptionDetails(PrescriptionID);

        }


        public enum enPrescriptionDetailsColumns
        {
            PrescriptionID,
            MedicineID,
            Dosage
        }


        public static DataTable SearchData(enPrescriptionDetailsColumns enChose, string Data)
        {
            if (!SqlHelper.IsSafeInput(Data))
                return null;

            return clsPrescriptionDetailsData.SearchData(enChose.ToString(), Data);

        }



    }


}
