using System;
using System.Data;
using DVLD_DataAccess_Layer;

namespace DVLD_Business_Layer
{
    public class clsPeople
    {

        public enum enMode { AddPerson = 0, UpdatePerson = 1};

        private enMode _Mode;

        public int PersonID { set; get; }

        public string NationalNo { set; get; }

        public string FirstName { set; get; }

        public string SecondName { set; get; }

        public string ThirdName { set; get; }

        public string LastName { set; get; }

        public DateTime DateOfBirth { set; get; }

        public short Gendor { set; get; }

        public string Address { set; get; }

        public string Email { set; get; }

        public string Phone { set; get; }

        public int NationalityCountryID { set; get; }

        public string ImagePath { set; get; }

        private bool AddPerson()
        {
           this.PersonID = clsDataAccessPeople.AddPerson(this.NationalNo,this.FirstName,this.SecondName,this.ThirdName,
                this.LastName,this.DateOfBirth,this.Gendor,this.Address,this.Phone,this.Email,this.NationalityCountryID,this.ImagePath);
            return this.PersonID != -1;
        }


        private bool UpdatePerson()
        { 
            return clsDataAccessPeople.UpdatePerson(this.PersonID,this.NationalNo, this.FirstName, this.SecondName, this.ThirdName,
                this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }


        public clsPeople()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName =  "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = -1;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";
            this._Mode = enMode.AddPerson;

        }

        public clsPeople(enMode Mode, int PersonID,string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName,DateTime DateOfBirth,short Gendor, string Address, string Phone,
            string Email, int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            this._Mode = Mode;
        }

        public string getFullName()
        {
            return  FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
        }


       public static clsPeople Find(int PersonID)
       {

            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            short Gendor = -1;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";
            

            if (clsDataAccessPeople.Find(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref DateOfBirth, ref Gendor, ref Address, ref Email, ref Phone, ref NationalityCountryID, ref ImagePath))

            return new clsPeople(enMode.UpdatePerson, PersonID,NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Gendor,Address,Phone,Email
                ,NationalityCountryID,ImagePath);
            else
            return null;
       }

        public static clsPeople Find(string  NationalNo)
        {
            int PersonID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            short Gendor = -1;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";


            if (clsDataAccessPeople.Find (NationalNo,ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref DateOfBirth, ref Gendor, ref Address, ref Email, ref Phone, ref NationalityCountryID, ref ImagePath))

                return new clsPeople(enMode.UpdatePerson, PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email
                    , NationalityCountryID, ImagePath);
            else
                return null;
        }

        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddPerson:

                   if (AddPerson())
                    {
                        _Mode = enMode.UpdatePerson;
                        return true;
                    }
                   else
                    {
                        return false;
                    }

                case enMode.UpdatePerson:

                    return UpdatePerson();

                default:
                    return false;
            }
        }   


        public static bool isExist(int PersonID)
        {
           return clsDataAccessPeople.isExist(PersonID);
        }


        public static bool isExist(string NationalNO)
        {
            return clsDataAccessPeople.isExist(NationalNO);
        }

        public static DataTable GetPeopleList()
        {
            return clsDataAccessPeople.GetPeapleList();
        }


        public static bool Delete(int PersonID)
        {
            return clsDataAccessPeople.Delete(PersonID);
        }

    }
}
