using DVLD.Local_Driving_Licenses;
using DVLD.People;
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
    public partial class ctrlApplicationCard : UserControl
    {

        private DataRow _ApplicationInfo;

        private int _ApplicationID;
        public ctrlApplicationCard()
        {
            InitializeComponent();
        }

        public int LoadApplicationData(int ApplicationID)
        {
            _ApplicationInfo = clsApplications.GetApplicationInfo(ApplicationID).Rows[0];

            _ApplicationID = (int)_ApplicationInfo["ID"];

            if (_ApplicationInfo != null)
            {
                FillApplicationData();
                lbShowLicenseInfo.Enabled = clsLicenses.isExist(_ApplicationID);
                return _ApplicationID;
            }
            else
            {
                MessageBox.Show("NO Application With ID = " + ApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetApplicationData();
                return -1;
            }


        }


        void FillApplicationData()
        {
            lbLDLAppIDValue.Text = _ApplicationInfo["L.D.L.AppID"].ToString();

            lbLicenseClassValue.Text = (string)_ApplicationInfo["ClassName"];

            lbPassedTestValue.Text = (_ApplicationInfo["Passed Test"] + "/3");

            lbIDValue.Text = _ApplicationInfo["ID"].ToString();

            lbStatusValue.Text = (string)_ApplicationInfo["Status"];

            lbFeesValue.Text = Convert.ToInt16(_ApplicationInfo["Fees"]).ToString();

            lbTypeValue.Text = (string)_ApplicationInfo["Type"];

            lbApplicantValue.Text = (string)_ApplicationInfo["Applicant"];

            lbDateValue.Text = _ApplicationInfo["Date"].ToString();

            lbStatusDateValue.Text = _ApplicationInfo["Status Date"].ToString();

            lbCreatedByValue.Text = (string)_ApplicationInfo["User Name"];
        }

        void ResetApplicationData()
        {
            lbLDLAppIDValue.Text = "N/A";

            lbLicenseClassValue.Text = "[????]";

            lbPassedTestValue.Text = "[????]";

            lbIDValue.Text = "N/A";

            lbStatusValue.Text = "[????]";

            lbFeesValue.Text = "[????]";

            lbTypeValue.Text = "[????]";

            lbApplicantValue.Text = "[????]";

            lbDateValue.Text = "[????]";

            lbStatusDateValue.Text = "[????]";

            lbCreatedByValue.Text = "[????]";
        }

        private void lbShowPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmPersonDetails frmPersonDetails = new frmPersonDetails((int)_ApplicationInfo["PersonID"]);
            frmPersonDetails.ShowDialog();
            frmPersonDetails.Dispose();

        }

        private void lbShowLicenseInfo_Click(object sender, EventArgs e)
        {
            frmLicenseDetails LicenseDetails = new frmLicenseDetails(_ApplicationID);
            LicenseDetails.ShowDialog();
            LicenseDetails.Dispose();
        }
    }
}
