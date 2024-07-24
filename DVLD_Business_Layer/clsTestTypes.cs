using DVLD_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsTestTypes
    {
        public int TestTypeID {  get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestTypeFees {  get; set; }  
        

        private bool UpdateTestType()
        {
            return clsDataAccessTestTypes.UpdateTestType(this.TestTypeID,this.TestTypeTitle,
                this.TestTypeDescription,this.TestTypeFees);
        }

        public clsTestTypes() {

            this.TestTypeID = -1;
            this.TestTypeTitle = "";
            this.TestTypeDescription = "";
            this.TestTypeFees = -1;
        }

        public clsTestTypes(int TestTypeID , string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {

            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
        }

        public static clsTestTypes Find(int TestTypeID)
        {
           
         
            string TestTypeTitle = "";
            string TestTypeDescription = "";
            decimal TestTypeFees = -1;

            if (clsDataAccessTestTypes.Find(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
                return new clsTestTypes(TestTypeID,TestTypeTitle,TestTypeDescription,TestTypeFees);
            else
                return null;
        }


        public bool Save()
        {
            return UpdateTestType();
        }


        public static DataTable GetTestTypesList()
        {
            return clsDataAccessTestTypes.GetTestTypesList();
        }

        public static bool Delete(int TestTypeID)
        {
            return clsDataAccessTestTypes.Delete(TestTypeID);
        }
    }
}
