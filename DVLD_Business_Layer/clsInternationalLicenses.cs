using DVLD_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsInternationalLicenses
    {

        public enum enMode { AddLInternationalLicense = 0, UpdateInternationalLicenses = 1 };

        private enMode _Mode;
        public  int InternationalLicenseID {  get; set; } 

        public  int ApplicationID { get; set; }

        public  int DriverID { get; set; }
        public  int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public  short IsActive { get; set; }
        public  int CreatedByUserID { get; set; }


        private bool AddLInternationalLicense()
        {
            return clsDataAccessInternationalLicenses.AddLInternationalLicense(this.ApplicationID,this.DriverID,
                this.IssuedUsingLocalLicenseID,this.IssueDate,this.ExpirationDate,this.IsActive,this.CreatedByUserID);
        }


        private bool UpdateInternationalLicenses()
        {
            return clsDataAccessInternationalLicenses.UpdateInternationalLicenses(this.InternationalLicenseID, this.ApplicationID, this.DriverID,
                this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
        }


        public clsInternationalLicenses()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = -1;
            this.CreatedByUserID = -1;
            _Mode = enMode.AddLInternationalLicense;

        }

        public clsInternationalLicenses(enMode Mode, int InternationalLicenseID,int ApplicationID,int DriverID,
            int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, short IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            this._Mode = Mode;
        }

        public static clsInternationalLicenses Find(int InternationalLicenseID)
        {

            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            short IsActive = -1;
            int CreatedByUserID = -1;

            if (clsDataAccessInternationalLicenses.Find(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate,
                ref ExpirationDate, ref IsActive, ref CreatedByUserID))
                return new clsInternationalLicenses(enMode.UpdateInternationalLicenses, InternationalLicenseID, ApplicationID,
                    DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            else
                return null;
        }

        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddLInternationalLicense:

                    if (AddLInternationalLicense())
                    {
                        _Mode = enMode.UpdateInternationalLicenses;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UpdateInternationalLicenses:

                    return UpdateInternationalLicenses();

                default:
                    return false;
            }
        }


        public static DataTable GetInternationalLicensesListByPersonID(int PersonID)
        {
            return clsDataAccessInternationalLicenses.GetInternationalLicensesListByPersonID(PersonID);
        }
        public static bool isExist(int InternationalLicenseID)
        {
            return clsDataAccessInternationalLicenses.isExist(InternationalLicenseID);
        }

        public static bool Delete(int InternationalLicenseID)
        {
            return clsDataAccessInternationalLicenses.Delete(InternationalLicenseID);
        }
    }
}
