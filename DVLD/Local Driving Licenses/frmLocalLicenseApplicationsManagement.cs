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

namespace DVLD.Local_Driving_Licenses
{
    public partial class frmLocalLicenseApplicationsManagement : Form
    {
        private DataView LocalLicenseApplicationsView;
        public frmLocalLicenseApplicationsManagement()
        {
            InitializeComponent();
        }

        void GetApplicationsListWithFilter()
        {
            LocalLicenseApplicationsView = new DataView(clsApplications.GetApplicationsList());

            Filter(tbFilter.Text);

            dgvLocalLicenseApplicationsList.DataSource = LocalLicenseApplicationsView;

            dgvLocalLicenseApplicationsList.Columns["PersonID"].Visible = false; //  index = 1
            dgvLocalLicenseApplicationsList.Columns["ApplicationID"].Visible = false;//  index = 2
            dgvLocalLicenseApplicationsList.Columns["LicenseClassID"].Visible = false; //  index = 3


            lbRecordsCountValue.Text = LocalLicenseApplicationsView.Count.ToString();
        }


        void Filter(string FilterValue)
        {
            if (FilterValue == string.Empty)
            {
                return;
            }

            dgvLocalLicenseApplicationsList.DataSource = null;

            switch (cbFilter.Text)
            {
                case "L.D.L.AppID":
                    LocalLicenseApplicationsView.RowFilter = "[L.D.L.AppID] = " + clsGlobalSettings.TryParse(FilterValue);
                    break;
                case "Driving Class":
                    LocalLicenseApplicationsView.RowFilter = "[Driving Class] LIKE '%" + FilterValue + "%'";
                    break;
                case "National No":
                    LocalLicenseApplicationsView.RowFilter = "[National No.] LIKE '%" + FilterValue + "%'";
                    break;
                case "Full Name":
                    LocalLicenseApplicationsView.RowFilter = "[Full Name] LIKE '%" + FilterValue + "%'";
                    break;
                case "Status":
                    LocalLicenseApplicationsView.RowFilter = "Status LIKE '%" + FilterValue + "%'";
                    break;
                case "Passed Test":
                    LocalLicenseApplicationsView.RowFilter = "[Passed Test] =  " + clsGlobalSettings.TryParse(FilterValue);
                    break;
                default:
                    LocalLicenseApplicationsView.RowFilter = "";
                    break;
            }

        }

        private bool isPassedTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointments.isPassedTest(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        private void frmLocalLicenseApplicationsManagement_Load(object sender, EventArgs e)
        {
            GetApplicationsListWithFilter();
            cbFilter.SelectedIndex = 0;
            tbFilter.Visible = false;
            tsmIssueDrivingLicenseFirstTime.Enabled = true;
            tsmWrittenTest.Enabled = true;
            tsmStreetTest.Enabled = true;
        }
  

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            tbFilter.Text = string.Empty;
            if (cbFilter.Text == "None")
            {
                tbFilter.Visible = false;
            }
            else
            {
                tbFilter.Visible = true;
            }
            GetApplicationsListWithFilter();
        }

        private void tbFilter_KeyUp(object sender, KeyEventArgs e)
        {
            GetApplicationsListWithFilter();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAddNewLocalLicenseApplication_Click(object sender, EventArgs e)
        {
      
            frmNewLocalDrivingLicense frmNewLocalDrivingLicense = new frmNewLocalDrivingLicense(-1,
                (byte)clsGlobalSettings.enApplicationTypes.NewLocalDrivingLicense);
            frmNewLocalDrivingLicense.ShowDialog();
            frmNewLocalDrivingLicense.Dispose();
            GetApplicationsListWithFilter();
        }

        private void tsmEditApplication_Click(object sender, EventArgs e)
        {
            //clsLocalDrivingLicenseApplications.FindByLocalDrivingLicenseApplicationID
            // ((int)dgvApplicationsList.CurrentRow.Cells[0].Value).ApplicationID
            frmNewLocalDrivingLicense frmNewLocalDrivingLicense = new
                frmNewLocalDrivingLicense(((int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[2].Value),
                (byte)clsGlobalSettings.enApplicationTypes.NewLocalDrivingLicense);
            frmNewLocalDrivingLicense.ShowDialog();
            frmNewLocalDrivingLicense.Dispose();
            GetApplicationsListWithFilter();
        }

        private void tsmDeleteApplication_Click(object sender, EventArgs e)
        {
            int ApplicationID = ((int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[2].Value);

            if (MessageBox.Show("Are you sure to delete Application with ID =  [" + ApplicationID + "]",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                if (clsLocalDrivingLicenseApplications.DeleteByApplicationID(ApplicationID) &&
                    clsApplications.Delete(ApplicationID))
                {
                    MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    GetApplicationsListWithFilter();
                }

                else
                    MessageBox.Show("Application is not deleted..", "Not Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


            }
        }

        private void tsmCancelApplication_Click(object sender, EventArgs e)
        {

            int ApplicationID = ((int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[2].Value);

            if (MessageBox.Show("Are you sure to Cancel Application with ID =  [" + ApplicationID + "]",
                "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (clsApplications.ChangeStatusApplication(ApplicationID, (byte)clsGlobalSettings.enApplicationStatus.Canceled))
                {
                    MessageBox.Show("Application Canceld Successfully.", "Cancled", MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                    GetApplicationsListWithFilter();
                }
                else
                    MessageBox.Show("Application Not Canceld.", "Not Cancled", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);

            }

        }

        private void dgvLocalLicenseApplicationsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmLocalLicenseApplicationDetails LocalLicenseApplicationDetails = new
                frmLocalLicenseApplicationDetails(((int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[2].Value));
            LocalLicenseApplicationDetails.ShowDialog();
            LocalLicenseApplicationDetails.Dispose();
        }

        private void tsmShowApplicationDetails_Click(object sender, EventArgs e)
        {
            frmLocalLicenseApplicationDetails LocalLicenseApplicationDetails = new
                frmLocalLicenseApplicationDetails(((int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[2].Value));
            LocalLicenseApplicationDetails.ShowDialog();
            LocalLicenseApplicationDetails.Dispose();
        }

        private void tsmVisionTest_Click(object sender, EventArgs e)
        {
            frmTestApointmentsManagement TestApointmentsManagement = new frmTestApointmentsManagement((int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[0].Value
                , (int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[2].Value
                , (byte)clsGlobalSettings.enTestTypes.VisionTest);

            TestApointmentsManagement.ShowDialog();
            TestApointmentsManagement.Dispose();
            GetApplicationsListWithFilter();

        }

        private void tsmWrittenTest_Click(object sender, EventArgs e)
        {
            frmTestApointmentsManagement TestApointmentsManagement = new frmTestApointmentsManagement((int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[0].Value
                , (int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[2].Value
                , (byte)clsGlobalSettings.enTestTypes.WrittenTest);

            TestApointmentsManagement.ShowDialog();
            TestApointmentsManagement.Dispose();
            GetApplicationsListWithFilter();
        }
        private void tsmStreetTest_Click(object sender, EventArgs e)
        {
            frmTestApointmentsManagement TestApointmentsManagement = new frmTestApointmentsManagement((int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[0].Value
                , (int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[2].Value
                , (byte)clsGlobalSettings.enTestTypes.StreetTest);

            TestApointmentsManagement.ShowDialog();
            TestApointmentsManagement.Dispose();
            GetApplicationsListWithFilter();
        }


        private void cmsApplicationsManageMenu_Opening(object sender, CancelEventArgs e)
        {
            tsmEditApplication.Enabled = true;
            tsmDeleteApplication.Enabled = true;
            tsmCancelApplication.Enabled = true;
            tsmScheduleTest.Enabled = true;
            tsmVisionTest.Enabled = true;
            tsmWrittenTest.Enabled = false;
            tsmStreetTest.Enabled = false;
            tsmIssueDrivingLicenseFirstTime.Enabled = false;
            tsmShowLicense.Enabled = false;

            if (isPassedTest((int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[0].Value, (byte)clsGlobalSettings.enTestTypes.VisionTest))
            {
                tsmVisionTest.Enabled = false;
                tsmWrittenTest.Enabled = true;
            }

            if (isPassedTest((int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[0].Value, (byte)clsGlobalSettings.enTestTypes.WrittenTest))
            {
                tsmWrittenTest.Enabled = false;
                tsmStreetTest.Enabled = true;
            }

            if (isPassedTest((int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[0].Value, (byte)clsGlobalSettings.enTestTypes.StreetTest))
            {
                tsmStreetTest.Enabled = false;
                tsmScheduleTest.Enabled = false;
                tsmIssueDrivingLicenseFirstTime.Enabled = true;
            }



            if (clsLicenses.IsHasIssuedLicense((int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[2].Value)
                && clsApplications.PassedTestCount((int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[0].Value) == 3)
            {
                tsmIssueDrivingLicenseFirstTime.Enabled = false;
                tsmEditApplication.Enabled = false;
                tsmDeleteApplication.Enabled = false;
                tsmCancelApplication.Enabled = false;
                tsmScheduleTest.Enabled = false;
                tsmShowLicense.Enabled = true;
            }
        }

        private void tsmIssueDrivingLicenseFirstTime_Click(object sender, EventArgs e)
        {
            frmIssueDrivingLicense issueDrivingLicense = new frmIssueDrivingLicense((int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[1].Value,
               (int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[2].Value, (int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[3].Value);

            issueDrivingLicense.ShowDialog();
            issueDrivingLicense.Dispose();
            GetApplicationsListWithFilter();
        }

        private void tsmShowLicense_Click(object sender, EventArgs e)
        {
            frmLicenseDetails LicenseDetails = new frmLicenseDetails((int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[2].Value);
            LicenseDetails.ShowDialog();
            LicenseDetails.Dispose();
        }

        private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            frmLicensesHistory LicensesHistory = new frmLicensesHistory((int)dgvLocalLicenseApplicationsList.CurrentRow.Cells[1].Value);

            LicensesHistory.ShowDialog();
            LicensesHistory.Dispose();
        }

       
    }
}
