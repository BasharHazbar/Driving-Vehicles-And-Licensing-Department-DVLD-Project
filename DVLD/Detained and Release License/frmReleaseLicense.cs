using DVLD.Licenses_History;
using DVLD.Local_Driving_Licenses;
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

namespace DVLD.Detained_and_Release_License
{
    public partial class frmReleaseLicense : Form
    {
        private int _LicenseID;
        private clsLicenses _License;
        private clsDrivers _Driver;
        private clsDetainedLicenses _DetainedLicense;
        private clsApplicationTypes _ApplicationType;
        private clsApplications _Application;
        public frmReleaseLicense(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }


        void LoadData()
        {
  
            lbReleasedDateValue.Text = DateTime.Now.ToString("dd MMM yyyy");
            lbFanFeesValue.Text = Convert.ToInt16(_DetainedLicense.FineFees).ToString();
            lbApplicationFeesValue.Text = Convert.ToInt16(_ApplicationType.ApplicationFees).ToString();
            lbTotalFeesValue.Text = Convert.ToInt16(_DetainedLicense.FineFees + _ApplicationType.ApplicationFees).ToString();
            lbDetainedIDValue.Text = _DetainedLicense.DetainID.ToString();
            lb1LicenseIDValue.Text = _License.LicenseID.ToString();
            lbCreatedByValue.Text = "BSH";
        }

        void ResetData()
        {

            lbDetainedIDValue.Text = "[????]";
            lbReleasedDateValue.Text = "[????]";
            lbApplicationIDValue.Text = "[????]";
            lbApplicationFeesValue.Text = "[????]";
            lbFanFeesValue.Text = "[????]";
            btnRelease.Enabled = false;
        }



        void LoadDataForReleasing()
        {
            gbFilter.Enabled = false;
            _License = clsLicenses.Find(_LicenseID);
            _Driver = clsDrivers.Find(_License.DriverID);
            _DetainedLicense = clsDetainedLicenses.FindByLicenseID(_License.LicenseID);
            _ApplicationType = clsApplicationTypes.Find((byte)clsGlobalSettings.enApplicationTypes.ReleaseDetainedDrivingLicsense);
            ctrlLicenseCard.LoadLicenseData(_License.ApplicationID);
            lbShowLicenseHistory.Enabled = true;
            btnRelease.Enabled = true;
            LoadData();
        }

        void LoadLicenseData()
        {
            if (int.TryParse(tbFind.Text, out int LicenseID))
            {
                _License = clsLicenses.Find(LicenseID);


                if (_License == null)
                {
                    MessageBox.Show("NO License With ID = " + LicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlLicenseCard.ResetLicenseData();
                    ResetData();
                    return;
                }
                else
                {
                    _Driver = clsDrivers.Find(_License.DriverID);
                    _DetainedLicense = clsDetainedLicenses.FindByLicenseID(_License.LicenseID);
                    _ApplicationType = clsApplicationTypes.Find((byte)clsGlobalSettings.enApplicationTypes.ReleaseDetainedDrivingLicsense);
                }

                if (clsLicenses.IsDetainedLicense(_License.LicenseID))
                {
                    btnRelease.Enabled = true;
                }
                else
                {
                    MessageBox.Show("The License Aready Release With ID = " + _License.LicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }


                ctrlLicenseCard.LoadLicenseData(_License.ApplicationID);
                lbShowLicenseHistory.Enabled = true;
                LoadData();

            }
        }

        void ReleaseLicense()
        {

            _Application = new clsApplications();

            _Application.ApplicantPersonID = _Driver.PersonID;
            _Application.ApplicationDate = DateTime.Now;
            _Application.ApplicationTypeID = _ApplicationType.ApplicationTypeID;
            _Application.ApplicationStatus = 1;
            _Application.PaidFees = _ApplicationType.ApplicationFees;
            _Application.LastStatusDate = DateTime.Now;
            _Application.CreatedByUserID = clsGlobalSettings.User.UserID;

            if (MessageBox.Show("Are you sure you want to Release the License ", "Confirm",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_Application.Save())
                {

                    _DetainedLicense.IsReleased = true;
                    _DetainedLicense.ReleaseDate = DateTime.Now;
                    _DetainedLicense.ReleaseApplicationID = _Application.ApplicationID;
                    _DetainedLicense.ReleasedByUserID = clsGlobalSettings.User.UserID;

                   if (_DetainedLicense.Save())
                    {
                        MessageBox.Show("The License Release Successfuly With ID = " + _DetainedLicense.DetainID,
                       "Detained", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clsApplications.ChangeStatusApplication(_Application.ApplicationID,
                            (byte)clsGlobalSettings.enApplicationStatus.Complated);

                        ctrlLicenseCard.LoadLicenseData(_License.ApplicationID);

                        lbApplicationIDValue.Text = _Application.ApplicationID.ToString();

                        lbShowReleaseLicenseInfo.Enabled = true;
                        btnRelease.Enabled = false;
                        gbFilter.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("The License Not Release Successfuly", "Not Detained",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }


        private void pbFindLicense_Click(object sender, EventArgs e)
        {
            LoadLicenseData();
        }

        private void tbFind_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                LoadLicenseData();
            }
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            ReleaseLicense();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbShowReleaseLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseDetails LicenseDetails = new frmLicenseDetails(_License.ApplicationID);
            LicenseDetails.ShowDialog();
            LicenseDetails.Dispose();
        }

        private void lbShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicensesHistory LicensesHistory = new frmLicensesHistory(_Driver.PersonID);
            LicensesHistory.ShowDialog();
            LicensesHistory.Dispose();
        }

        private void frmReleaseLicense_Load(object sender, EventArgs e)
        {

            lbShowReleaseLicenseInfo.Enabled = false;
            if (_LicenseID != -1)
            {
                LoadDataForReleasing();
            }
            else
            {
                btnRelease.Enabled = false;
                lbShowLicenseHistory.Enabled = false;
            }
            

        }
    }
}
