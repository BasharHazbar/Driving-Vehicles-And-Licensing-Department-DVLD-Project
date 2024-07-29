using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool IsEmptyFaild()
        {
            return clsGlobalSettings.IsEmpty(tbUsername.Text) || clsGlobalSettings.IsEmpty(tbPassword.Text);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsEmptyFaild())
            {
                MessageBox.Show("Please Fill The Faild + ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsUsers User = clsUsers.Find(tbUsername.Text, clsGlobalSettings.EncryptText(tbPassword.Text));

            if (User == null)
            {
                MessageBox.Show("Invalid UserName Or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!User.IsActive)
            {

                MessageBox.Show("User Not Active Contact With Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                clsGlobalSettings.User = User;
                frmMain Main = new frmMain();
                Main.Show();
                Main.Dispose();
            }
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                e.Cancel = true;
                tbUsername.Focus();
                epValidating.SetError(tbUsername, "The User Name should have Value");
            }
            else
            {
                e.Cancel = false;
                epValidating.SetError(tbUsername, "");
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

        
    }
}
