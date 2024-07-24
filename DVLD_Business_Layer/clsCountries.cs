using DVLD_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsCountries
    {

        public int CountryID { get; set; }  

        public string CountryName { get; set; }


        public clsCountries(int CountryID, string CountryName) { 
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }


        public static clsCountries Find(int CountryID)
        {
            string CountryName = "";

            if (clsDataAccessCountries.Find(CountryID, ref CountryName))

            return new clsCountries(CountryID,CountryName);
            else
                return null;
        }

        public static clsCountries Find(string CountryName)
        {
           int CountryID = -1;

            if (clsDataAccessCountries.Find(CountryName, ref CountryID))

                return new clsCountries(CountryID, CountryName);
            else
                return null;
        }

        public static DataTable GetCountriesList()
        {
            return clsDataAccessCountries.GetCountriesList();
        }




    }
}
