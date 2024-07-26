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

namespace DVLD.People
{
    public partial class frmPeopleManagement : Form
    {

        private DataView PeopleView;
        public frmPeopleManagement()
        {
            InitializeComponent();
        }


        void GetPeopleListWithFilter()
        {
            PeopleView = new DataView(clsPeople.GetPeopleList());

            Filter(tbFilterBy.Text);

            dgvPeopleList.DataSource = PeopleView;
            lbRecordsCountValue.Text = PeopleView.Count.ToString();
        }

        void Filter(string FilterValue)
        {
            if (FilterValue == string.Empty)
            {
                return;
            }

            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    PeopleView.RowFilter = "PersonID = " + clsGlobalSettings.TryParse(FilterValue);
                    break;
                case "National No":
                    PeopleView.RowFilter = "NationalNo LIKE '%" + FilterValue + "%'";
                    break;
                case "First Name":
                    PeopleView.RowFilter = "[First Name] LIKE '%" + FilterValue + "%'";
                    break;
                case "Second Name":
                    PeopleView.RowFilter = "[Second Name] LIKE '%" + FilterValue + "%'";
                    break;
                case "Third Name":
                    PeopleView.RowFilter = "[Third Name] LIKE '%" + FilterValue + "%'";
                    break;
                case "Last Name":
                    PeopleView.RowFilter = "[Last Name] LIKE '%" + FilterValue + "%'";
                    break;
                case "Gendor":
                    PeopleView.RowFilter = "Gendor LIKE '%" + FilterValue + "%'";
                    break;
                case "Address":
                    PeopleView.RowFilter = "Address LIKE '%" + FilterValue + "%'";
                    break;
                case "Phone":
                    PeopleView.RowFilter = "Phone LIKE '%" + FilterValue + "%'";
                    break;
                case "Email":
                    PeopleView.RowFilter = "Email LIKE '%" + FilterValue + "%'";
                    break;
                case "Nationality":
                    PeopleView.RowFilter = "[Country Name] LIKE '%" + FilterValue + "%'";
                    break;
                default:
                    PeopleView.RowFilter = "";
                    break;
            }

        }

        private void frmPeapleManagement_Load(object sender, EventArgs e)
        {
            GetPeopleListWithFilter();
            tbFilterBy.Visible = false;
            cbFilterBy.SelectedIndex = 0;
            this.Width = 1200;
            dgvPeopleList.Width = 1100;
        }

        private void tbFilterBy_KeyUp(object sender, KeyEventArgs e)
        {
            GetPeopleListWithFilter();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterBy.Text = string.Empty;
            if (cbFilterBy.Text == "None")
            {
                tbFilterBy.Visible = false;
            }
            else
            {
                tbFilterBy.Visible = true;
            }
            GetPeopleListWithFilter();
        }

        /*       

                            frmPersonDetails frmPersonDetails = new frmPersonDetails((int)dgvPeopleList.CurrentRow.Cells[0].Value);
                    frmPersonDetails.ShowDialog();
                    GetPeopleListWithFilter();

                   frmAddEditPerson frmAddEditPerson = new frmAddEditPerson((int)dgvPeopleList.CurrentRow.Cells[0].Value);
            frmAddEditPerson.ShowDialog();
            GetPeopleListWithFilter();



                    

         */



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dgvPeopleList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmPersonDetails frmPersonDetails = new frmPersonDetails((int)dgvPeopleList.CurrentRow.Cells[0].Value);
            frmPersonDetails.ShowDialog();
            frmPersonDetails.Dispose();
        }

        private void pbAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson(-1);
            frmAddEditPerson.ShowDialog();
            frmAddEditPerson.Dispose();
            GetPeopleListWithFilter();
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            frmPersonDetails frmPersonDetails = new frmPersonDetails((int)dgvPeopleList.CurrentRow.Cells[0].Value);
            frmPersonDetails.ShowDialog();
            frmPersonDetails.Dispose();
            GetPeopleListWithFilter();
        }

        private void tsmAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson(-1);
            frmAddEditPerson.ShowDialog();
            frmAddEditPerson.Dispose();
            GetPeopleListWithFilter();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson((int)dgvPeopleList.CurrentRow.Cells[0].Value);
            frmAddEditPerson.ShowDialog();
            frmAddEditPerson.Dispose();
            GetPeopleListWithFilter();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete Person with ID =  [" + dgvPeopleList.CurrentRow.Cells[0].Value + "]", "Confirm Delete",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {

                //Perform Delele and refresh
                if (clsPeople.Delete((int)dgvPeopleList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Deleted", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    GetPeopleListWithFilter();
                }

                else
                    MessageBox.Show("Person is not deleted..", "Not Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


            }
        }
    }
}
