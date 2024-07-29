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

namespace DVLD.Users
{
    public partial class frmAddEditUser : Form
    {
        private enum enMode { AddUser = 0, UpdateUser = 1 };

        private enMode _Mode;

        private int _UserID;

        private clsUsers _User;

        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;

            if (UserID == -1)
            {
                _Mode = enMode.AddUser;
            }
            else
            {
                _Mode = enMode.UpdateUser;
                
            }
        }

        private bool IsEmptyFaild()
        {
            return clsGlobalSettings.IsEmpty(tbUserName.Text) || clsGlobalSettings.IsEmpty(tbPassword.Text) || 
                clsGlobalSettings.IsEmpty(tbConfirmPassword.Text);
        }

        void LoadData()
        {


            if (_Mode == enMode.AddUser)
            {
                lbMode.Text = "Add New User";
                _User = new clsUsers();
                return;
            }

            _User = clsUsers.Find(_UserID);

            lbMode.Text = "Edit User With ID = " + _UserID;

            lbUserIDValue.Text = _User.UserID.ToString();
            tbUserName.Text = _User.UserName;
            tbPassword.Text = _User.Password;
            tbConfirmPassword.Text = _User.Password;
            cbIsActive.Checked = _User.IsActive;

            ctrlFindPersonCard.LoadPersonData(_User.PersonID);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlFindPersonCard.PersonID == -1)
            {
                MessageBox.Show("Please Select a Person", "Error", MessageBoxButtons.OK
                     , MessageBoxIcon.Error);
                return;
            }

            if (_Mode == enMode.AddUser && clsUsers.isExistByPersonID(ctrlFindPersonCard.PersonID))
            {
                MessageBox.Show("Selected a Person Aready has User, choose another one", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return;
            }

            tcAddEditNewUser.SelectedIndex = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUserName.Text))
            {
                e.Cancel = true;
                tbUserName.Focus();
                epValidating.SetError(tbUserName, "The User Name should have Value");
            }
            else
            {
                e.Cancel = false;
                epValidating.SetError(tbUserName, "");
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                e.Cancel = true;
                tbPassword.Focus();
                epValidating.SetError(tbPassword, "The Confirm Password should have Value");
            }
            else
            {
                e.Cancel = false;
                epValidating.SetError(tbPassword, "");
            }
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbConfirmPassword.Text))
            {
                e.Cancel = true;
                tbConfirmPassword.Focus();
                epValidating.SetError(tbConfirmPassword, "The Confirm Password should have Value");
            }
            else if (tbConfirmPassword.Text != tbPassword.Text)
            {
                e.Cancel = true;
                tbConfirmPassword.Focus();
                epValidating.SetError(tbConfirmPassword, "the Confim Password Not Equal the Password");
            }
            else
            {
                e.Cancel = false;
                epValidating.SetError(tbConfirmPassword, "");
            }
        }

        private void tcAddEditNewUser_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (ctrlFindPersonCard.PersonID == -1)
            {
                e.Cancel = true;
                return;
            }

            if (_Mode == enMode.AddUser && tcAddEditNewUser.SelectedIndex == 1 && clsUsers.isExistByPersonID(ctrlFindPersonCard.PersonID))
            {
                //tcAddNewUser.SelectedIndex = 0;
                e.Cancel = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEmptyFaild())
            {
                MessageBox.Show("Please Fill The Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbConfirmPassword.Text != tbPassword.Text)
            {
                MessageBox.Show("Please Confirm Password Correctly", "Erorr",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.PersonID = ctrlFindPersonCard.PersonID;
            _User.UserName = tbUserName.Text;
            _User.Password = clsGlobalSettings.EncryptText(tbPassword.Text);
            _User.IsActive = cbIsActive.Checked;

            if (_User.Save())
            {
                MessageBox.Show("Data Save Successfuly", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Not Save Successfuly", "Not Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _UserID = _User.UserID;

            lbUserIDValue.Text = _UserID.ToString();

            lbMode.Text = "Edit User With ID = " + _UserID.ToString();

            _Mode = enMode.UpdateUser;
        }
    }
}
