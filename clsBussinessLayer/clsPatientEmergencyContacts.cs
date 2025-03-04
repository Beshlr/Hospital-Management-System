
using System;
using System.Data;
using Hospital_DataLayer;

namespace Hospital_BusinessLayer
{
    public class clsPatientEmergencyContacts
    {
        #nullable enable

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? EmergencyContactID { get; set; }
        public string ContactName { get; set; }
        public string ContactFirstPhoneNO { get; set; }
        public string? ContactSecondPhoneNO { get; set; }
        public string? RelationshipWithEmergencyContact { get; set; }


        public clsPatientEmergencyContacts()
        {
            this.EmergencyContactID = null;
            this.EmergencyContactID = null;
            this.ContactName = "";
            this.ContactFirstPhoneNO = "";
            this.ContactSecondPhoneNO = null;
            this.RelationshipWithEmergencyContact = null;
            Mode = enMode.AddNew;
        }


        private clsPatientEmergencyContacts(
int? EmergencyContactID,string ContactName, string ContactFirstPhoneNO, string? ContactSecondPhoneNO, string? RelationshipWithEmergencyContact          )
        {
            this.EmergencyContactID = EmergencyContactID;
            this.ContactName = ContactName;
            this.ContactFirstPhoneNO = ContactFirstPhoneNO;
            this.ContactSecondPhoneNO = ContactSecondPhoneNO;
            this.RelationshipWithEmergencyContact = RelationshipWithEmergencyContact;
            Mode = enMode.Update;
        }


       private bool _AddNewPatientEmergencyContacts()
       {
        this.EmergencyContactID = clsPatientEmergencyContactsData.AddNewPatientEmergencyContacts(
this.ContactName, this.ContactFirstPhoneNO, this.ContactSecondPhoneNO, this.RelationshipWithEmergencyContact);

            return (this.EmergencyContactID != null);

       }


       public static bool AddNewPatientEmergencyContacts(
ref int? EmergencyContactID,string ContactName, string ContactFirstPhoneNO, string? ContactSecondPhoneNO, string? RelationshipWithEmergencyContact)
        {
        EmergencyContactID = clsPatientEmergencyContactsData.AddNewPatientEmergencyContacts(
ContactName, ContactFirstPhoneNO, ContactSecondPhoneNO, RelationshipWithEmergencyContact);

            return (EmergencyContactID != null);

       }


       private bool _UpdatePatientEmergencyContacts()
       {
        return clsPatientEmergencyContactsData.UpdatePatientEmergencyContactsByID(
this.EmergencyContactID, this.ContactName, this.ContactFirstPhoneNO, this.ContactSecondPhoneNO, this.RelationshipWithEmergencyContact       );
       }


       public static bool UpdatePatientEmergencyContactsByID(
int? EmergencyContactID,string ContactName, string ContactFirstPhoneNO, string? ContactSecondPhoneNO, string? RelationshipWithEmergencyContact          )
        {
        return clsPatientEmergencyContactsData.UpdatePatientEmergencyContactsByID(
EmergencyContactID, ContactName, ContactFirstPhoneNO, ContactSecondPhoneNO, RelationshipWithEmergencyContact);

        }


       public static clsPatientEmergencyContacts? FindByEmergencyContactID(int? EmergencyContactID)

        {
            if (EmergencyContactID == null)
            {
                return null;
            }
            string ContactName = "";
            string ContactFirstPhoneNO = "";
            string? ContactSecondPhoneNO = null;
            string? RelationshipWithEmergencyContact = null;
            bool IsFound = clsPatientEmergencyContactsData.GetPatientEmergencyContactsInfoByID(EmergencyContactID,
 ref ContactName,  ref ContactFirstPhoneNO,  ref ContactSecondPhoneNO,  ref RelationshipWithEmergencyContact);

           if(IsFound)
               return new clsPatientEmergencyContacts(
 EmergencyContactID,  ContactName,  ContactFirstPhoneNO,  ContactSecondPhoneNO,  RelationshipWithEmergencyContact);
            else
                return  null;
        }


       public static DataTable? GetAllPatientEmergencyContacts()
       {

        return clsPatientEmergencyContactsData.GetAllPatientEmergencyContacts();

       }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewPatientEmergencyContacts())
                    {
                        Mode = enMode.Update;
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdatePatientEmergencyContacts();

            }
        
            return false;
        }



       public static bool DeletePatientEmergencyContacts(int EmergencyContactID)
       {

        return clsPatientEmergencyContactsData.DeletePatientEmergencyContacts(EmergencyContactID);

       }


        public enum enPatientEmergencyContactsColumns
         {
            EmergencyContactID,
            ContactName,
            ContactFirstPhoneNO,
            ContactSecondPhoneNO,
            RelationshipWithEmergencyContact
         }


        public static DataTable? SearchData(enPatientEmergencyContactsColumns enChose, string Data)
        {
            if(!SqlHelper.IsSafeInput(Data))
                return null;
            
            return clsPatientEmergencyContactsData.SearchData(enChose.ToString(), Data);

        }        



    }
}
