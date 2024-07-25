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
    public partial class frmUsersManagement : Form
    {
        private DataView UsersView;
        public frmUsersManagement()
        {
            InitializeComponent();
        }

        void GetUsersListWithFilter()
        {
            UsersView = new DataView(clsUsers.GetUsersList());

            Filter(tbFilterBy.Text);

            dgvUsersList.DataSource = UsersView;
            lbRecordsCountValue.Text = UsersView.Count.ToString();
        }
        private void frmUsersManagement_Load(object sender, EventArgs e)
        {
            GetUsersListWithFilter();
            tbFilterBy.Visible = false;
            cbFindByIsActive.Visible = false;
            cbFilterBy.SelectedIndex = 0;
            cbFindByIsActive.SelectedIndex = 0;
        }



        void Filter(string FilterValue)
        {
            if (FilterValue == string.Empty && cbFindByIsActive.Text == "None")
            {
                return;
            }

            switch (cbFilterBy.Text)
            {
                case "User ID":
                    UsersView.RowFilter = "[User ID] = " + clsGlobalSettings.TryParse(FilterValue);
                    break;
                case "Person ID":
                    UsersView.RowFilter = "[Person ID] = " + clsGlobalSettings.TryParse(FilterValue);
                    break;
                case "Full Name":
                    UsersView.RowFilter = "[Full Name] LIKE '%" + FilterValue + "%'";
                    break;
                case "User Name":
                    UsersView.RowFilter = "[User Name] LIKE '%" + FilterValue + "%'";
                    break;
                case "IsActive":
                    switch (cbFindByIsActive.Text)
                    {
                        case "Yes":
                            UsersView.RowFilter = "[Is Active] = " + 1;
                            break;
                        case "No":
                            UsersView.RowFilter = "[Is Active] = " + 0;
                            break;
                    }
                    break;
                default:
                    UsersView.RowFilter = "";
                    break;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterBy.Text = string.Empty;
            if (cbFilterBy.Text == "None")
            {
                tbFilterBy.Visible = false;
                cbFindByIsActive.Visible = false;
            }
            else if (cbFilterBy.Text == "IsActive")
            {
                tbFilterBy.Visible = false;
                cbFindByIsActive.Visible = true;
            }
            else
            {
                tbFilterBy.Visible = true;
                cbFindByIsActive.Visible = false;
            }
            GetUsersListWithFilter();
        }

        private void tbFilterBy_KeyUp(object sender, KeyEventArgs e)
        {
            GetUsersListWithFilter();
        }

        private void dgvUsersList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUserDetails UserDetail = new frmUserDetails((int)dgvUsersList.CurrentRow.Cells[0].Value);
            UserDetail.ShowDialog();
        }

        private void cbFindByIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUsersListWithFilter();
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            frmUserDetails UserDetail = new frmUserDetails((int)dgvUsersList.CurrentRow.Cells[0].Value);
            UserDetail.ShowDialog();
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
/*            frmChangePassword frmChangePassword = new frmChangePassword((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frmChangePassword.ShowDialog();*/
        }

        private void tsmDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete User with ID =  [" + (int)dgvUsersList.CurrentRow.Cells[0].Value + "]", "Confirm Delete",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {

                //Perform Delele and refresh
                if (clsUsers.Delete((int)dgvUsersList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully.", "Deleted", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    GetUsersListWithFilter();
                }

                else
                    MessageBox.Show("User is not deleted", "Not Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


            }
        }


        private void tsmEditUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frmAddEditUser = new frmAddEditUser((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frmAddEditUser.ShowDialog();
            GetUsersListWithFilter();
        }

        private void pbAddUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frmAddEditUser = new frmAddEditUser(-1);
            frmAddEditUser.ShowDialog();
            GetUsersListWithFilter();
        }

        private void tsmAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frmAddEditUser = new frmAddEditUser(-1);
            frmAddEditUser.ShowDialog();
            GetUsersListWithFilter();
        }
    }
}
