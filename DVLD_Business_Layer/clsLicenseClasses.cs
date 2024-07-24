using DVLD_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsLicenseClasses
    {
        public enum enMode { AddLicenseClasse = 0, UpdateLicenseClasse = 1 };

        private enMode _Mode;

        public int LicenseClassID {  get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge {  get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees {  get; set; }

        public clsLicenseClasses()
        {
            this.LicenseClassID = -1;
            this.ClassName = "";
            this.ClassDescription = "";
            this.MinimumAllowedAge = 0;
            this.DefaultValidityLength = 0;
            this.ClassFees = -1;
            this._Mode = enMode.AddLicenseClasse;
        }


        public clsLicenseClasses(enMode Mode, int LicenseClassID, string ClassName, string ClassDescription,
            byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)
        {
            _Mode = Mode;
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }

        public static clsLicenseClasses Find(int LicenseClassID)
        {

            string ClassName = "";
            string ClassDescription = "";
            byte MinimumAllowedAge = 0;
            byte DefaultValidityLength = 0;
            decimal ClassFees = -1;

            if (clsDataAccessLicenseClasses.FindByID(LicenseClassID,ref ClassName,ref ClassDescription,ref MinimumAllowedAge,
                ref DefaultValidityLength,ref ClassFees))
                return new clsLicenseClasses(enMode.UpdateLicenseClasse,LicenseClassID,ClassName,ClassDescription,MinimumAllowedAge,
                    DefaultValidityLength,ClassFees);
            else 
                return null;

        }

        public static clsLicenseClasses Find(string ClassName)
        {

            int LicenseClassID = -1;
            string ClassDescription = "";
            byte MinimumAllowedAge = 0;
            byte DefaultValidityLength = 0;
            decimal ClassFees = -1;

            if (clsDataAccessLicenseClasses.FindByClassName(ClassName,ref LicenseClassID, ref ClassDescription,ref MinimumAllowedAge,
                ref DefaultValidityLength,ref ClassFees))
                return new clsLicenseClasses(enMode.UpdateLicenseClasse, LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge,
                    DefaultValidityLength, ClassFees);
            else
                return null;

        }

        public static DataTable GetLicenseClassesList()
        {
            return clsDataAccessLicenseClasses.GetLicenseClassesList();
        }

        public static bool Delete(int LicenseClassID)
        {
            return clsLicenseClasses.Delete(LicenseClassID);
        }
    }
}
