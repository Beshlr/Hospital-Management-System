using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalDataLayer;

namespace clsBussinessLayer
{
    public class clsDoctors : clsPeople
    {
        public int DoctorID { get; set; }
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

        private clsDoctors(int personID, string firstName, string secondName, string nationalNumber, string lastName, DateTime dateOfBirth,
                            int gendor, string address, string phoneNumber, string imagePath, int DoctorID, int SpecializationID, int WorkingHours)
        {
            this.PersonID = personID;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;
            this.NationalNumber = nationalNumber;
            this.Gendor = (enGendor)gendor;
            this.DateOfBirth = dateOfBirth;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.ImagePath = imagePath;
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
                clsPeople PersonInfo = clsPeople.GetPersonInfo(PersonID);

                return new clsDoctors(PersonInfo.PersonID, PersonInfo.FirstName, PersonInfo.SecondName, PersonInfo.NationalNumber, PersonInfo.LastName
                    , PersonInfo.DateOfBirth, (int)PersonInfo.Gendor, PersonInfo.Address, PersonInfo.PhoneNumber, PersonInfo.ImagePath, DoctorID,
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

                return new clsDoctors(PersonInfo.PersonID, PersonInfo.FirstName, PersonInfo.SecondName, PersonInfo.NationalNumber, PersonInfo.LastName
                    , PersonInfo.DateOfBirth, (int)PersonInfo.Gendor, PersonInfo.Address, PersonInfo.PhoneNumber, PersonInfo.ImagePath, DoctorID,
                    SpecializationID, WorkingHours);
            }

            return null;
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
    }
}
