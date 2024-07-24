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
    public partial class frmNewLocalDrivingLicense : Form
    {
        private enum enMode { AddApplication = 0, UpdateApplication = 1 };

        private enMode _Mode;

        private int _ApplicationID;

        private byte _ApplicationTypeID;

        private clsApplications _Application;

        private clsLocalDrivingLicenseApplications _LocalDrivingLicenseApplications;

        private clsApplicationTypes _ApplicationType;

        public frmNewLocalDrivingLicense(int ApplicationID, byte ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationID = ApplicationID;
            _ApplicationTypeID = ApplicationTypeID;

            if (_ApplicationID == -1)
            {
                _Mode = enMode.AddApplication;
            }
            else
            {
                _Mode = enMode.UpdateApplication;
            }
        }

        void _FillComboboxLicenseClasses()
        {
            DataTable dt = clsLicenseClasses.GetLicenseClassesList();

            foreach (DataRow LicenseClasses in dt.Rows)
            {
                cbLicenseClasses.Items.Add(LicenseClasses["ClassName"]);
            }
        }

        void LoadData()
        {
            _ApplicationType = clsApplicationTypes.Find(_ApplicationTypeID);
            lbApplicationDateValue.Text = DateTime.Now.ToString("MM/dd/yyyy");
            _FillComboboxLicenseClasses();
            lbApplicationFeesValue.Text = Convert.ToUInt16(_ApplicationType.ApplicationFees).ToString();
            lbCreatedByValue.Text = clsGlobalSettings.User.UserName;

            if (_Mode == enMode.AddApplication)
            {

                cbLicenseClasses.SelectedIndex = 2;
                _Application = new clsApplications();
                _LocalDrivingLicenseApplications = new clsLocalDrivingLicenseApplications();
                return;
            }

            _Application = clsApplications.Find(_ApplicationID);
            _LocalDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindByApplicationID(_ApplicationID);

            if (_Application == null)
            {
                MessageBox.Show("There is No Application With ID = " + _ApplicationID, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            cbLicenseClasses.Text = clsLicenseClasses.Find(clsLocalDrivingLicenseApplications.FindByApplicationID(_ApplicationID)
                .LicenseClassID).ClassName;
            lbTitle.Text = "Update Local Driving License Applications";
            lbLDLAppIDValue.Text = _ApplicationID.ToString();

            ctrlFindPersonCard.LoadPersonData(_Application.ApplicantPersonID);

        }

        private void frmNewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {

            if (ctrlFindPersonCard.PersonID == -1)
            {
                MessageBox.Show("Please Select a Person", "Error", MessageBoxButtons.OK
                     , MessageBoxIcon.Error);
                return;
            }

            if (_Mode == enMode.AddApplication && clsApplications.isExistByPersonID(ctrlFindPersonCard.PersonID))
            {
                MessageBox.Show("Selected Person Aready Apply this License Class", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return;
            }

            tcNewLocalDrivingLicense.SelectedIndex = 1;
        }
        private void tcNewLocalDrivingLicense_Selecting(object sender, TabControlCancelEventArgs e)
        {

            if (ctrlFindPersonCard.PersonID == -1)
            {
                e.Cancel = true;
                return;
            }

            if (_Mode == enMode.AddApplication && tcNewLocalDrivingLicense.SelectedIndex == 1 &&
                 clsApplications.isExistByPersonID(ctrlFindPersonCard.PersonID))
            {
                //tcAddNewUser.SelectedIndex = 0;
                e.Cancel = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (_Mode == enMode.AddApplication)
            {

                _Application.ApplicantPersonID = ctrlFindPersonCard.PersonID;
                _Application.ApplicationDate = DateTime.Now;
                _Application.ApplicationTypeID = _ApplicationType.ApplicationTypeID;
                _Application.ApplicationStatus = 1;
                _Application.PaidFees = _ApplicationType.ApplicationFees;
                _Application.LastStatusDate = DateTime.Now;
                _Application.CreatedByUserID = clsGlobalSettings.User.UserID;
            }

            else if (_Mode == enMode.UpdateApplication)
            {
                _Application.ApplicationStatus = 1;
                _Application.LastStatusDate = DateTime.Now;
                _LocalDrivingLicenseApplications.ApplicationID = _Application.ApplicationID;

            };


            _LocalDrivingLicenseApplications.LicenseClassID = clsLicenseClasses.
                                Find(cbLicenseClasses.Text).LicenseClassID;

            if (_Mode == enMode.AddApplication && clsApplications.isExistApplicationInSameClassLicense(ctrlFindPersonCard.PersonID, cbLicenseClasses.Text))
            {
                MessageBox.Show("Choose Another License Class, The Selected Person Aready Have an Active Application " +
                    "for the selected class with id [" + ctrlFindPersonCard.PersonID + "]", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Application.Save())
            {
                _LocalDrivingLicenseApplications.ApplicationID = _Application.ApplicationID;

                if (_LocalDrivingLicenseApplications.Save())
                {
                    MessageBox.Show("Data Save Successfuly", "Saved",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Data Not Save Successfuly", "Not Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _ApplicationID = _Application.ApplicationID;
            lbLDLAppIDValue.Text = _ApplicationID.ToString();
            lbTitle.Text = "Update Local Driving License Applications";
            _Mode = enMode.UpdateApplication;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}

