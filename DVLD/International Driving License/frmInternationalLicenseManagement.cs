using DVLD.Licenses_History;
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

namespace DVLD.International_Driving_License
{
    public partial class frmInternationalLicenseManagement : Form
    {

        private DataView IntLicensesView;
        public frmInternationalLicenseManagement()
        {
            InitializeComponent();
        }

   
        void GetIntLicensesListWithFilter()
        {
            IntLicensesView = new DataView(clsInternationalLicenses.GetIntLicensesList());

            Filter(tbFilterBy.Text);

            dgvIntLicensesList.DataSource = IntLicensesView;
            dgvIntLicensesList.Columns["PersonID"].Visible = false;
            lbRecordsCountValue.Text = IntLicensesView.Count.ToString();
        }


        void Filter(string FilterValue)
        {

            if (clsGlobalSettings.IsEmpty(FilterValue) && cbFindByIsActive.Text == "None")
            {
                return;
            }

            switch (cbFilterBy.Text)
            {
                case "Int.License ID":
                    IntLicensesView.RowFilter = "[Int.License ID] = " + clsGlobalSettings.TryParse(FilterValue);
                    break;
                case "Application ID":
                    IntLicensesView.RowFilter = "[Application ID] = " + clsGlobalSettings.TryParse(FilterValue);
                    break;
                case "Driver ID":
                    IntLicensesView.RowFilter = "[Driver ID] = " + clsGlobalSettings.TryParse(FilterValue);
                    break;
                case "L.License ID":
                    IntLicensesView.RowFilter = "[L.License ID] = " + clsGlobalSettings.TryParse(FilterValue);
                    break;
                case "Is Active":
                    switch (cbFindByIsActive.Text)
                    {
                        case "Yes":
                            IntLicensesView.RowFilter = "[Is Active] = " + 1;
                            break;
                        case "No":
                            IntLicensesView.RowFilter = "[Is Active] = " + 0;
                            break;
                    }
                    break;
                default:
                    IntLicensesView.RowFilter = "";
                    break;
            }

        }

        private void frmInternationalLicenseManagement_Load(object sender, EventArgs e)
        {
            tbFilterBy.Visible = false;
            cbFilterBy.SelectedIndex = 0;
            cbFindByIsActive.SelectedIndex = 0;
            GetIntLicensesListWithFilter();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterBy.Text = string.Empty;

            if (cbFilterBy.Text == "None")
            {
                tbFilterBy.Visible = false;
                cbFindByIsActive.Visible = false;
            }
            else if (cbFilterBy.Text == "Is Active")
            {
                tbFilterBy.Visible = false;
                cbFindByIsActive.Visible = true;
            }
            else
            {
                tbFilterBy.Visible = true;
                cbFindByIsActive.Visible = false;
            }
            GetIntLicensesListWithFilter();
        }

        private void tbFilterBy_KeyUp(object sender, KeyEventArgs e)
        {
            GetIntLicensesListWithFilter();
        }

        private void cbFindByIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetIntLicensesListWithFilter();
        }

        private void pbAddNewIntLicense_Click(object sender, EventArgs e)
        {
            frmIssueInternationalDrivingLicense IssueInternationalDrivingLicense = new frmIssueInternationalDrivingLicense(); ;
            IssueInternationalDrivingLicense.ShowDialog();
            IssueInternationalDrivingLicense.Dispose();
            GetIntLicensesListWithFilter();
        }

        private void tsmShowPersonDetails_Click(object sender, EventArgs e)
        {
           
            frmPersonDetails PersonDetails = new frmPersonDetails((int)dgvIntLicensesList.CurrentRow.Cells[4].Value);
            PersonDetails.ShowDialog();
            PersonDetails.Dispose();

        }

        private void tsmShowLicenseDetails_Click(object sender, EventArgs e)
        {
            frmIntLicenseDetails IntLicenseDetails = new frmIntLicenseDetails((int)dgvIntLicensesList.CurrentRow.Cells[0].Value);
            IntLicenseDetails.ShowDialog();
            IntLicenseDetails.Dispose();
        }

        private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            frmLicensesHistory LicensesHistory = new frmLicensesHistory((int)dgvIntLicensesList.CurrentRow.Cells[4].Value);
            LicensesHistory.ShowDialog();
            LicensesHistory.Dispose();
        }
    }
}
