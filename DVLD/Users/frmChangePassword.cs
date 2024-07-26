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
    public partial class frmChangePassword : Form
    {
        private int _UserID;
        private clsUsers _User;
        public frmChangePassword(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _User = clsUsers.Find(_UserID);
            ctrlLoginUserInformation.LoadUserInfo(_UserID);
        }

        private bool IsEmptyFaild()
        {
            return clsGlobalSettings.IsEmpty(tbCurrentPassword.Text) || clsGlobalSettings.IsEmpty(tbNewPassword.Text) || 
                clsGlobalSettings.IsEmpty(tbConfirmPassword.Text);
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (clsGlobalSettings.IsEmpty(tbCurrentPassword.Text))
            {
                e.Cancel = true;
                tbCurrentPassword.Focus();
                epValidating.SetError(tbCurrentPassword, "The Current Password should have Value");
            }
            else if (tbCurrentPassword.Text != _User.Password)
            {
                e.Cancel = true;
                tbCurrentPassword.Focus();
                epValidating.SetError(tbCurrentPassword, "The Password Not Correct");
            }
            else
            {
                e.Cancel = false;
                epValidating.SetError(tbCurrentPassword, "");
            }
        }

        private void tbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (clsGlobalSettings.IsEmpty(tbNewPassword.Text))
            {
                e.Cancel = true;
                tbNewPassword.Focus();
                epValidating.SetError(tbNewPassword, "The New Password should have Value");
            }
            else
            {
                e.Cancel = false;
                epValidating.SetError(tbNewPassword, "");
            }
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (clsGlobalSettings.IsEmpty(tbConfirmPassword.Text))
            {
                e.Cancel = true;
                tbConfirmPassword.Focus();
                epValidating.SetError(tbConfirmPassword, "The Confirm Password should have Value");
            }
            else if (tbNewPassword.Text != tbConfirmPassword.Text)
            {
                e.Cancel = true;
                tbConfirmPassword.Focus();
                epValidating.SetError(tbConfirmPassword, "the Confim Password Not Equal the New Password");
            }
            else
            {
                e.Cancel = false;
                epValidating.SetError(tbConfirmPassword, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEmptyFaild())
            {
                MessageBox.Show("Please Fill The Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = tbNewPassword.Text;
            if (_User.Save())
            {
                MessageBox.Show("The Password Changed Successfly!", "Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The Password Not Changed!", "Not Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

    }
}
