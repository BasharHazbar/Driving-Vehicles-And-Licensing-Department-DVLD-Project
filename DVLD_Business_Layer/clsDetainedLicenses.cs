using DVLD_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsDetainedLicenses
    {
        public enum enMode { AddDetainedLicense = 0, UpdateDetainedLicense = 1 };

        private enMode _Mode;

        public int DetainID { get; set; }

        public int LicenseID { get;  set; }

        public DateTime DetainDate { get; set; }

        public decimal FineFees { get;  set; }

        public int CreatedByUserID { get; set; }

        public bool IsReleased { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int ReleasedByUserID { get; set; }

        public int ReleaseApplicationID { get; set; }

        private bool AddDetainedLicense()
        {
            this.DetainID = clsDataAccessDetainedLicenses.AddDetainedLicense(this.LicenseID,this.DetainDate,
                this.FineFees,this.CreatedByUserID,this.IsReleased,this.ReleaseDate,this.ReleasedByUserID,this.ReleaseApplicationID);
            return this.DetainID != -1;
        }


        private bool UpdateDetainedLicense()
        {
            return clsDataAccessDetainedLicenses.UpdateDetainedLicense(this.DetainID,this.LicenseID, this.DetainDate,
                this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
        }

        public clsDetainedLicenses()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = -1;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = null;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;
            this._Mode = enMode.AddDetainedLicense;

        }

        public clsDetainedLicenses(enMode Mode, int DetainID,int LicenseID, DateTime DetainDate, decimal FineFees,
            int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this._Mode = Mode;
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees= FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;

        }

        public static clsDetainedLicenses Find(int DetainID)
        {
         
            int LicenseID = -1;
            DateTime DetainDate = DateTime.Now;
            decimal FineFees = -1;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime? ReleaseDate = null;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            if (clsDataAccessDetainedLicenses.Find(DetainID,ref LicenseID,ref DetainDate,ref FineFees,
                ref CreatedByUserID,ref IsReleased , ref ReleaseDate, ref ReleasedByUserID,ref ReleaseApplicationID))
            return new clsDetainedLicenses(enMode.UpdateDetainedLicense, DetainID,LicenseID,DetainDate,FineFees,CreatedByUserID,IsReleased,
                ReleaseDate,ReleasedByUserID,ReleaseApplicationID);
            else
                return null;
        }


        public static clsDetainedLicenses FindByLicenseID(int LicenseID)
        {

            int DetainID = -1;
            DateTime DetainDate = DateTime.Now;
            decimal FineFees = -1;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime? ReleaseDate = null;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            if (clsDataAccessDetainedLicenses.FindByLicenseID(LicenseID, ref DetainID, ref DetainDate, ref FineFees,
                ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
                return new clsDetainedLicenses(enMode.UpdateDetainedLicense, DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased,
                    ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;
        }
        public bool Save()
            {

                switch (_Mode)
                {
                    case enMode.AddDetainedLicense:

                        if (AddDetainedLicense())
                        {
                            _Mode = enMode.UpdateDetainedLicense;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case enMode.UpdateDetainedLicense:

                       return UpdateDetainedLicense();

                    default:
                        return false;
                }
             }

        public static bool isExist(int DetainID)
        {
            
            return clsDataAccessDetainedLicenses.isExist(DetainID);
        }

        public static DataTable GetDetainedAndReleaseLicenseList()
        {
            return clsDataAccessDetainedLicenses.GetDetainedAndReleaseLicenseList();
        }
        public static bool Delete(int DetainID)
        {
            return clsDetainedLicenses.Delete(DetainID);
        }
    }
}
