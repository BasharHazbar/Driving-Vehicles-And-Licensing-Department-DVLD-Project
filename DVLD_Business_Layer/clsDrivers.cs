using DVLD_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsDrivers
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }


        private bool AddDriver()
        {
           this.DriverID = clsDataAccessDrivers.AddDriver(this.PersonID,this.CreatedByUserID,this.CreatedDate);

            return this.DriverID != -1;
        }

        public clsDrivers()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;
        }

        public clsDrivers(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID; 
            this.CreatedDate = CreatedDate;
        }


        public static clsDrivers Find(int DriverID)
        {

            int PersonID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDataAccessDrivers.Find(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
                return new clsDrivers(DriverID,PersonID,CreatedByUserID,CreatedDate);
            else
                return null;

        }

        public static clsDrivers FindByPerson(int PersonID)
        {

            int DriverID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDataAccessDrivers.FindByPersonID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))
                return new clsDrivers(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;

        }

        public bool Save()
        {

            return AddDriver();
        }


/*        public static bool isExist(int DriverID)
        {
            return clsDataAccessDrivers.isExist(DriverID);
        }*/

        public static bool isExistByPersonID(int PersonID)
        {
            return clsDataAccessDrivers.isExistByPersonID(PersonID);
        }

        public static int ActivesLicenseCount(int DriverID)
        {
            return clsDataAccessDrivers.ActiveLicensesCount(DriverID);
        }

        public static DataTable GetDriversList()
        {
            return clsDataAccessDrivers.GetDriversList();
        }

       /* public static bool Delete(int DriverID)
        {
            return clsDataAccessDrivers.Delete(DriverID);
        }*/

    }
}
