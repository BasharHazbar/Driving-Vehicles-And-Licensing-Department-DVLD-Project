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
    public partial class frmTakeLocalDrivingLicenseTest : Form
    {
        private DataRow _ApplicationInfo;

        private int _TestAppointmentID;

        private int _ApplicationID;

        private byte _TestTypeID;

        private clsTestTypes _TestType;

        private clsTests _Test;

        private bool _IsRetakeTest;
        public frmTakeLocalDrivingLicenseTest(int TestAppointmentID, int ApplicationID, byte TestTypeID, bool IsRetakeTest)
        {
            InitializeComponent();
            _TestAppointmentID = TestAppointmentID;
            _ApplicationID = ApplicationID;
            _TestTypeID = TestTypeID;
            _IsRetakeTest = IsRetakeTest;
        }



        private void ChangeTitleText()
        {
            switch (_TestTypeID)
            {
                case (byte)clsGlobalSettings.enTestTypes.VisionTest:
                    lbTitle.Text = "Vision Test";
                    gbTestInfo.Text = "Vision Test";
                    break;
                case (byte)clsGlobalSettings.enTestTypes.WrittenTest:
                    lbTitle.Text = "Written Test";
                    gbTestInfo.Text = "Vision Test";
                    break;
                case (byte)clsGlobalSettings.enTestTypes.StreetTest:
                    lbTitle.Text = "Street Test";
                    gbTestInfo.Text = "Vision Test";
                    break;
            }
        }

        void LoadData()
        {
            ChangeTitleText();

            _Test = new clsTests();

            _ApplicationInfo = clsApplications.GetApplicationInfo(_ApplicationID).Rows[0];

            _TestType = clsTestTypes.Find(_TestTypeID);

            lbLDLAppIDValue.Text = _ApplicationInfo["L.D.L.AppID"].ToString();

            lbClassNameValue.Text = (string)_ApplicationInfo["ClassName"];

            lbNameValue.Text = (string)_ApplicationInfo["Applicant"];

            lbFeesValue.Text = Convert.ToInt16(_TestType.TestTypeFees).ToString();

            lbTrailValue.Text = clsTestAppointments.CountTrail((int)_ApplicationInfo["L.D.L.AppID"], _TestTypeID).ToString();

            lbDateValue.Text = _ApplicationInfo["Date"].ToString();

            lbTestIDValue.Text = "Not Test Yet";

        }
        private void frmTakeLocalDrivingLicenseTest_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Test.TestAppointmentID = _TestAppointmentID;

            if (rbPass.Checked)
            {
                _Test.TestResult = true;
            }
            else if (rbFail.Checked)
            {
                _Test.TestResult = false;
            }
            _Test.Notes = rtbNotes.Text;

            _Test.CreatedByUserID = clsGlobalSettings.User.UserID;

            if (MessageBox.Show("Are You Sure You Want Save ? You Can Not Change Pass/Fail Result After You Save ",
                "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

            {
                if (_Test.Save())
                {
                    clsTestAppointments.LockedTestAppointment(_TestAppointmentID);

                    if (_IsRetakeTest)
                    {
                        clsApplications.ChangeStatusApplication(clsTestAppointments.Find(_TestAppointmentID).RetakeTestApplicationID, (byte)clsGlobalSettings.enApplicationStatus.Complated);
                    }


                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    lbTestIDValue.Text = _Test.TestID.ToString();
                    btnSave.Enabled = false;
                }

                else
                {
                    MessageBox.Show("Data Not Saved Successfully", "Not Saved", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

            }
        }
    }
}
