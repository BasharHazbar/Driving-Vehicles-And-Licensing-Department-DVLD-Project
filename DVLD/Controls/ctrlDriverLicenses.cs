using DVLD.International_Driving_License;
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

namespace DVLD.Controls
{
    public partial class ctrlDriverLicenses : UserControl
    {
     
        private DataTable _LocalLicensesList, _InternationalLicensesList;
        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }


        public void LoadDriverLicensesData(int PersonID)
        {
            _LocalLicensesList = clsLicenses.GetLicensesListByPersonID(PersonID);

            dgvLocalDrivingLicensesList.DataSource = _LocalLicensesList;

            lbLocalRecordsCountValue.Text = _LocalLicensesList.Rows.Count.ToString();

            _InternationalLicensesList = clsInternationalLicenses.GetInternationalLicensesListByPersonID(PersonID);

            dgvInternationalDrivingLicensesList.DataSource = _InternationalLicensesList;

            lbInternationalRecordsCountValue.Text = _InternationalLicensesList.Rows.Count.ToString();

        }

        private void dgvLocalDrivingLicensesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmLicenseDetails LicenseDetails = new frmLicenseDetails((int)dgvLocalDrivingLicensesList.CurrentRow.Cells[1].Value);
            LicenseDetails.ShowDialog();
            LicenseDetails.Dispose();
        }

        private void tsmShowLocalLicenseDetails_Click(object sender, EventArgs e)
        {
            frmLicenseDetails LicenseDetails = new frmLicenseDetails((int)dgvLocalDrivingLicensesList.CurrentRow.Cells[1].Value);
            LicenseDetails.ShowDialog();
            LicenseDetails.Dispose();
        }

        private void tsmShowIntLicenseDetails_Click(object sender, EventArgs e)
        {
            frmIntLicenseDetails LicenseDetails = new frmIntLicenseDetails((int)dgvInternationalDrivingLicensesList.CurrentRow.Cells[0].Value);
            LicenseDetails.ShowDialog();
            LicenseDetails.Dispose();
        }

        private void dgvInternationalDrivingLicensesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmIntLicenseDetails LicenseDetails = new frmIntLicenseDetails((int)dgvInternationalDrivingLicensesList.CurrentRow.Cells[0].Value);
            LicenseDetails.ShowDialog();
            LicenseDetails.Dispose();
        }


    }
}
