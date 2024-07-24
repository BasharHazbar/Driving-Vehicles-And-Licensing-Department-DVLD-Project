using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Local_Driving_Licenses
{
    public partial class frmAddEditLocalLicenseTestAppointments : Form
    {
        private enum enMode { AddAppointmentTest = 0, UpdateAppointmentTest = 1 };

        private enMode _Mode;

        private int _TestAppointmentID;

        private clsTestAppointments _TestAppointment;

        private DataRow _ApplicationInfo;

        private int _ApplicationID;

        private clsTestTypes _TestType;

        private byte _TestTypeID;

        private clsApplicationTypes _ApplicationType;

        private clsApplications _Application;

        private bool _IsRetakeTest;

        public frmAddEditLocalLicenseTestAppointments(int AppointmentTestID, int ApplicationID, byte TestTypeID, bool IsRetakeTest)
        {
            InitializeComponent();
            _TestAppointmentID = AppointmentTestID;
            _ApplicationID = ApplicationID;
            _TestTypeID = TestTypeID;
            _IsRetakeTest = IsRetakeTest;

            if (AppointmentTestID == -1)
            {
                _Mode = enMode.AddAppointmentTest;
            }
            else
            {
                _Mode = enMode.UpdateAppointmentTest;
            }
        }

        private void ChangeTitleText()
        {
            switch (_TestTypeID)
            {
                case (byte)clsGlobalSettings.enTestTypes.VisionTest:
                    gbTestInfo.Text = "Vision Test";
                    break;
                case (byte)clsGlobalSettings.enTestTypes.WrittenTest:
                    gbTestInfo.Text = "Written Test";
                    break;
                case (byte)clsGlobalSettings.enTestTypes.StreetTest:
                    gbTestInfo.Text = "Street Test";
                    break;
            }
        }

        private void isLockedTestAppointment()
        {
            if (_TestAppointment.IsLocked)
            {
                dtpAppointmentDate.Enabled = false;
                lbLockedMessage.Visible = true;
                btnSave.Enabled = false;
            }
        }

        private void LoadRetakeTestData()
        {
            _ApplicationType = clsApplicationTypes.Find((int)clsGlobalSettings.enApplicationTypes.RetakeTest);
            gbRetakeTestInfo.Enabled = true;
            lbTitle.Text = "Sechedule Retake Test";
            lbRTestFeesValue.Text = Convert.ToInt16(_ApplicationType.ApplicationFees).ToString();
            lbTotalFeesValue.Text = Convert.ToInt16(_TestType.TestTypeFees + _ApplicationType.ApplicationFees).ToString();

            if (_Mode == enMode.AddAppointmentTest)
            {
                _Application = new clsApplications();
                return;
            }
            lbRTestAppIDValue.Text = _TestAppointment.RetakeTestApplicationID.ToString();
        }

        private void SaveRetakeTestData()
        {

            _Application.ApplicantPersonID = (int)_ApplicationInfo["PersonID"];
            _Application.ApplicationDate = DateTime.Now;
            _Application.ApplicationTypeID = _ApplicationType.ApplicationTypeID;
            _Application.ApplicationStatus = 1;
            _Application.LastStatusDate = DateTime.Now;
            _Application.PaidFees = _ApplicationType.ApplicationFees;
            _Application.CreatedByUserID = clsGlobalSettings.User.UserID;

            _Application.Save();
        }

        void LoadData()
        {
            ChangeTitleText();

            gbRetakeTestInfo.Enabled = false;

            lbLockedMessage.Visible = false;

            _TestType = clsTestTypes.Find(_TestTypeID);

            _ApplicationInfo = clsApplications.GetApplicationInfo(_ApplicationID).Rows[0];

            lbLDLAppIDValue.Text = _ApplicationInfo["L.D.L.AppID"].ToString();

            lbClassNameValue.Text = (string)_ApplicationInfo["ClassName"];

            lbNameValue.Text = (string)_ApplicationInfo["Applicant"];

            lbFeesValue.Text = Convert.ToInt16(_TestType.TestTypeFees).ToString();

            lbTrailValue.Text = clsTestAppointments.CountTrail((int)_ApplicationInfo["L.D.L.AppID"], _TestTypeID).ToString();

            if (!_IsRetakeTest)
            {
                lbTotalFeesValue.Text = Convert.ToInt16(_TestType.TestTypeFees).ToString();
            }


            if (_Mode == enMode.AddAppointmentTest)
            {
                _TestAppointment = new clsTestAppointments();
                if (_IsRetakeTest)
                {
                    LoadRetakeTestData();
                }
                return;
            }


            _TestAppointment = clsTestAppointments.Find(_TestAppointmentID);
            dtpAppointmentDate.Value = _TestAppointment.AppointmentDate;
            _Mode = enMode.UpdateAppointmentTest;
            isLockedTestAppointment();

            if (_IsRetakeTest)
            {
                LoadRetakeTestData();
            }

        }

        private void frmAddEditLocalLicenseTestAppointments_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _TestAppointment.TestTypeID = _TestType.TestTypeID;

            _TestAppointment.LocalDrivingLicenseApplicationID = (int)_ApplicationInfo["L.D.L.AppID"];

            _TestAppointment.AppointmentDate = dtpAppointmentDate.Value;

            _TestAppointment.PaidFees = _TestType.TestTypeFees;

            _TestAppointment.CreatedByUserID = clsGlobalSettings.User.UserID;


            if (_IsRetakeTest && _Mode == enMode.AddAppointmentTest)
            {
                SaveRetakeTestData();
                _ApplicationID = _Application.ApplicationID;
                _TestAppointment.RetakeTestApplicationID = _ApplicationID;
                lbRTestAppIDValue.Text = _ApplicationID.ToString();
                _IsRetakeTest = false;


            }

            if (_TestAppointment.Save())
            {
                MessageBox.Show("Data Save Successful", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Data Not Save Successful", "Not Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
