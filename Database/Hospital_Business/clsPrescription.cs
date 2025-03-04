
using System;
using System.Data;
using Hospital_DataLayer;

namespace Hospital_BusinessLayer
{
    public class clsPrescription
    {
        #nullable enable

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? PrescriptionID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public clsDoctors? DoctorsInfo { get; set; }
        public DateTime IssueDate { get; set; }


        public clsPrescription()
        {
            this.PrescriptionID = null;
            this.PrescriptionID = null;
            this.PatientID = 0;
            this.DoctorID = 0;
            this.IssueDate = DateTime.Now;
            Mode = enMode.AddNew;
        }


        private clsPrescription(
int? PrescriptionID,int PatientID, int DoctorID, DateTime IssueDate          )
        {
            this.PrescriptionID = PrescriptionID;
            this.PatientID = PatientID;
            this.DoctorID = DoctorID;
            this.DoctorsInfo = clsDoctors.FindByDoctorID(DoctorID);
            this.IssueDate = IssueDate;
            Mode = enMode.Update;
        }


       private bool _AddNewPrescription()
       {
        this.PrescriptionID = clsPrescriptionData.AddNewPrescription(
this.PatientID, this.DoctorID, this.IssueDate);

            return (this.PrescriptionID != null);

       }


       public static bool AddNewPrescription(
ref int? PrescriptionID,int PatientID, int DoctorID, DateTime IssueDate)
        {
        PrescriptionID = clsPrescriptionData.AddNewPrescription(
PatientID, DoctorID, IssueDate);

            return (PrescriptionID != null);

       }


       private bool _UpdatePrescription()
       {
        return clsPrescriptionData.UpdatePrescriptionByID(
this.PrescriptionID, this.PatientID, this.DoctorID, this.IssueDate       );
       }


       public static bool UpdatePrescriptionByID(
int? PrescriptionID,int PatientID, int DoctorID, DateTime IssueDate          )
        {
        return clsPrescriptionData.UpdatePrescriptionByID(
PrescriptionID, PatientID, DoctorID, IssueDate);

        }


       public static clsPrescription? FindByPrescriptionID(int? PrescriptionID)

        {
            if (PrescriptionID == null)
            {
                return null;
            }
            int PatientID = 0;
            int DoctorID = 0;
            DateTime IssueDate = DateTime.Now;
            bool IsFound = clsPrescriptionData.GetPrescriptionInfoByID(PrescriptionID,
 ref PatientID,  ref DoctorID,  ref IssueDate);

           if(IsFound)
               return new clsPrescription(
 PrescriptionID,  PatientID,  DoctorID,  IssueDate);
            else
                return  null;
        }


       public static DataTable? GetAllPrescription()
       {

        return clsPrescriptionData.GetAllPrescription();

       }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewPrescription())
                    {
                        Mode = enMode.Update;
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdatePrescription();

            }
        
            return false;
        }



       public static bool DeletePrescription(int PrescriptionID)
       {

        return clsPrescriptionData.DeletePrescription(PrescriptionID);

       }


        public enum enPrescriptionColumns
         {
            PrescriptionID,
            PatientID,
            DoctorID,
            IssueDate
         }


        public static DataTable? SearchData(enPrescriptionColumns enChose, string Data)
        {
            if(!SqlHelper.IsSafeInput(Data))
                return null;
            
            return clsPrescriptionData.SearchData(enChose.ToString(), Data);

        }        



    }
}
