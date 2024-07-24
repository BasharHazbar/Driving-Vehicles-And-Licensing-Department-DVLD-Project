using DVLD.Application_Types;
using DVLD.Local_Driving_Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsmLocalDrivingLicense2_Click(object sender, EventArgs e)
        {
            frmLocalLicenseApplicationsManagement LocalLicenseApplicationsManagement
                = new frmLocalLicenseApplicationsManagement();
            LocalLicenseApplicationsManagement.ShowDialog();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void tsmLocalDrivingLicense_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicense LocalDrivingLicense = new 
                frmNewLocalDrivingLicense(-1,(byte)clsGlobalSettings.enApplicationTypes.NewLocalDrivingLicense);
            LocalDrivingLicense.ShowDialog();
        }

        private void tsmDriversManagement_Click(object sender, EventArgs e)
        {
            frmDriversManagement DriversManagement = new frmDriversManagement();
            DriversManagement.ShowDialog();
        }

        private void tsmManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmApplicationTypesManagement ApplicationTypesManagement = new frmApplicationTypesManagement();
            ApplicationTypesManagement.ShowDialog();
        }

        private void tsmManageTestTypes_Click(object sender, EventArgs e)
        {
            frmTestTypesManagement  TestTypesManagement = new frmTestTypesManagement();
            TestTypesManagement.ShowDialog();
        }
    }
}
