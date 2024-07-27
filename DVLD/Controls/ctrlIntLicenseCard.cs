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
    public partial class ctrlIntLicenseCard : UserControl
    {
        public ctrlIntLicenseCard()
        {
            InitializeComponent();
        }
        private DataRow _IntLicenseInfo;

        public void LoadLInticenseData(int InternationalLicenseID)
        {
            _IntLicenseInfo = clsInternationalLicenses.GetInternationalLicensesInfo(InternationalLicenseID).Rows[0];

            if (_IntLicenseInfo == null)
            {
                ResetIntLicenseData();
                return;
            }
           

            FillIntLicenseData();
        }

        void FillIntLicenseData()
        {

            lbNameValue.Text = (string)_IntLicenseInfo["FullName"];

            lbApplicationIDValue.Text = _IntLicenseInfo["ApplicationID"].ToString();

            lbLicenseIDValue.Text = _IntLicenseInfo["LicenseID"].ToString();

            lbIntLicenseIDValue.Text = _IntLicenseInfo["InternationalLicenseID"].ToString();

            lbIssueDateValue.Text = (string)_IntLicenseInfo["IssueDate"];

            lbNationalNoValue.Text = (string)_IntLicenseInfo["NationalNo"];

            lbDateOfBirthValue.Text = (string)_IntLicenseInfo["DateOfBirth"];

            lbIsActiveValue.Text = (string)_IntLicenseInfo["IsActive"];

            lbExpirationDateValue.Text = (string)_IntLicenseInfo["ExpirationDate"];

            lbDriverIDValue.Text = _IntLicenseInfo["DriverID"].ToString();

            lbGenderValue.Text = (string)_IntLicenseInfo["Gender"];

            if ((string)_IntLicenseInfo["Gender"] == "Male")
            {
                pbPersonImage.Image = Resources.Person_Male;

            }
            else
            {
                pbPersonImage.Image = Resources.Person_Female;

            }

            if (_IntLicenseInfo["ImagePath"] != null)
            {
                pbPersonImage.Load(_IntLicenseInfo["ImagePath"].ToString());
            }
        }

         void ResetIntLicenseData()
        {

            lbNameValue.Text = "[????]";

            lbLicenseIDValue.Text = "[????]";

            lbIssueDateValue.Text = "[????]";

            lbNationalNoValue.Text = "[????]";

            lbDateOfBirthValue.Text = "[????]";

            lbDateOfBirthValue.Text = "[????]";

            lbIsActiveValue.Text = "[????]";

            lbExpirationDateValue.Text = "[????]";

            lbDriverIDValue.Text = "[????]";

            pbPersonImage.Image = Resources.Person_Male;
        }
    }
}
