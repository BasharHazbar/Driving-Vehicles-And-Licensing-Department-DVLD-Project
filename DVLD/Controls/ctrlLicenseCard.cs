using DVLD.Properties;
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
    public partial class ctrlLicenseCard : UserControl
    {

        private DataRow _LicenseInfo;


        public ctrlLicenseCard()
        {
            InitializeComponent();
        }

        public void LoadLicenseData(int ApplicationID)
        {
            _LicenseInfo = clsLicenses.GetLicensesInfo(ApplicationID).Rows[0];
            FillLicenseData();
        }

        void FillLicenseData()
        {

            lbClassNameValue.Text = (string)_LicenseInfo["ClassName"];

            lbNameValue.Text = (string)_LicenseInfo["FullName"];

            lbLicenseIDValue.Text = _LicenseInfo["LicenseID"].ToString();

            lbIssueDateValue.Text = (string)_LicenseInfo["IssueDate"];

            lbNationalNoValue.Text = (string)_LicenseInfo["NationalNo"];

            lbDateOfBirthValue.Text = (string)_LicenseInfo["DateOfBirth"];

            lbIssueReasonValue.Text = (string)_LicenseInfo["IssueReason"];

            lbNotesValue.Text = (string)_LicenseInfo["Notes"];

            lbIsActiveValue.Text = (string)_LicenseInfo["IsActive"];

            lbExpirationDateValue.Text = (string)_LicenseInfo["ExpirationDate"];

            lbDriverIDValue.Text = _LicenseInfo["DriverID"].ToString();

            lbGendorValue.Text = (string)_LicenseInfo["Gendor"];

            if ((string)_LicenseInfo["Gendor"] == "Male")
            {
               pbPersonImage.Image = Resources.Person_Male;

            }
            else
            {
               pbPersonImage.Image = Resources.Person_Female;

            }

            lbIsDetainedValue.Text = "No";

            if (_LicenseInfo["ImagePath"] != null)
            {
                pbPersonImage.Load(_LicenseInfo["ImagePath"].ToString());
            }
        }

        public void ResetLicenseData()
        {
            lbClassNameValue.Text = "[????]";

            lbNameValue.Text = "[????]";

            lbLicenseIDValue.Text = "[????]";

            lbIssueDateValue.Text = "[????]";

            lbNationalNoValue.Text = "[????]";

            lbDateOfBirthValue.Text = "[????]";

            lbDateOfBirthValue.Text = "[????]";

            lbIssueReasonValue.Text = "[????]";

            lbNotesValue.Text = "[????]";

            lbIsActiveValue.Text = "[????]";

            lbExpirationDateValue.Text = "[????]";

            lbDriverIDValue.Text = "[????]";

            lbGendorValue.Text = "[????]";

            lbIsDetainedValue.Text = "[????]";

            pbPersonImage.Image = Resources.Person_Male;
        }
    }
}
