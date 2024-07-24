using DVLD_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsTests
    {

        public enum enMode { AddTset = 0, UpdateTest = 1 };

        private enMode _Mode;

        public int TestID {  get; set; }

        public int TestAppointmentID { get; set;}

        public bool TestResult { get; set;}

        public string Notes {  get; set; }

        public int CreatedByUserID {  get; set; }


        private bool AddTset()
        {
            this.TestID =  clsDataAccessTests.AddTset(this.TestAppointmentID,this.TestResult,this.Notes,this.CreatedByUserID);

            return this.TestID != -1;
        }

        private bool UpdateTest()
        {
            return clsDataAccessTests.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
        }

        public clsTests()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;

        }

        public clsTests(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
        }

        public static clsTests Find(int TestID)
        {
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = "";
            int CreatedByUserID = -1;

            if (clsDataAccessTests.Find(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
                return new clsTests(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            else
                return null;
        }


        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddTset:

                    if (AddTset())
                    {
                        _Mode = enMode.AddTset;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UpdateTest:

                    return UpdateTest();

                default:
                    return false;
            }
        }

        public static bool isExist(int TestID)
        {
            return clsDataAccessTests.isExist(TestID);
        }

/*        public static bool Delete(int TestID)
        {
            return clsDataAccessTests.Delete(TestID);
        }*/

    }
}
