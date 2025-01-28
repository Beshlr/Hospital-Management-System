using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HospitalDataLayer;

namespace clsBussinessLayer
{
    public class clsPeople
    {

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName {  get; set; }
        public string LastName { get; set; }

        public string FullName { get { return FirstName + ' ' + SecondName  + ' ' + LastName ; } }
        public string NationalNumber {  get; set; }
        public DateTime DateOfBirth {  get; set; }
        public string GendorText
        {
            get
            {
                return Gendor == enGendor.Female ? "Female" : "Male";
            }
        }
        public enum enGendor { Male = 1, Female = 2};
        public enGendor Gendor { get; set; }
        public string Address {  get; set; }
        public string PhoneNumber {  get; set; }
        public string ImagePath {  get; set; }
        public enum enMode { AddNew = 1, Update = 2};
        public enMode Mode = enMode.AddNew;

        public clsPeople()
        {
            PersonID = -1;
            FirstName = "";
            SecondName = "";
            LastName = "";
            DateOfBirth = DateTime.Now;
            Gendor = enGendor.Male;
            Address = "";
            PhoneNumber = "";
            Mode = enMode.AddNew;
        }

        private clsPeople(int personID, string firstName, string secondName,
                            string lastName, DateTime dateOfBirth, int gendor, string address, string phoneNumber,string imagePath)
        {
            PersonID = personID;
            FirstName = firstName;
            SecondName = secondName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gendor = (enGendor)gendor;
            Address = address;
            PhoneNumber = phoneNumber;
            ImagePath = imagePath;
            Mode = enMode.Update;
        }

        private bool AddNewPerson(string firstName, string secondName, string lastName, DateTime dateOfBirth,
                                    enGendor gendor, string address, string phoneNumber,string imagePath)
        {
            int personID = clsPeopleData.AddNewPerson(firstName, secondName, lastName, dateOfBirth, (byte)gendor, address, phoneNumber, imagePath);

            this.PersonID = personID;
            return personID != -1;
        }
        private bool UpdatePerson(int PersonID)
        {
            return clsPeopleData.UpdatePerson(PersonID, this.FirstName, this.SecondName,
                this.LastName, this.DateOfBirth, (byte)this.Gendor, this.Address, this.PhoneNumber, this.ImagePath);
        }

        public static clsPeople GetPersonInfo(int PersonID)
        {
            string FirstName = "", SecondName = "", LastName = "", PhoneNumber = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;

            bool IsFound = clsPeopleData.FindPersonInfoByID(PersonID, ref FirstName, ref SecondName, ref LastName,
                                                            ref DateOfBirth, ref Gendor, ref Address, ref PhoneNumber, ref ImagePath);

            if (IsFound)
            {
                return new clsPeople(PersonID, FirstName, SecondName, LastName,
                                                                DateOfBirth, Gendor, Address, PhoneNumber, ImagePath);
            }

            return null;
        }

        public static DataTable GetAllPersons()
        {
            return clsPeopleData.GetAllPersons();
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    
                    if(AddNewPerson(this.FirstName, this.SecondName, this.LastName, this.DateOfBirth,
                        this.Gendor, this.Address,this.PhoneNumber, this.ImagePath) == true)
                    {
                        this.Mode = enMode.Update;
                        return true;

                    }
                    return false;
                case enMode.Update:
                    return UpdatePerson(this.PersonID);
                     
            }

            return false;
        }
    }
}
