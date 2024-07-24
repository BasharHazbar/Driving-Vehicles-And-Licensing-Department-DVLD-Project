using DVLD_DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsTestAppointments
    {
        public enum enMode { AddTestAppointment = 0, UpdateTestAppointments = 1 };

        private enMode _Mode;

        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate {  get; set; }

        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set;}
        public bool IsLocked {  get; set; }
        public int RetakeTestApplicationID { get;set; }


       public clsTestAppointments()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;
            _Mode = enMode.AddTestAppointment;
        }

        public clsTestAppointments(enMode Mode, int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, 
            DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            _Mode = Mode;
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
        }

        private bool AddTestAppointment()
        {
           this.TestAppointmentID =  clsDataAccessTestAppointments.AddTestAppointment(this.TestTypeID,this.LocalDrivingLicenseApplicationID,this.AppointmentDate,this.PaidFees,
                this.CreatedByUserID,this.IsLocked,this.RetakeTestApplicationID);
            return this.TestAppointmentID != -1;
        }


        private bool UpdateTestAppointment()
        {
            return clsDataAccessTestAppointments.UpdateTestAppointment(this.TestAppointmentID,this.TestTypeID,this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate,this.PaidFees,this.CreatedByUserID,this.IsLocked,this.RetakeTestApplicationID);
        }


        public static clsTestAppointments Find(int TestAppointmentID)
        {
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestApplicationID = -1;

            if (clsDataAccessTestAppointments.Find(TestAppointmentID,ref TestTypeID,ref LocalDrivingLicenseApplicationID,
                ref AppointmentDate,ref PaidFees ,ref CreatedByUserID,ref IsLocked,ref RetakeTestApplicationID))
                return new clsTestAppointments(enMode.UpdateTestAppointments,TestAppointmentID,TestTypeID,
                    LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID,IsLocked,RetakeTestApplicationID);
            else
                return null;
        }


        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddTestAppointment:

                    if (AddTestAppointment())
                    {
                        _Mode = enMode.UpdateTestAppointments;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UpdateTestAppointments:

                    return UpdateTestAppointment();

                default:
                    return false;
            }
        }

        public static bool isExist(int TestAppointmentID)
        {
            return clsDataAccessTestAppointments.isExist(TestAppointmentID);
        }

        public static bool isHasActiveAppointment(int LocalDrivingLicenseApplicationID)
        {
            return clsDataAccessTestAppointments.isHasActiveAppointment(LocalDrivingLicenseApplicationID);
        }

        public static bool isPassedTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsDataAccessTestAppointments.isPassedTest(LocalDrivingLicenseApplicationID,TestTypeID);
        }

        public static bool LockedTestAppointment(int TestAppointmentID)
        {
            return clsDataAccessTestAppointments.LockedTestAppointment(TestAppointmentID);
        }
        public static DataTable GetTestAppointmentsList(int LocalDrivingLicenseApplicationID,int TestTypeID)
        {
            return clsDataAccessTestAppointments.GetTestAppointmentsList(LocalDrivingLicenseApplicationID,TestTypeID);
        }

        public static int CountTrail(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsDataAccessTestAppointments.CountTrail(LocalDrivingLicenseApplicationID, TestTypeID);
        }

/*        public static bool Delete(int TestAppointmentID)
        {
            return clsDataAccessTestAppointments.Delete(TestAppointmentID);
        }*/
    }
}
