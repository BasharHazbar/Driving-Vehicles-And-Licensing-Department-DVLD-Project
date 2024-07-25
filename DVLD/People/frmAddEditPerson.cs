using DVLD.Properties;
using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmAddEditPerson : Form
    {
        private enum enMode { AddPerson = 0, UpdatePerson = 1 };

        private enMode _Mode;

        private int _PersonID;

        private clsPeople _Person;
        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;

            if (PersonID == -1)
            {
                _Mode = enMode.AddPerson;
            }
            else
            {
                _Mode = enMode.UpdatePerson;
            }
        }

        public delegate void dataBackEventHandler(object sender, int PersonID);

        public event dataBackEventHandler DataBack;


        private void _FillComboBoxCountries()
        {
            DataTable dt = clsCountries.GetCountriesList();

            foreach (DataRow row in dt.Rows)
            {
                cbCountries.Items.Add(row["CountryName"]);
            }
        }
        //CancelEventArgs e
        private void Validation(CancelEventArgs e, Control control, string MessageError)
        {

            if (IsEmpty(control.Text))
            {
                e.Cancel = true;
                tbLast.Focus();
                epValidating.SetError(control, MessageError);
            }
            else
            {
                e.Cancel = false;
                epValidating.SetError(control, "");
            }
        }

        private bool IsValidEmail(string Email)
        {

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(Email, pattern);
        }

        private bool IsEmpty(string Value)
        {
            return clsGlobalSettings.IsEmpty(Value);
        }

        private bool IsEmptyFaild()
        {
            return IsEmpty(tbFirst.Text) || IsEmpty(tbSecond.Text) || IsEmpty(tbLast.Text) || IsEmpty(tbNationalNo.Text)
                || IsEmpty(dtpDataOfBirth.Text) || IsEmpty(tbPhone.Text) || IsEmpty(tbAddress.Text);
        }

        void LoadData()
        {
            _FillComboBoxCountries();
            dtpDataOfBirth.MaxDate = DateTime.Today.AddYears(-18);
            dtpDataOfBirth.MinDate = DateTime.Today.AddYears(-60);
            rbMale.Checked = true;
            cbCountries.SelectedIndex = 0;

            if (_Mode == enMode.AddPerson)
            {
                lbMode.Text = "Add New Person";
                lbRemoveImage.Visible = false;
                _Person = new clsPeople();
                return;
            }


            _Person = clsPeople.Find(_PersonID);

            lbMode.Text = "Edit Person With ID = " + _PersonID;

            lbPersonIDValue.Text = _PersonID.ToString();

            tbFirst.Text = _Person.FirstName;

            tbSecond.Text = _Person.SecondName;

            tbThird.Text = _Person.ThirdName;

            tbLast.Text = _Person.LastName;

            tbNationalNo.Text = _Person.NationalNo;

            dtpDataOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gendor == 0)
            {
                rbMale.Checked = true;
            }
            else if (_Person.Gendor == 1)
            {
                rbFemale.Checked = true;
            }

            tbPhone.Text = _Person.Phone;

            tbEmail.Text = _Person.Email;

            tbAddress.Text = _Person.Address;

            if (_Person.ImagePath != "")
            {
                pbPersonImage.Load(_Person.ImagePath);
            }
            else
            {
                lbRemoveImage.Visible = false;
            }

            cbCountries.SelectedIndex = cbCountries.FindString(
                clsCountries.Find(_Person.NationalityCountryID).CountryName);


        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lbSetImage_Click(object sender, EventArgs e)
        {
            ofdLoadingImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            ofdLoadingImage.FilterIndex = 1;
            ofdLoadingImage.RestoreDirectory = true;

            if (ofdLoadingImage.ShowDialog() == DialogResult.OK)
            {
                string fileSelect = ofdLoadingImage.FileName;
                pbPersonImage.Load(fileSelect);
                lbRemoveImage.Visible = true;
            }
        }

        private void lbRemoveImage_Click(object sender, EventArgs e)
        {
            lbRemoveImage.Visible = false;

            pbPersonImage.ImageLocation = null;

            if (rbMale.Checked)
            {
                pbPersonImage.Image = Resources.Person_Male;
            }
            if (rbFemale.Checked)
            {
                pbPersonImage.Image = Resources.Person_Female;
            }
        }
      
        private void btnSave_Click(object sender, EventArgs e)
        {
            // _Person.PersonID = _PersonID;


            if (IsEmptyFaild())
            {
                MessageBox.Show("Please Fill The Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Person.FirstName = tbFirst.Text;

            _Person.SecondName = tbSecond.Text;

            _Person.ThirdName = tbThird.Text;

            _Person.LastName = tbLast.Text;

            _Person.NationalNo = tbNationalNo.Text;

            _Person.DateOfBirth = dtpDataOfBirth.Value;

            if (rbMale.Checked)
            {
                _Person.Gendor = 0;
            }
            else if (rbFemale.Checked)
            {
                _Person.Gendor = 1;
            }
            _Person.Address = tbAddress.Text;

            _Person.Email = tbEmail.Text;



            _Person.NationalityCountryID = clsCountries.Find(cbCountries.Text).CountryID;

            _Person.Phone = tbPhone.Text;

            if (pbPersonImage.Image != Resources.Person_Male &&
               pbPersonImage.Image != Resources.Person_Female)
            {
                _Person.ImagePath = pbPersonImage.ImageLocation;
            }


            if (_Person.Save())
            {
                MessageBox.Show("Data Save Successfuly", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Save Successfuly", "Not Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            _PersonID = _Person.PersonID;

            lbPersonIDValue.Text = _PersonID.ToString();

            lbMode.Text = "Edit Person With ID = " + _PersonID.ToString();

            _Mode = enMode.UpdatePerson;

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, _PersonID);
            this.Close();

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            pbPersonImage.Image = Resources.Person_Male;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            pbPersonImage.Image = Resources.Person_Female;
        }

        private void tbFirst_Validating(object sender, CancelEventArgs e)
        {
            Validation(e, tbFirst, "First Name Should Have A Value");
        }

        private void tbSecond_Validating(object sender, CancelEventArgs e)
        {
            Validation(e, tbSecond, "Second Name Should Have A Value");
        }

        private void tbLast_Validating(object sender, CancelEventArgs e)
        {
            Validation(e, tbLast, "Last Name Should Have A Value");
        }

        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (IsEmpty(tbNationalNo.Text))
            {
                e.Cancel = true;
                tbNationalNo.Focus();
                epValidating.SetError(tbNationalNo, "NationalNo Should Have a Value");
            }
            else if (_Mode == enMode.AddPerson && clsPeople.isExist(tbNationalNo.Text))
            {
                e.Cancel = true;
                tbNationalNo.Focus();
                epValidating.SetError(tbNationalNo, "This NationalNo with another Person");
            }
            else
            {
                e.Cancel = false;
                epValidating.SetError(tbNationalNo, "");
            }
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (IsEmpty(tbPhone.Text))
            {
                e.Cancel = true;
                tbLast.Focus();
                epValidating.SetError(tbPhone, "Phone Should Have A Value");
            }
            else if (!IsEmpty(tbPhone.Text) && tbPhone.Text.Any(char.IsLetter))
            {
                e.Cancel = true;
                tbLast.Focus();
                epValidating.SetError(tbPhone, "The Phone should be Just Number");
            }
            else
            {
                e.Cancel = false;
                epValidating.SetError(tbPhone, "");
            }
        }

        private void cbCountries_Validating(object sender, CancelEventArgs e)
        {
            Validation(e, cbCountries, "Country Name Should Have A Value");
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidEmail(tbEmail.Text) && !IsEmpty(tbEmail.Text))
            {
                e.Cancel = true;
                tbLast.Focus();
                epValidating.SetError(tbEmail, "Format Email Not Correct");
            }
            else
            {
                e.Cancel = false;
                epValidating.SetError(tbEmail, "");
            }
        }

        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            Validation(e, tbAddress, "Address Name Should Have A Value");
        }
    }
}
