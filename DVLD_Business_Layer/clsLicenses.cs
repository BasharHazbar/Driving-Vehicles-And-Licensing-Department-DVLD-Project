using DVLD_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsLicenses
    {
        public enum enMode { AddLicense = 0, UpdateLicense = 1 };

        private enMode _Mode;
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; } 
        public int LicenseClassID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }


        private bool AddLicense()
        {
             this.LicenseID =  clsDataAccessLicenses.AddLicense(this.ApplicationID,this.DriverID,this.LicenseClassID,
                 this.IssueDate,this.ExpirationDate,this.Notes,this.PaidFees,this.IsActive,this.IssueReason,this.CreatedByUserID);
            return this.LicenseID != -1;
        }

        private bool UpdateLicense()
        {
            return clsDataAccessLicenses.UpdatLicense(this.LicenseID,this.ApplicationID, this.DriverID, this.LicenseClassID,
                 this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
        }


        public clsLicenses()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClassID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = -1;
            this.IsActive = true;
            this.IssueReason = 0;
            this.CreatedByUserID = -1;
        }

        public clsLicenses(enMode Mode,int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate,
           DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            this._Mode = Mode;
            this.LicenseID = LicenseID; 
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = LicenseClassID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
        }


        public static clsLicenses Find(int LicenseID)
        {

            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClassID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = -1;
            bool IsActive = true;
            byte IssueReason = 0;
            int CreatedByUserID = -1;

            if (clsDataAccessLicenses.Find(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID
                , ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))

                return new clsLicenses(enMode.UpdateLicense,LicenseID,ApplicationID,DriverID,
                    LicenseClassID,IssueDate,ExpirationDate,Notes,PaidFees,IsActive,IssueReason,CreatedByUserID);
            else
            return null;

        }

        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddLicense:

                    if (AddLicense())
                    {
                        _Mode = enMode.UpdateLicense;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UpdateLicense:

                    return UpdateLicense();

                default:
                    return false;
            }
        }


        public static bool isExist(int LicenseID)
        {
            return clsDataAccessLicenses.isExist(LicenseID);
        }

        public static bool IsHasIssuedLicense(int ApplicationID)
        {
            return clsDataAccessLicenses.IsHasIssuedLicense(ApplicationID);
        }

        public static bool IsOrdinarydrivinglicense(int LicenseID)
        {
            return clsDataAccessLicenses.IsOrdinarydrivinglicense(LicenseID);
        }

        public static DataTable GetLicensesInfo(int ApplicationID)
        {
            return clsDataAccessLicenses.GetLicensesInfo(ApplicationID);
        }

        public static DataTable GetLicensesListByPersonID(int PersonID)
        {
            return clsDataAccessLicenses.GetLicensesListByPersonID(PersonID);
        }
/*
        public static DataTable GetLicensesList()
        {
            return clsDataAccessLicenses.GetLicensesList();
        }*/

        public static bool Delete(int LicenseID)
        {
            return clsDataAccessLicenses.Delete(LicenseID);
        }

    }
}
