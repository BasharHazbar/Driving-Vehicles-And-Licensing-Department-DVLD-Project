using DVLD.Application_Types;
using DVLD.International_Driving_License;
using DVLD.Local_Driving_Licenses;
using DVLD.People;
using DVLD.Renew_Local_Driving_License;
using DVLD.Replacement_Local_Driving_License;
using DVLD.Users;
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

            this.BackgroundImage = Properties.Resources.Main_Background_3; // Replace with your image name
            this.BackgroundImageLayout = ImageLayout.Stretch; // Adjust the layout as needed

            // Add Paint event handler for semi-transparent overlay
            this.Paint += new PaintEventHandler(frmMain_Paint);
        }

        private void tsmLocalDrivingLicense2_Click(object sender, EventArgs e)
        {
            frmLocalLicenseApplicationsManagement LocalLicenseApplicationsManagement
                = new frmLocalLicenseApplicationsManagement();
            LocalLicenseApplicationsManagement.ShowDialog();
            LocalLicenseApplicationsManagement.Dispose();

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
            LocalDrivingLicense.Dispose();
        }

        private void tsmDriversManagement_Click(object sender, EventArgs e)
        {
            frmDriversManagement DriversManagement = new frmDriversManagement();
            DriversManagement.ShowDialog();
            DriversManagement.Dispose();
        }

        private void tsmManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmApplicationTypesManagement ApplicationTypesManagement = new frmApplicationTypesManagement();
            ApplicationTypesManagement.ShowDialog();
            ApplicationTypesManagement.Dispose();
        }

        private void tsmManageTestTypes_Click(object sender, EventArgs e)
        {
            frmTestTypesManagement  TestTypesManagement = new frmTestTypesManagement();
            TestTypesManagement.ShowDialog();
            TestTypesManagement.Dispose();
        }

        private void tsmPeopleManagement_Click(object sender, EventArgs e)
        {
            frmPeopleManagement PeopleManagement = new frmPeopleManagement();   
            PeopleManagement.ShowDialog();
            PeopleManagement.Dispose(); 
        }

        private void tsmUsersManagement_Click(object sender, EventArgs e)
        {
            frmUsersManagement UsersManagement = new frmUsersManagement();
            UsersManagement.ShowDialog();
            UsersManagement.Dispose();
        }

        private void tsmCurrentUser_Click(object sender, EventArgs e)
        {
            frmUserDetails UserDetails = new frmUserDetails(clsGlobalSettings.User.UserID);
            UserDetails.ShowDialog();
            UserDetails.Dispose();
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword ChangePassword = new frmChangePassword(clsGlobalSettings.User.UserID);
            ChangePassword.ShowDialog();
            ChangePassword.Dispose();
        }

        private void tsmInternationalDrivingLicense2_Click(object sender, EventArgs e)
        {
            frmIssueInternationalDrivingLicense IssueInternationalDrivingLicense = new frmIssueInternationalDrivingLicense();
            IssueInternationalDrivingLicense.ShowDialog();
            IssueInternationalDrivingLicense.Dispose();
        }

        private void tsmLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin Login = new frmLogin();  
            Login.Show();
            Login.Dispose();
        }

        private void tsmInternationalDrivingLicense_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseManagement LicenseManagement = new frmInternationalLicenseManagement();  
            LicenseManagement.ShowDialog();
            LicenseManagement.Dispose();
        }

        private void tsmRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicense RenewLocalDrivingLicense = new frmRenewLocalDrivingLicense();
            RenewLocalDrivingLicense.ShowDialog();
            RenewLocalDrivingLicense.Dispose();
        }

        private void tsmReplacementForADamageOrLostDrivingLicense_Click(object sender, EventArgs e)
        {
            frmReplacementForDamageOrLostLocalLicense ReplacementForDamageOrLostLocalLicense = 
                new frmReplacementForDamageOrLostLocalLicense();
            ReplacementForDamageOrLostLocalLicense.ShowDialog();
            ReplacementForDamageOrLostLocalLicense.Dispose();
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            using (Brush brush = new SolidBrush(Color.FromArgb(150, Color.White))) 
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
