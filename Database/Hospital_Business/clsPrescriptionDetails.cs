
using System;
using System.Data;
using Hospital_DataLayer;

namespace Hospital_BusinessLayer
{
    public class clsPrescriptionDetails
    {
        #nullable enable

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? PrescriptionID { get; set; }
        public int MedicineID { get; set; }
        public clsPharmacy? PharmacyInfo { get; set; }
        public string Dosage { get; set; }


        public clsPrescriptionDetails()
        {
            this.PrescriptionID = null;
            this.PrescriptionID = null;
            this.MedicineID = 0;
            this.Dosage = "";
            Mode = enMode.AddNew;
        }


        private clsPrescriptionDetails(
int? PrescriptionID,int MedicineID, string Dosage          )
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
ref int? PrescriptionID,int MedicineID, string Dosage)
        {
        PrescriptionID = clsPrescriptionDetailsData.AddNewPrescriptionDetails(
MedicineID, Dosage);

            return (PrescriptionID != null);

       }


       private bool _UpdatePrescriptionDetails()
       {
        return clsPrescriptionDetailsData.UpdatePrescriptionDetailsByID(
this.PrescriptionID, this.MedicineID, this.Dosage       );
       }


       public static bool UpdatePrescriptionDetailsByID(
int? PrescriptionID,int MedicineID, string Dosage          )
        {
        return clsPrescriptionDetailsData.UpdatePrescriptionDetailsByID(
PrescriptionID, MedicineID, Dosage);

        }


       public static clsPrescriptionDetails? FindByPrescriptionID(int? PrescriptionID)

        {
            if (PrescriptionID == null)
            {
                return null;
            }
            int MedicineID = 0;
            string Dosage = "";
            bool IsFound = clsPrescriptionDetailsData.GetPrescriptionDetailsInfoByID(PrescriptionID,
 ref MedicineID,  ref Dosage);

           if(IsFound)
               return new clsPrescriptionDetails(
 PrescriptionID,  MedicineID,  Dosage);
            else
                return  null;
        }


       public static DataTable? GetAllPrescriptionDetails()
       {

        return clsPrescriptionDetailsData.GetAllPrescriptionDetails();

       }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewPrescriptionDetails())
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


        public static DataTable? SearchData(enPrescriptionDetailsColumns enChose, string Data)
        {
            if(!SqlHelper.IsSafeInput(Data))
                return null;
            
            return clsPrescriptionDetailsData.SearchData(enChose.ToString(), Data);

        }        



    }
}
