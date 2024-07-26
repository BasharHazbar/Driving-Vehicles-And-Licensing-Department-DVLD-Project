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

namespace DVLD.Users
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUsers User = clsUsers.Find(tbUserName.Text, tbPassword.Text);

            if (User != null && User.IsActive)
            {
                clsGlobalSettings.User = User;
                frmMain Main = new frmMain();
                Main.ShowDialog();
                Main.Dispose();

            }
            else if (User == null)
            {
                MessageBox.Show("Invalid UserName Or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!User.IsActive)
            {

                MessageBox.Show("User Not Active Contact With Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

    }
}
