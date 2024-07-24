using DVLD_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsUsers
    {
        public enum enMode { AddUser = 0, UpdateUser = 1 };

        private enMode _Mode;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }


        private bool AddUser()
        {
            this.UserID = clsDataAccessUsers.AddUser(this.PersonID,this.UserName,this.Password,this.IsActive);

            return this.UserID != -1;
        }

        private bool UpdateUser()
        {
            return clsDataAccessUsers.UpdateUser(this.UserID,this.PersonID, this.UserName, this.Password, this.IsActive);
        }


        public clsUsers()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;
            _Mode = enMode.AddUser;
        }

        public clsUsers(enMode Mode, int UserID, int PersonID, string UserName,string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this._Mode = Mode;

        }


        public static clsUsers Find(int UserID)
        {


            int PersonID = -1;
            string UserName = "";
            string Password = "";
            bool IsActive = false;

            if (clsDataAccessUsers.Find(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
                return new clsUsers(enMode.UpdateUser, UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
            
        }

        public static clsUsers Find(string UserName,string Password)
        {

            int UserID = -1;
            int PersonID = -1;
            bool IsActive = false;

            if (clsDataAccessUsers.Find(UserName,Password, ref UserID, ref PersonID, ref IsActive))
                return new clsUsers(enMode.UpdateUser, UserID, PersonID, UserName, Password, IsActive);
            else
                return null;

        }

        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddUser:

                    if (AddUser())
                    {
                        _Mode = enMode.UpdateUser;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UpdateUser:

                    return UpdateUser();

                default:
                    return false;
            }
        }


        public static bool isExistByUserID(int UserID)
        {
            return clsDataAccessUsers.isExistByUserID(UserID);
        }

        public static bool isExistByPersonID(int PersonID)
        {
            return clsDataAccessUsers.isExistByPersonID(PersonID);
        }

        public static DataTable GetUsersList()
        {
            return clsDataAccessUsers.GetUsersList();
        }

        public static bool Delete(int UserID)
        {
            return clsDataAccessUsers.Delete(UserID);
        }


    }
}
