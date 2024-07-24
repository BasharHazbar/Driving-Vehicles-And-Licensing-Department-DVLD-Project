using DVLD_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Business_Layer
{
    public class clsApplications 
    {

        public enum enMode { AddApplication = 0, UpdateApplication = 1 };

        private enMode _Mode;


        public int ApplicationID { get; set; }  

        public int ApplicantPersonID { get; set; }

        public int ApplicationTypeID { get; set; }

        public DateTime ApplicationDate { get; set; }

        public byte ApplicationStatus { get; set; }

        public DateTime LastStatusDate { get; set; }

        public decimal PaidFees { get; set; }

        public int CreatedByUserID { get; set; }

        

        public clsApplications() {

            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationTypeID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationStatus = 0;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;
            _Mode = enMode.AddApplication;
        }

        public clsApplications(enMode Mode,int ApplicationID,int ApplicantPersonID, int ApplicationTypeID, DateTime ApplicationDate,
            byte ApplicationStatus, DateTime LastStatusDate ,decimal PaidFees, int CreatedByUserID)
        {
            this._Mode = Mode;
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees= PaidFees;
            this.CreatedByUserID = CreatedByUserID;
        }

        private bool AddApplication()
        {
            this.ApplicationID = clsDataAccessApplications.AddApplication(this.ApplicantPersonID, this.ApplicationTypeID, this.ApplicationDate,
                this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
            return this.ApplicationID != -1;
        }

        private bool UpdateApplication()
        {
            return clsDataAccessApplications.UpdateApplication(this.ApplicationID,this.ApplicantPersonID, this.ApplicationTypeID, this.ApplicationDate,
                this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }

        public static clsApplications Find(int ApplicationID)
        {
            int ApplicantPersonID = -1;
            int ApplicationTypeID = -1;
            DateTime ApplicationDate = DateTime.Now;
            byte ApplicationStatus = 0;
            DateTime LastStatusDate = DateTime.Now;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;

            if (clsDataAccessApplications.Find(ApplicationID, ref ApplicantPersonID, ref ApplicationTypeID
                ,ref ApplicationDate, ref ApplicationStatus, ref PaidFees, ref CreatedByUserID))

                return new clsApplications(enMode.UpdateApplication, ApplicationID,ApplicantPersonID,ApplicationTypeID,ApplicationDate,
                    ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID);
            return null;
        }

        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddApplication:

                    if (AddApplication())
                    {
                        _Mode = enMode.UpdateApplication;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UpdateApplication:

                    return UpdateApplication();

                default:
                    return false;
            }
        }


        public static bool isExistByApplicationID(int ApplicationID)
        {
            return clsDataAccessApplications.isExistByApplicationID(ApplicationID);
        }

        public static bool isExistByPersonID(int PersonID)
        {
            return clsDataAccessApplications.isExistByPersonID(PersonID);
        }
        public static DataTable GetApplicationsList()
        {
            return clsDataAccessApplications.GetApplicationsList();
        }

        public static DataTable GetApplicationInfo(int ApplicationID)
        {
            return clsDataAccessApplications.GetApplicationInfo(
                clsLocalDrivingLicenseApplications.FindByApplicationID(ApplicationID).LocalDrivingLicenseApplicationID);
        }

        public static int PassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            return clsDataAccessApplications.PassedTestCount(LocalDrivingLicenseApplicationID);
        }
        public static bool isExistApplicationInSameClassLicense(int ApplicationPersonID, string ClassName)
        {
            return clsDataAccessApplications.isExistApplicationInSameClassLicense(ApplicationPersonID,ClassName);
        }


        public static bool Delete(int ApplicationID)
        {
            return clsDataAccessApplications.Delete(ApplicationID);
        }

        public static bool ChangeStatusApplication(int ApplicationID, byte ApplicationStatus)
        {
            return clsDataAccessApplications.ChangeStatusApplication(ApplicationID,ApplicationStatus);
        }
    }
}
