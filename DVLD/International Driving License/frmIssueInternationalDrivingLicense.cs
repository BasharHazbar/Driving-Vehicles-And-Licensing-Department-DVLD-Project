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
        private clsInternationalLicenses _InternationalLicenses;
        private clsApplications _Application;
        private  clsApplicationTypes _ApplicationType;
        public frmIssueInternationalDrivingLicense()
        {
            InitializeComponent();
        }

        void LoadLocalLicenseData()
        {
            if (int.TryParse(tbFind.Text, out int LicenseID))
            {
                _License = clsLicenses.Find(LicenseID);

                if (_License == null)
                {
                    MessageBox.Show("NO License With ID = " + LicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   // _LicenseID = -1;
                    ctrlLicenseCard.ResetLicenseData();
                    return;
                }

                if (!_License.IsActive)
                {
                    MessageBox.Show("This License With ID = " + LicenseID + " Not Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //_LicenseID = -1;
                    ctrlLicenseCard.ResetLicenseData();
                    return;

                }

                if (_License.ExpirationDate <= DateTime.Now)
                {
                    MessageBox.Show($"This License with ID = {LicenseID} is already expired.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlLicenseCard.ResetLicenseData();
                    //_LicenseID = -1;
                    return;
                }

             
               
                if (!clsLicenses.IsOrdinarydrivinglicense(_License.LicenseID))
                {
                    MessageBox.Show("This License  with ID = " + LicenseID + " It Not Ordinary Drivig", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnIssueLicense.Enabled = false;
                }
                else
                {
                    btnIssueLicense.Enabled = true;
                }

                ctrlLicenseCard.LoadLicenseData(_License.ApplicationID);
                _Driver = clsDrivers.Find(_License.DriverID);
                lbShowLicenseHistory.Enabled = true;
            }
        }

        void LoadData()
        {
            _ApplicationType = clsApplicationTypes.Find((byte)clsGlobalSettings.enApplicationTypes.NewInternationalLicense);

            lbApplicationDataValue.Text = DateTime.Now.ToString("dd MMM yyyy");
            lbIssueDateValue.Text = DateTime.Now.ToString("dd MMM yyyy");
            lbFeesValue.Text = Convert.ToInt16(_ApplicationType.ApplicationFees).ToString();
            lbExpirationDataValue.Text = DateTime.Now.AddYears(1).ToString("dd MMM yyyy");
            //lbCreatedByValue.Text = clsGlobalSettings.User.UserName;
            lbCreatedByValue.Text = "BSH";
            btnIssueLicense.Enabled = false;
            lbShowLicenseHistory.Enabled = false;
            lbShowLicense.Enabled = false;
            _Application = new clsApplications();
            _InternationalLicenses = new clsInternationalLicenses();
        }

        void IssueInternationalLicense()
        {

            _Application.ApplicantPersonID = _Driver.PersonID;
            _Application.ApplicationDate = DateTime.Now;
            _Application.ApplicationTypeID = _ApplicationType.ApplicationTypeID;
            _Application.ApplicationStatus = 1;
            _Application.PaidFees = _ApplicationType.ApplicationFees;
            _Application.LastStatusDate = DateTime.Now;
            //_Application.CreatedByUserID = clsGlobalSettings.User.UserID;
            _Application.CreatedByUserID = 1;

            if (_Application.Save())
            {
                _InternationalLicenses.ApplicationID = _Application.ApplicationID;
                _InternationalLicenses.DriverID = _License.DriverID;
                _InternationalLicenses.IssuedUsingLocalLicenseID = _License.LicenseID;
                _InternationalLicenses.IssueDate = DateTime.Now;
                _InternationalLicenses.ExpirationDate = DateTime.Now;
                _InternationalLicenses.CreatedByUserID = 1;

                if (_InternationalLicenses.Save())
                {
                    clsApplications.ChangeStatusApplication(_Application.ApplicationID,
                        (byte)clsGlobalSettings.enApplicationStatus.Complated);
                    MessageBox.Show("Data Save Successfuly", "Saved",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbShowLicense.Enabled = true;
                    btnIssueLicense.Enabled = false;
                    lbILApplicationIDValue.Text = _Application.ApplicationID.ToString();    
                    lbILicenseIDValue.Text = _InternationalLicenses.InternationalLicenseID.ToString();

                }
            }
            else
            {
                MessageBox.Show("Data Not Save Successfuly", "Not Saved",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void frmIssueInternationalDrivingLicense_Load(object sender, EventArgs e)
        {
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

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
