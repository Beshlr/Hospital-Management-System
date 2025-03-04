using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalDataLayer;
using System.Data;

namespace clsBussinessLayer
{
    public class clsDoctors
    {
        public int DoctorID { get; set; }
        public int PersonID {  get; set; }
        public clsPeople PersonInfo { get; set; }
        public int SpecializationID { get; set; }
        public clsSpecializations SpecializationInfo { get; set; }
        public int WorkingHours { get; set; }
        public enum enMode { AddNew = 1, Update = 2 };
        public enMode Mode = enMode.AddNew;

        public clsDoctors()
        {
            this.DoctorID = -1;
            this.SpecializationID = -1;
            this.WorkingHours = -1;

            this.Mode = enMode.AddNew;
        }

        private clsDoctors(int personID,int DoctorID, int SpecializationID, int WorkingHours)
        {
            this.PersonID = personID;
            this.PersonInfo = clsPeople.GetPersonInfo(personID);
            this.DoctorID = DoctorID;
            this.SpecializationID = SpecializationID;
            //Get All Specialization Info By ID.
            this.SpecializationInfo = clsSpecializations.Find(this.SpecializationID);
            this.WorkingHours = WorkingHours;

            Mode = enMode.Update;
        }

        private bool _AddNewDoctor()
        {
            //Call Data Access Layer
            this.DoctorID = clsDoctorsData.AddNewDoctor(this.PersonID, this.SpecializationID, this.WorkingHours);

            return (this.DoctorID != -1);
        }

        private bool _UpdateDoctorByDoctorID()
        {
            //Call Data Access Layer
            return clsDoctorsData.UpdateDoctorByDoctorID(this.DoctorID, this.SpecializationID, this.WorkingHours);
        }

        private bool _UpdateDoctorByPersonID()
        {
            //Call Data Access Layer
            return clsDoctorsData.UpdateDoctorByPersonID(this.PersonID, this.SpecializationID, this.WorkingHours);
        }

        public static bool DeleteDoctorByDoctorID(int DoctorID)
        {
            //Call Data Access Layer
            return clsDoctorsData.DeleteDoctorByDoctorID(DoctorID);
        }

        public static bool DeleteDoctorByPersonID(int PersonID)
        {
            //Call Data Access Layer
            return clsDoctorsData.DeleteDoctorByPersonID(PersonID);
        }

        public bool Save()
        {
            

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDoctor())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateDoctorByDoctorID();
            }
            return false;
        }

        public static clsDoctors FindByPersonID(int PersonID)
        {
            int DoctorID = -1, SpecializationID = -1, WorkingHours = -1;

            if (clsDoctorsData.GetDoctorInfoByPersonID(ref DoctorID, PersonID, ref SpecializationID, ref WorkingHours))
            {
                //Get person information by ID.

                return new clsDoctors(PersonID,DoctorID,
                    SpecializationID, WorkingHours);
            }

            return null;
        }

        public static clsDoctors FindByDoctorID(int DoctorID)
        {
            int PersonID = -1, SpecializationID = -1, WorkingHours = -1;

            if (clsDoctorsData.GetDoctorInfoByDoctorID(DoctorID, ref PersonID, ref SpecializationID, ref WorkingHours))
            {
                //Get person information by ID.
                clsPeople PersonInfo = clsPeople.GetPersonInfo(PersonID);

                return new clsDoctors(PersonID, DoctorID,
                    SpecializationID, WorkingHours);
            }

            return null;
        }

        public static clsDoctors FindByNationalNO(string NationalNO)
        {
            int PersonID = -1, SpecializationID = -1, WorkingHours = -1,DoctorID = -1;

            if (clsDoctorsData.GetDoctorInfoByNationalNO(NationalNO,ref DoctorID, ref PersonID, ref SpecializationID, ref WorkingHours))
            {
                //Get person information by ID.
                clsPeople PersonInfo = clsPeople.GetPersonInfo(PersonID);

                return new clsDoctors(PersonID, DoctorID,
                    SpecializationID, WorkingHours);
            }

            return null;
        }

        public static DataTable GetAllDoctors()
        {
            return clsDoctorsData.GetAllDoctors();
        }

        public static List<clsDoctors> GetDoctorsThereNameStartWith(string DoctorName)
        {
            DataTable dt1 = new DataTable();

            dt1 = clsDoctorsData.GetTop3DoctorsThereNameStartWith(DoctorName);

            List<clsDoctors> doctors = new List<clsDoctors>(); 

            HashSet<string> uniqueIds = new HashSet<string>(); 

            foreach (DataRow dr in dt1.Rows)
            {
                string doctorID = dr["DoctorID"].ToString();
                if (!uniqueIds.Contains(doctorID))
                {
                    clsDoctors newDoctor = clsDoctors.FindByDoctorID(Convert.ToInt32(doctorID));
                    doctors.Add(newDoctor);
                    uniqueIds.Add(doctorID); 
                }
            }

            return doctors;
        }

    }

    public class clsSpecializations
    {
        public int SpecializationID { get; set; }
        public string SpecializationName { get; set; }
        public string SpecializationDescription { get; set; }
        public int NumOfDoctorsInSpecialization { get; set; }

        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode { get; set; }

        public clsSpecializations()
        {
            this.SpecializationID = -1;
            this.SpecializationDescription = "";
            this.SpecializationName = "";
            this.NumOfDoctorsInSpecialization = -1;

            this.Mode = enMode.AddNew;
        }

        private clsSpecializations(int specializationID, string specializationName, string specializationDes, int numOfDoctors)
        {
            this.SpecializationID = specializationID;
            this.SpecializationDescription = specializationDes;
            this.SpecializationName = specializationName;
            this.NumOfDoctorsInSpecialization = numOfDoctors;

            this.Mode = enMode.Update;
        }

        private bool _AddNewSpecialization()
        {
            this.SpecializationID = clsSpecializationsData.AddNewSpecialization(this.SpecializationName, this.SpecializationDescription, this.NumOfDoctorsInSpecialization);

            return (this.SpecializationID != -1);
        }

        private bool _UpdateSpecialization()
        {
            return clsSpecializationsData.UpdateSpecialization(this.SpecializationID, this.SpecializationName, this.SpecializationDescription, this.NumOfDoctorsInSpecialization);
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSpecialization())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateSpecialization();

            }

            return false;
        }

        public static clsSpecializations Find(int SpecializationID)
        {
            string SpecializationName = "", SpecializationDescr = "";
            int NumOfDoctors = -1;

            if(clsSpecializationsData.GetSpecializationInfo(SpecializationID,ref SpecializationName,ref SpecializationDescr,ref NumOfDoctors))
            {
                return new clsSpecializations(SpecializationID, SpecializationName, SpecializationDescr, NumOfDoctors);
            }
            return null;
        }

        public static int GetNumOfDoctorInASpecialization(int SpecializationID)
        {
            return clsSpecializationsData.GetNumOfDoctorsInASpecialization(SpecializationID);
        }
    
        public static List<string> GetAllSpecializationName()
        {
            DataTable dt1 = clsSpecializationsData.GetAllSpecializationsRecords();

            List<string> roomNumbers = new List<string>();

            foreach (DataRow row in dt1.Rows)
            {
                roomNumbers.Add(row["SpecializationName"].ToString());
            }

            return roomNumbers;
        }
    }
}
