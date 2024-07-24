using DVLD_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsLocalDrivingLicenseApplications
    {

        public enum enMode { AddLocalDrivingLicenseApplication = 0, UpdateLocalDrivingLicenseApplication = 1 };

        private enMode _Mode;

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public clsLocalDrivingLicenseApplications()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ApplicationID = -1;
            this.LicenseClassID = -1;
            this._Mode = enMode.AddLocalDrivingLicenseApplication;
        }

        private bool AddLocalDrivingLicenseApplication()
        {
            return clsDataAccessLocalDrivingLicenseApplications.AddLocalDrivingLicenseApplication(this.ApplicationID,this.LicenseClassID);
        }
        private bool UpdateLocalDrivingLicenseApplication()
        {
            return clsDataAccessLocalDrivingLicenseApplications.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID,this.ApplicationID, this.LicenseClassID);
        }
        public clsLocalDrivingLicenseApplications(enMode Mode,int LocalDrivingLicenseApplicationID,int ApplicationID,int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
            this._Mode = Mode;
        }

        public static clsLocalDrivingLicenseApplications FindByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1;
            int LicenseClassID = -1;

            if (clsDataAccessLocalDrivingLicenseApplications.FindByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
                return new clsLocalDrivingLicenseApplications(enMode.UpdateLocalDrivingLicenseApplication, LocalDrivingLicenseApplicationID,ApplicationID,LicenseClassID);
            return null;
        }


        public static clsLocalDrivingLicenseApplications FindByApplicationID(int ApplicationID)
        {
            int LocalDrivingLicenseApplicationID = -1;
            int LicenseClassID = -1;

            if (clsDataAccessLocalDrivingLicenseApplications.FindByApplicationID(ApplicationID , ref LocalDrivingLicenseApplicationID, ref LicenseClassID))
                return new clsLocalDrivingLicenseApplications(enMode.UpdateLocalDrivingLicenseApplication, LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            return null;
        }

        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddLocalDrivingLicenseApplication:

                    if (AddLocalDrivingLicenseApplication())
                    {
                        _Mode = enMode.UpdateLocalDrivingLicenseApplication;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UpdateLocalDrivingLicenseApplication:

                    return UpdateLocalDrivingLicenseApplication();

                default:
                    return false;
            }
        }


        public static bool isExist(int LocalDrivingLicenseApplicationID)
        {
            return clsDataAccessLocalDrivingLicenseApplications.isExist(LocalDrivingLicenseApplicationID);
        }

        public static bool DeleteByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            return clsDataAccessLocalDrivingLicenseApplications.
                DeleteByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
        }

        public static bool DeleteByApplicationID(int ApplicationID)
        {
            return clsDataAccessLocalDrivingLicenseApplications.DeleteByApplicationID(ApplicationID);
        }

    }
}
