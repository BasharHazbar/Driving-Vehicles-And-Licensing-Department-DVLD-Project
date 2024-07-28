using DVLD.Controls;
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
    public partial class frmIssueDrivingLicense : Form
    {
        private int _PersonID, _ApplicationID, _LicenseClassID;

        private clsLicenses _License;
        private clsLicenseClasses _LicenseClasse;
        private clsDrivers _Driver;
        public frmIssueDrivingLicense(int PersonID, int ApplicationID, int LicenseClassID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _ApplicationID = ApplicationID;
            _LicenseClassID = LicenseClassID;
        }

        private void frmIssueDrivingLicense_Load(object sender, EventArgs e)
        {
            ctrlApplicationCard.LoadApplicationData(_ApplicationID);
        }

        private void IssueLicense()
        {
            _LicenseClasse = clsLicenseClasses.Find(_LicenseClassID);



            if (clsDrivers.isExistByPersonID(_PersonID))
            {
                _Driver = clsDrivers.FindByPerson(_PersonID);

            }
            else
            {
                _Driver = new clsDrivers();
                _Driver.PersonID = _PersonID;
                _Driver.CreatedByUserID = clsGlobalSettings.User.UserID;
                _Driver.CreatedDate = DateTime.Now;
                _Driver.Save();
            }


            _License = new clsLicenses();

            _License.ApplicationID = _ApplicationID;
            _License.DriverID = _Driver.DriverID;
            _License.LicenseClassID = _LicenseClassID;
            _License.IssueDate = DateTime.Now;
            _License.ExpirationDate = DateTime.Now.AddYears(_LicenseClasse.DefaultValidityLength);
            _License.Notes = rtbNotes.Text;
            _License.PaidFees = _LicenseClasse.ClassFees;
            _License.IssueReason = (byte)clsGlobalSettings.enIssuedReason.FirstTime;
            _License.CreatedByUserID = clsGlobalSettings.User.UserID;

            if (MessageBox.Show("Are you sure you want to Issue the License ", "Confirm",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_License.Save())
                {
                    MessageBox.Show("License Issued Successfuly With ID = " + _License.LicenseID, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clsApplications.ChangeStatusApplication(_ApplicationID, (byte)clsGlobalSettings.enApplicationStatus.Complated);

                    btnIssueLicense.Enabled = false;
                }

                else
                    MessageBox.Show("Data Not Save Successfuly", "Not Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;

        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            IssueLicense();
            ctrlApplicationCard.LoadApplicationData(_ApplicationID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
