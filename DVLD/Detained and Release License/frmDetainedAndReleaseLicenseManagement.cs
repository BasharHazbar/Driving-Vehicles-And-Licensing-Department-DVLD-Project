using DVLD.Licenses_History;
using DVLD.Local_Driving_Licenses;
using DVLD.People;
using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVLD.Detained_and_Release_License
{
    public partial class frmDetainedAndReleaseLicenseManagement : Form
    {
        private DataView DetainedLicenseView;
        public frmDetainedAndReleaseLicenseManagement()
        {
            InitializeComponent();
        }
        void GetDetainedLicensesListWithFilter()
        {
            DetainedLicenseView = new DataView(clsDetainedLicenses.GetDetainedAndReleaseLicenseList());

            Filter(tbFilterBy.Text);

            dgvDetainedLicenseList.DataSource = DetainedLicenseView;
            dgvDetainedLicenseList.Columns["PersonID"].Visible = false; // index 0
            dgvDetainedLicenseList.Columns["ApplicationID"].Visible = false; // index 1
            dgvDetainedLicenseList.Columns["LicenseID"].Visible = false; // index 2
            lbRecordsCountValue.Text = DetainedLicenseView.Count.ToString();
        }


        void Filter(string FilterValue)
        {

            if (clsGlobalSettings.IsEmpty(FilterValue) && cbFindByIsRelease.Text == "None")
            {
                return;
            }

            switch (cbFilterBy.Text)
            {
                case "Detained ID":
                    DetainedLicenseView.RowFilter = "[D ID] = " + clsGlobalSettings.TryParse(FilterValue);
                    break;
                case "Is Released":
                    switch (cbFindByIsRelease.Text)
                    {
                        case "Yes":
                            DetainedLicenseView.RowFilter = "[Is Released] = " + 1;
                            break;
                        case "No":
                            DetainedLicenseView.RowFilter = "[Is Released] = " + 0;
                            break;
                    }
                    break;
                case "National No":
                    DetainedLicenseView.RowFilter = "[N No] LIKE '%" + FilterValue + "%'";
                    break;
                case "Full Name":
                    DetainedLicenseView.RowFilter = "[Full Name] LIKE '%" + FilterValue + "%'";
                    break;
                case "Release Application ID":
                    DetainedLicenseView.RowFilter = "[Release App ID] = " + clsGlobalSettings.TryParse(FilterValue);
                    break;
                default:
                    DetainedLicenseView.RowFilter = "";
                    break;
            }

        }
        private void frmDetainedAndReleaseLicenseManagement_Load(object sender, EventArgs e)
        {
            tbFilterBy.Visible = false;
            cbFilterBy.SelectedIndex = 0;
            cbFindByIsRelease.SelectedIndex = 0;
            GetDetainedLicensesListWithFilter();
        }

        private void pbDetainedLicense_Click(object sender, EventArgs e)
        {
            frmDetainedLicense DetainedLicense = new frmDetainedLicense();
            DetainedLicense.ShowDialog();
            DetainedLicense.Dispose();
            GetDetainedLicensesListWithFilter();
        }

        private void pbReleaseLicense_Click(object sender, EventArgs e)
        {
            frmReleaseLicense ReleaseLicense = new frmReleaseLicense(-1);
            ReleaseLicense.ShowDialog();
            ReleaseLicense.Dispose();

            GetDetainedLicensesListWithFilter();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFilterBy_KeyUp(object sender, KeyEventArgs e)
        {
            GetDetainedLicensesListWithFilter();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterBy.Text = string.Empty;

            if (cbFilterBy.Text == "None")
            {
                tbFilterBy.Visible = false;
                cbFindByIsRelease.Visible = false;
            }
            else if (cbFilterBy.Text == "Is Released")
            {
                tbFilterBy.Visible = false;
                cbFindByIsRelease.Visible = true;
            }
            else
            {
                tbFilterBy.Visible = true;
                cbFindByIsRelease.Visible = false;
            }
            GetDetainedLicensesListWithFilter();
        }

        private void tsmShowPersonDetails_Click(object sender, EventArgs e)
        {
            frmPersonDetails PersonDetails = new frmPersonDetails((int)dgvDetainedLicenseList.CurrentRow.Cells[0].Value);
            PersonDetails.ShowDialog();
            PersonDetails.Dispose();
        }

        private void tsmShowLicenseDetails_Click(object sender, EventArgs e)
        {
            frmLicenseDetails LicenseDetails = new frmLicenseDetails((int)dgvDetainedLicenseList.CurrentRow.Cells[1].Value);
            LicenseDetails.ShowDialog();
            LicenseDetails.Dispose();
        }

        private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            frmLicensesHistory LicensesHistory = new frmLicensesHistory((int)dgvDetainedLicenseList.CurrentRow.Cells[0].Value);
            LicensesHistory.ShowDialog();
            LicensesHistory.Dispose();
        }

        private void tsmReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseLicense ReleaseLicense = new frmReleaseLicense((int)dgvDetainedLicenseList.CurrentRow.Cells[2].Value);
            ReleaseLicense.ShowDialog();
            ReleaseLicense.Dispose();
            GetDetainedLicensesListWithFilter();
        }

        private void cbFindByIsRelease_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDetainedLicensesListWithFilter();
        }

        private void cmsDetainedLicenseManagement_Opening(object sender, CancelEventArgs e)
        {
            if (!clsLicenses.IsDetainedLicense((int)dgvDetainedLicenseList.CurrentRow.Cells[2].Value))
            {
                tsmReleaseDetainedLicense.Enabled = false;
            }
            else
                tsmReleaseDetainedLicense.Enabled = true;

        }
    }
}
