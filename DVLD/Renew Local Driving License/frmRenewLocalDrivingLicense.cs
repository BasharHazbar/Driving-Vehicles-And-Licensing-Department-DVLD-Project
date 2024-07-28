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

namespace DVLD.Renew_Local_Driving_License
{
    public partial class frmRenewLocalDrivingLicense : Form
    {

        private int _ApplicationID;
        private clsLicenses _OldLicense;
        private clsLicenses _NewLicense;
        private clsLicenseClasses _LicenseClass;
        private clsApplicationTypes _ApplicationType;
        private clsApplications _Application;
        private clsDrivers _Driver;
        public frmRenewLocalDrivingLicense()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            _ApplicationType = clsApplicationTypes.Find((byte)clsGlobalSettings.enApplicationTypes.RenewDrivingLicense);
            

            lbApplicationDataValue.Text = DateTime.Now.ToString("dd MMM yyyy");
            lbIssueDateValue.Text = DateTime.Now.ToString("dd MMM yyyy");
            lbExpirationDataValue.Text = DateTime.Now.AddYears(1).ToString("dd MMM yyyy");
            lbCreatedByValue.Text = clsGlobalSettings.User.UserName;
        }
        void ResetData()
        {
            lbRLApplicationIDValue.Text = "[????]";
            lbRenewLicenseIDValue.Text = "[????]";
            lbOldLicenseIDValue.Text = "[????]";
            lbLicenseFeesValue.Text = "[$$$$]";
            lbTotalFeesValue.Text = "[$$$$]";
            lbFeesValue.Text = "[$$$$]";

            btnRenew.Enabled = false;
        }



        void LoadOldLicenseData()
        {
            if (int.TryParse(tbFind.Text, out int LicenseID))
            {
                _OldLicense = clsLicenses.Find(LicenseID);
                

                if (_OldLicense == null)
                {
                    MessageBox.Show("NO License With ID = " + LicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlLicenseCard.ResetLicenseData();
                    ResetData();
                    return;
                }
                else
                {
                    _LicenseClass = clsLicenseClasses.Find(_OldLicense.LicenseClassID);
                    _Driver = clsDrivers.Find(_OldLicense.DriverID);
                }



                if (!_OldLicense.IsActive)
                {
                    MessageBox.Show("This License With ID = " + _OldLicense.LicenseID + " Not Active Aready Expiration, Choose an Another License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetData();
                }
                else if (_OldLicense.ExpirationDate >= DateTime.Now)
                {
                    ResetData();
                    if (_OldLicense.IssueReason == (byte)clsGlobalSettings.enIssuedReason.Renew)
                    {
                        MessageBox.Show("This License With ID = " + _OldLicense.LicenseID + " Aready Renew ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Selected License is not Expired Yet, it will Expire on " + _OldLicense.ExpirationDate.ToString("dd MMM yyyy"), "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    lbOldLicenseIDValue.Text = _OldLicense.LicenseID.ToString();
                    lbFeesValue.Text = Convert.ToInt16(_ApplicationType.ApplicationFees).ToString();
                    lbLicenseFeesValue.Text = Convert.ToInt16(_LicenseClass.ClassFees).ToString();
                    lbTotalFeesValue.Text = Convert.ToInt16(_LicenseClass.ClassFees + _ApplicationType.ApplicationFees).ToString();
                    btnRenew.Enabled = true;
                }


                ctrlLicenseCard.LoadLicenseData(_OldLicense.ApplicationID);
                lbShowLicenseHistory.Enabled = true;
                LoadData();

            }
        }

        private void frmRenewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            btnRenew.Enabled = false;
            lbShowLicenseHistory.Enabled = false;
            lbShowNewLicenseInfo.Enabled = false;
            LoadData();
        }

        private void pbFindLicense_Click(object sender, EventArgs e)
        {
            LoadOldLicenseData();
        }

        private void tbFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadOldLicenseData();
            }
        }

        void RenewLicense()
        {

            _Application = new clsApplications();
            _NewLicense = new clsLicenses();

            _Application.ApplicantPersonID = _Driver.PersonID;
            _Application.ApplicationDate = DateTime.Now;
            _Application.ApplicationTypeID = _ApplicationType.ApplicationTypeID;
            _Application.ApplicationStatus = 1;
            _Application.PaidFees = _ApplicationType.ApplicationFees;
            _Application.LastStatusDate = DateTime.Now;
            _Application.CreatedByUserID = clsGlobalSettings.User.UserID;

            if (MessageBox.Show("Are you sure you want to Renew the License ", "Confirm",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_Application.Save())
                {
                    _NewLicense.ApplicationID = _Application.ApplicationID;
                    _NewLicense.DriverID = _OldLicense.DriverID;
                    _NewLicense.LicenseClassID = _OldLicense.LicenseClassID;
                    _NewLicense.IssueDate = DateTime.Now;
                    _NewLicense.ExpirationDate = DateTime.Now.AddYears(_LicenseClass.DefaultValidityLength);
                    _NewLicense.Notes = rtbNotes.Text;
                    _NewLicense.PaidFees = _LicenseClass.ClassFees;
                    _NewLicense.IssueReason = (byte)clsGlobalSettings.enIssuedReason.Renew;
                    _NewLicense.CreatedByUserID = clsGlobalSettings.User.UserID;

                    if (_NewLicense.Save())
                    {
                        clsApplications.ChangeStatusApplication(_Application.ApplicationID,
                            (byte)clsGlobalSettings.enApplicationStatus.Complated);

                        _OldLicense.IsActive = false;
                        _OldLicense.Save();

                        MessageBox.Show("The License Renew Successfuly With ID = " +
                       _NewLicense.LicenseID, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        lbRLApplicationIDValue.Text = _Application.ApplicationID.ToString();
                        lbRenewLicenseIDValue.Text = _NewLicense.LicenseID.ToString();
                        _ApplicationID = _Application.ApplicationID;

                        ctrlLicenseCard.LoadLicenseData(_OldLicense.ApplicationID);

                        lbShowNewLicenseInfo.Enabled = true;
                        btnRenew.Enabled = false;
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

        private void btnRenew_Click(object sender, EventArgs e)
        {
            RenewLicense();
        }

        private void lbShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseDetails LicenseDetails = new frmLicenseDetails(_ApplicationID);
            LicenseDetails.ShowDialog();
            LicenseDetails.Dispose();
        }

        private void lbShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicensesHistory LicensesHistory = new frmLicensesHistory(_Driver.PersonID);
            LicensesHistory.ShowDialog();
            LicensesHistory.Dispose();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
