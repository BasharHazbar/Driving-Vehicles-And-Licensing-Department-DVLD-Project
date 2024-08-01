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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.Detained_and_Release_License
{
    public partial class frmDetainedLicense : Form
    {

        private clsLicenses _License;
        private clsDrivers _Driver;
        private clsDetainedLicenses _DetainedLicense;
        public frmDetainedLicense()
        {
            InitializeComponent();
        }

        void LoadData()
        {

            lbDetainedDateValue.Text = DateTime.Now.ToString("dd MMM yyyy");
            lb1LicenseIDValue.Text = _License.LicenseID.ToString();
            lbCreatedByValue.Text = clsGlobalSettings.User.UserName;
        }

        void ResetData()
        {
           
            lbDetainedIDValue.Text = "[????]";
            lbDetainedDateValue.Text = "[????]";
            lbDetainedDateValue.Text = "[????]";
            btnDetained.Enabled = false;
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
                }

                if (clsLicenses.IsDetainedLicense(_License.LicenseID))
                {
                    MessageBox.Show("The License Aready Detaind With ID = " + _License.LicenseID , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    btnDetained.Enabled = true;
                }
               

                ctrlLicenseCard.LoadLicenseData(_License.ApplicationID);
                lbShowLicenseHistory.Enabled = true;
                LoadData();

            }
        }

        private void frmDetainedLicense_Load(object sender, EventArgs e)
        {
            btnDetained.Enabled = false;
            lbShowLicenseHistory.Enabled = false;
            lbShowDetainedLicenseInfo.Enabled = false;
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
        void DetaineddLicense()
        {
            if (clsGlobalSettings.IsEmpty(tbFees.Text))
            {
                MessageBox.Show("Please Fill The Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _DetainedLicense = new clsDetainedLicenses();

            _DetainedLicense.DetainDate = DateTime.Now;
            _DetainedLicense.LicenseID = _License.LicenseID;
            _DetainedLicense.FineFees = decimal.Parse(tbFees.Text) ;
            _DetainedLicense.CreatedByUserID = clsGlobalSettings.User.UserID;

            if (MessageBox.Show("Are you sure you want to Detained the License ", "Confirm",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_DetainedLicense.Save())
                {
               
                    MessageBox.Show("The License Detained Successfuly With ID = " + _DetainedLicense.DetainID,
                        "Detained", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ctrlLicenseCard.LoadLicenseData(_License.ApplicationID);

                    lbDetainedIDValue.Text = _DetainedLicense.DetainID.ToString();

                    lbShowDetainedLicenseInfo.Enabled = true;
                    btnDetained.Enabled = false;
                    gbFilter.Enabled = false;
                }
                else
                {
                    MessageBox.Show("The License Not Detained Successfuly", "Not Detained",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
        private void btnDetained_Click(object sender, EventArgs e)
        {
            DetaineddLicense();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicensesHistory LicensesHistory = new frmLicensesHistory(_Driver.PersonID);
            LicensesHistory.ShowDialog();
            LicensesHistory.Dispose();
        }

        private void lbShowDetainedLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseDetails LicenseDetails = new frmLicenseDetails(_License.ApplicationID);
            LicenseDetails.ShowDialog();
            LicenseDetails.Dispose();
        }

    }
}
