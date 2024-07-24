using DVLD_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsApplicationTypes
    {

/*        public enum enMode { AddApplicationType = 0, UpdateApplicationType = 1 };

        private enMode _Mode;*/
        public int ApplicationTypeID { get; set; }

        public string ApplicationTypeTitle { get; set; }

        public decimal ApplicationFees { get; set; }


        public clsApplicationTypes()
        {
            this.ApplicationTypeID = -1;
            this.ApplicationTypeTitle = "";
            this.ApplicationFees = -1;
        }

        public clsApplicationTypes(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
        }


/*        private bool AddApplicationType()
        {
            return clsDataAccessApplicationTypes.AddApplicationType(this.ApplicationTypeTitle,this.ApplicationFees);
        }*/

        private bool UpdateApplicationType()
        {
            return clsDataAccessApplicationTypes.UpdateApplicationType(this.ApplicationTypeID,this.ApplicationTypeTitle,this.ApplicationFees);
        }

        public static clsApplicationTypes Find(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";
            decimal applicationFees = -1;

            if (clsDataAccessApplicationTypes.Find(ApplicationTypeID, ref ApplicationTypeTitle, ref applicationFees))
                return new clsApplicationTypes(ApplicationTypeID,ApplicationTypeTitle,applicationFees);
            else
                return null;
        }

/*        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddApplicationType:

                    if (AddApplicationType())
                    {
                        _Mode = enMode.UpdateApplicationType;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UpdateApplicationType:

                    return UpdateApplicationType();

                default:
                    return false;
            }
        }*/

        public bool Save()
        {

            return UpdateApplicationType();
        }


        public static bool isExist(int ApplicationTypeID)
        {
            return clsDataAccessApplicationTypes.isExist(ApplicationTypeID);
        }


        public static DataTable GetApplicationTypesList()
        {
            return clsDataAccessApplicationTypes.GetApplicationTypesList();
        }

/*        public static bool Delete(int ApplicationTypeID)
        {
            return clsDataAccessApplicationTypes.Delete(ApplicationTypeID);
        }*/

    }
}
