using HospitalDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace clsBussinessLayer
{
    public class clsPatients : clsPeople
    {
        public int PatientID { get; set; }
        public enum enBloodType
        {
            O_Negative = 1,
            O_Positive = 2,
            A_Negative = 3,
            A_Positive = 4,
            B_Negative = 5,
            B_Positive = 6,
            AB_Negative = 7,
            AB_Positive = 8
        };
        public enBloodType BloodType { get; set; }
        public string Allergies { get; set; }
        public int EmergencyContactID { get; set; }
        public clsEmergencyContact EmergemcyContactInfo {  get; set; }
        public DateTime LastVisitDate { get; set; }
        public bool PatientStatus { get; set; }
        public enum enStatus { Active = 1, Inactive = 2 }
        public enStatus Status = enStatus.Active;
        public string Notes { get; set; }

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public clsPatients()
        {
            this.PatientID = -1;
            this.BloodType = enBloodType.A_Negative;
            this.Allergies = "";
            this.EmergencyContactID = -1;
            this.LastVisitDate = DateTime.Now;
            this.PatientStatus = true;
            this.Status = enStatus.Active;
            this.Notes = "";

            Mode = enMode.AddNew;
        }

        private clsPatients(int personID, string firstName, string secondName, string thirdName, string lastName, DateTime dateOfBirth,
                            int gendor, string address, string phoneNumber, string imagePath, int patientID, enBloodType bloodType,
                            string allergies, int emergencyContactID, DateTime lastVisitDate, bool patientStatus, string notes)
        {
            this.PersonID = personID;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gendor = (enGendor)gendor;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.ImagePath = imagePath;
            this.PatientID = patientID;
            this.BloodType = bloodType;
            this.Allergies = allergies;
            this.EmergencyContactID = emergencyContactID;
            this.EmergemcyContactInfo = clsEmergencyContact.Find(this.EmergencyContactID);
            this.LastVisitDate = lastVisitDate;
            this.PatientStatus = patientStatus;
            if (PatientStatus == true)
                this.Status = enStatus.Active;
            else
                this.Status = enStatus.Inactive;
            Notes = notes;

            this.Mode = enMode.Update;
        }

        private bool _AddNewPatient()
        {
            //Call Data Access Layer
            this.PatientID = clsPatientsData.AddNewPatient(this.PersonID, (int)this.BloodType, this.Allergies, this.EmergencyContactID, DateTime.Now, true, this.Notes);

            return (this.PatientID != -1);
        }

        private bool _UpdatePatientByPatientID()
        {
            //Call Data Access Layer
            return clsPatientsData.UpdatePatientByPatientID(this.PatientID, (int)this.BloodType, this.Allergies, this.EmergencyContactID, true, this.Notes);
        }

        private bool _UpdatePatientByPersonID()
        {
            //Call Data Access Layer
            return clsPatientsData.UpdatePatientByPersonID(this.PersonID, (int)this.BloodType, this.Allergies, this.EmergencyContactID, true, this.Notes);
        }

        public static bool DeletePatientByPatientID(int PatientID)
        {
            //Call Data Access Layer
            return clsPatientsData.DeletePatientByPatientID(PatientID);
        }

        public static bool DeletePatientByPersonID(int PersonID)
        {
            //Call Data Access Layer
            return clsPatientsData.DeletePatientByPersonID(PersonID);
        }

        public bool Save()
        {
            //Because of inheritance first we call the save method in the base class,
            //it will take care of adding all information to the People table.

            base.Mode = (clsPeople.enMode)Mode;

            if (!base.Save())
            {
                return false;
            }


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPatient())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePatientByPatientID();
            }
            return false;
        }

        public static clsPatients FindByPersonID(int PersonID)
        {
            int BloodType = (int)enBloodType.A_Negative, EmergemcyContactID = -1, PatientID = -1;
            string Notes = "", Allergies = "";
            bool PatientStatus = false;
            DateTime LastVisitDate = DateTime.Now;

            if (clsPatientsData.GetPatientInfoByPersonID(ref PatientID, PersonID, ref BloodType, ref Allergies, ref EmergemcyContactID, LastVisitDate, ref PatientStatus, ref Notes))
            {
                //Get person information by ID.
                clsPeople PersonInfo = clsPeople.GetPersonInfo(PersonID);

                return new clsPatients(PersonInfo.PersonID, PersonInfo.FirstName, PersonInfo.SecondName, PersonInfo.NationalNumber, PersonInfo.LastName
                    , PersonInfo.DateOfBirth, (int)PersonInfo.Gendor, PersonInfo.Address, PersonInfo.PhoneNumber, PersonInfo.ImagePath,
                    PatientID, (enBloodType)BloodType, Allergies, EmergemcyContactID, LastVisitDate, PatientStatus, Notes);
            }

            return null;
        }

        public static clsPatients FindByPatientID(int PatientID)
        {
            int BloodType = (int)enBloodType.A_Negative, EmergemcyContactID = -1, PersonID = -1;
            string Notes = "", Allergies = "";
            bool PatientStatus = false;
            DateTime LastVisitDate = DateTime.Now;

            if (clsPatientsData.GetPatientInfoByPatientID(PatientID, ref PersonID, ref BloodType, ref Allergies, ref EmergemcyContactID, LastVisitDate, ref PatientStatus, ref Notes))
            {
                //Get person information by ID.
                clsPeople PersonInfo = clsPeople.GetPersonInfo(PersonID);

                return new clsPatients(PersonInfo.PersonID, PersonInfo.FirstName, PersonInfo.SecondName, PersonInfo.NationalNumber, PersonInfo.LastName
                    , PersonInfo.DateOfBirth, (int)PersonInfo.Gendor, PersonInfo.Address, PersonInfo.PhoneNumber, PersonInfo.ImagePath,
                    PatientID, (enBloodType)BloodType, Allergies, EmergemcyContactID, LastVisitDate, PatientStatus, Notes);
            }

            return null;
        }

        public static DataTable GetAllPatients()
        {
            return clsPatientsData.GetAllPatients();
        }

    }

    public class clsEmergencyContact
    {
        public int EmergemcyContactID { get; set; }
        public string ContactName { get; set; }
        public string ContactFirstPhoneNO { get; set; }
        public string ContactSecondPhoneNO { get; set; }
        public string RelationshipWithEmergencyContact { get; set; }


        public clsEmergencyContact()
        {
            this.EmergemcyContactID = -1;
            this.ContactName = "";
            this.ContactFirstPhoneNO = "";
            this.ContactSecondPhoneNO = "";
            this.RelationshipWithEmergencyContact = "";
        }

        private clsEmergencyContact(int EmergemcyContactID, string ContactName, string ContactFirstPhoneNO, string ContactSecondPhoneNO, string RelationshipWithEmergencyContact)
        {
            this.EmergemcyContactID = EmergemcyContactID;
            this.ContactName = ContactName;
            this.ContactFirstPhoneNO = ContactFirstPhoneNO;
            this.ContactSecondPhoneNO = ContactSecondPhoneNO;
            this.RelationshipWithEmergencyContact = RelationshipWithEmergencyContact;
        }

        public bool AddNewEmergemcyContact()
        {
            return (clsPatientsData.AddEmergencyContact(this.ContactName,this.ContactFirstPhoneNO,this.ContactSecondPhoneNO,
                                                        this.RelationshipWithEmergencyContact) != -1);
        }

        public static clsEmergencyContact Find(int EmergemcyContactID)
        {
            string ContactName = "", ContactFirstPhoneNO = "", ContactSecondPhoneNO = "", RelationshipWithEmergencyContact = "";

            if(clsPatientsData.GetEmergemcyContactInfo(EmergemcyContactID,ref  ContactName,ref ContactFirstPhoneNO,ref ContactSecondPhoneNO,
                                                    ref RelationshipWithEmergencyContact))
            {
                return new clsEmergencyContact(EmergemcyContactID,ContactName,ContactFirstPhoneNO,ContactSecondPhoneNO, RelationshipWithEmergencyContact);
            }
            return null;
        }
    
    
    }

    public class clsPatientsMedicalHistory
    {
        public int MedicalHistoryID { get; set; }
        public int PatientID { get; set; }
        public clsPatients PatientInfo { get; set; }
        public string Condition { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public clsPatientsMedicalHistory()
        {
            this.MedicalHistoryID = -1;
            this.PatientID = -1;
            this.Condition = "";
            this.StartDate = DateTime.Now;
            this.EndDate = DateTime.Now;
            this.Notes = "";

            this.Mode = enMode.AddNew;
        }

        private clsPatientsMedicalHistory(int medicalHistoryID, int patientID, string condition, DateTime startDate, DateTime endDate, string notes)
        {
            MedicalHistoryID = medicalHistoryID;
            PatientID = patientID;
            PatientInfo = clsPatients.FindByPatientID(this.PatientID);
            Condition = condition;
            StartDate = startDate;
            EndDate = endDate;
            Notes = notes;

            Mode = enMode.Update;
        }

        private bool _AddNewMedicalHistoryRecord()
        {
            this.MedicalHistoryID = clsPatientsData.AddNewMedicalHistoryRecordToAPatient(this.PatientID, this.Condition, this.StartDate, this.EndDate, this.Notes);

            return (this.MedicalHistoryID != -1);
        }

        private bool _UpdatePatientMedicalHistory()
        {
            return clsPatientsData.UpdatePatientMedicalHistory(this.MedicalHistoryID,this.Condition,this.StartDate,this.EndDate,this.Notes);
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMedicalHistoryRecord())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePatientMedicalHistory();
            }

            return false;
        }

        public static DataTable GetAllMedicalHistoryForAPatient(int PatientID)
        {
            return clsPatientsData.GetAllMedicalHistoryRecordsToPatient(PatientID);
        }
    
        public static clsPatientsMedicalHistory Find(int MedicalHistoryID)
        {
            int PatientID = -1;
            string Condition = "",Notes = "";
            DateTime StartDate = DateTime.MinValue, EndDate = DateTime.MinValue;

            if(clsPatientsData.GetMedicalHistoryInfo(MedicalHistoryID,ref PatientID,ref Condition,ref StartDate,ref EndDate,ref Notes))
            {
                return new clsPatientsMedicalHistory(MedicalHistoryID,PatientID,Condition,StartDate,EndDate,Notes);
            }

            return null;
        }
    }
}
