using DVLD.Controls;
using DVLD.Licenses_History;
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

namespace DVLD.International_Driving_License
{
    public partial class frmIssueInternationalDrivingLicense : Form
    {
        private clsLicenses _License;
        private clsDrivers _Driver;
        private clsInternationalLicenses _InternationalLicense;
        private clsApplications _Application;
        private  clsApplicationTypes _ApplicationType;
        public frmIssueInternationalDrivingLicense()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            _ApplicationType = clsApplicationTypes.Find((byte)clsGlobalSettings.enApplicationTypes.NewInternationalLicense);

            lbApplicationDataValue.Text = DateTime.Now.ToString("dd MMM yyyy");
            lbIssueDateValue.Text = DateTime.Now.ToString("dd MMM yyyy");
            lbFeesValue.Text = Convert.ToInt16(_ApplicationType.ApplicationFees).ToString();
            lbExpirationDataValue.Text = DateTime.Now.AddYears(1).ToString("dd MMM yyyy");
            lbCreatedByValue.Text = clsGlobalSettings.User.UserName;
        }

        void ResetData()
        {
            lbILApplicationIDValue.Text = "[????]";
            lbIntLicenseIDValue.Text = "[????]";
            lbLocalLicenseIDValue.Text = "[????]";
            lbFeesValue.Text = "[????]";
            btnIssueLicense.Enabled = false;
            lbShowLicenseHistory.Enabled = false;
            lbShowLicense.Enabled = false;
        }


        void LoadLocalLicenseData()
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
                }

                if (!_License.IsActive)
                {
                    MessageBox.Show("This License With ID = " + _License.LicenseID + " Not Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlLicenseCard.ResetLicenseData();
                    ResetData();
                    return;

                }

                if (_License.ExpirationDate <= DateTime.Now)
                {
                    MessageBox.Show($"This License with ID = {_License.LicenseID} is already expired.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlLicenseCard.ResetLicenseData();
                    ResetData();
                    return;
                }

             

                if (clsLicenses.IsOrdinarydrivinglicense(_License.LicenseID) && 
                    !clsInternationalLicenses.isExistByDriverID(_Driver.DriverID))
                {
                    btnIssueLicense.Enabled = true;
                    lbShowLicense.Enabled = false;
                }
                else if (
                    (clsLicenses.IsOrdinarydrivinglicense(_License.LicenseID) && clsInternationalLicenses.isExistByDriverID(_Driver.DriverID)) 
                    || 
                    (!clsLicenses.IsOrdinarydrivinglicense(_License.LicenseID) &&clsInternationalLicenses.isExistByDriverID(_Driver.DriverID))
                    )
                {
                    _InternationalLicense = clsInternationalLicenses.FindByDriverID(_Driver.DriverID);


                    MessageBox.Show($"The Person Aready have an Active International License With ID = " +
                        $"{_InternationalLicense.InternationalLicenseID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    lbILApplicationIDValue.Text = _InternationalLicense.ApplicationID.ToString();
                    lbIntLicenseIDValue.Text = _InternationalLicense.InternationalLicenseID.ToString();

                    btnIssueLicense.Enabled = false;
                    lbShowLicense.Enabled = true;

                }
               else //if (!clsLicenses.IsOrdinarydrivinglicense(_License.LicenseID) && !clsInternationalLicenses.isExistByDriverID(_Driver.DriverID))
                {
                    MessageBox.Show($"This License is Not Ordinary Drivig With ID = {_License.LicenseID}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnIssueLicense.Enabled = false;
                    ResetData();
                }
               

                ctrlLicenseCard.LoadLicenseData(_License.ApplicationID);
                LoadData();
                lbLocalLicenseIDValue.Text = _License.LicenseID.ToString();
                lbShowLicenseHistory.Enabled = true;
            }
        }

        void IssueInternationalLicense()
        {

            _Application = new clsApplications();
            _InternationalLicense = new clsInternationalLicenses();

            _Application.ApplicantPersonID = _Driver.PersonID;
            _Application.ApplicationDate = DateTime.Now;
            _Application.ApplicationTypeID = _ApplicationType.ApplicationTypeID;
            _Application.ApplicationStatus = 1;
            _Application.PaidFees = _ApplicationType.ApplicationFees;
            _Application.LastStatusDate = DateTime.Now;
            _Application.CreatedByUserID = clsGlobalSettings.User.UserID;

            if (MessageBox.Show("Are you sure you want to Issue the License ", "Confirm",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_Application.Save())
                {
                    _InternationalLicense.ApplicationID = _Application.ApplicationID;
                    _InternationalLicense.DriverID = _License.DriverID;
                    _InternationalLicense.IssuedUsingLocalLicenseID = _License.LicenseID;
                    _InternationalLicense.IssueDate = DateTime.Now;
                    _InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
                    _InternationalLicense.CreatedByUserID = clsGlobalSettings.User.UserID;

                    if (_InternationalLicense.Save())
                    {
                        clsApplications.ChangeStatusApplication(_Application.ApplicationID,
                            (byte)clsGlobalSettings.enApplicationStatus.Complated);

                        MessageBox.Show("International License Issued Successfuly With ID = " +
                            _InternationalLicense.InternationalLicenseID, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        lbILApplicationIDValue.Text = _Application.ApplicationID.ToString();
                        lbIntLicenseIDValue.Text = _InternationalLicense.InternationalLicenseID.ToString();

                        lbShowLicense.Enabled = true;
                        btnIssueLicense.Enabled = false;
                        gbFilter.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Data Not Save Successfuly", "Not Saved",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

           
        }

        private void frmIssueInternationalDrivingLicense_Load(object sender, EventArgs e)
        {
            btnIssueLicense.Enabled = false;
            lbShowLicenseHistory.Enabled = false;
            lbShowLicense.Enabled = false;
            LoadData();
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            IssueInternationalLicense();
        }

        private void pbFindLicense_Click(object sender, EventArgs e)
        {
            LoadLocalLicenseData();
        }
        private void tbFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadLocalLicenseData();
            }
        }

        private void lbShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicensesHistory LicensesHistory = new frmLicensesHistory(_Driver.PersonID);
            LicensesHistory.ShowDialog();
            LicensesHistory.Dispose();
        }

        private void lbShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmIntLicenseDetails LicenseDetails = new frmIntLicenseDetails(_InternationalLicense.InternationalLicenseID);
            LicenseDetails.ShowDialog();
            LicenseDetails.Dispose();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
