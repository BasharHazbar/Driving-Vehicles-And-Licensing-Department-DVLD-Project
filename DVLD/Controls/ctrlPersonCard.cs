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
    public partial class ctrlPersonCard : UserControl
    {
        private clsPeople _Person;
        public ctrlPersonCard()
        {
            InitializeComponent();

        }

        public int LoadPersonData(int PersonID)
        {
            _Person = clsPeople.Find(PersonID);

            if (_Person != null)
            {
                FillPersonData();
                return _Person.PersonID;
            }
            else
            {
                MessageBox.Show("NO Person With ID = " + PersonID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetPersonData();
                return -1;
            }
        }


        public int LoadPersonData(string NationalNo)
        {
            _Person = clsPeople.Find(NationalNo);

            if (_Person != null)
            {
                FillPersonData();
                return _Person.PersonID;
            }
            else
                MessageBox.Show("NO Person With National No = " + NationalNo, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ResetPersonData();
            return -1;

        }

        void FillPersonData()
        {

            lbPersonIDValue.Text = _Person.PersonID.ToString();

            lbNameValue.Text = _Person.getFullName();

            lbNationalNOValue.Text = _Person.NationalNo;

            lbEmailValue.Text = _Person.Email;

            if (_Person.Gendor == 0)
            {
                lbGendorValue.Text = "Male";
                pbPersonImage.Image = Resources.Person_Male;

            }
            else
            {
                lbGendorValue.Text = "Female";
                pbPersonImage.Image = Resources.Person_Female;

            }

            lbAddressValue.Text = _Person.Address;

            lbDateOfBirthValue.Text = _Person.DateOfBirth.ToString("MM/dd/yyyy");

            lbPhoneValue.Text = _Person.Phone;

            lbCountryValue.Text = clsCountries.Find(_Person.NationalityCountryID).CountryName;

            if (_Person.ImagePath != "")
            {
                pbPersonImage.Load(_Person.ImagePath);
            }


        }

        void ResetPersonData()
        {
            lbPersonIDValue.Text = "[????]";

            lbNameValue.Text = "[????]";

            lbNationalNOValue.Text = "[????]";

            lbEmailValue.Text = "[????]";

            lbGendorValue.Text = "[????]";

            lbAddressValue.Text = "[????]";

            lbDateOfBirthValue.Text = "[????]";

            lbPhoneValue.Text = "[????]";

            lbCountryValue.Text = "[????]";

            pbPersonImage.Image = Resources.Person_Male;
        }

        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {
            ResetPersonData();
        }

        private void frmAddEditPerson_dataBack(object sender, int PersonID)
        {
            LoadPersonData(PersonID);
        }

        private void lbEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
/*            if (_Person != null)
            {
                frmAddEditPerson frmAddEditPerson = new frmAddEditPerson(_Person.PersonID);
                frmAddEditPerson.DataBack += frmAddEditPerson_dataBack;
                frmAddEditPerson.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is No Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}
