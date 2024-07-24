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

namespace DVLD
{
    public partial class frmDriversManagement : Form
    {

        private DataView DriversView;
        public frmDriversManagement()
        {
            InitializeComponent();
        }

        void GetDriversListWithFilter()
        {
            DriversView = new DataView(clsDrivers.GetDriversList());

            Filter(tbFilterBy.Text);

            dgvDriversList.DataSource = DriversView;
            lbRecordsCountValue.Text = DriversView.Count.ToString();
        }


        void Filter(string FilterValue)
        {
            if (FilterValue == string.Empty)
            {
                return;
            }

            switch (cbFilterBy.Text)
            {
                case "Driver ID":
                    DriversView.RowFilter = "[Driver ID] = " + clsGlobalSettings.TryParse(FilterValue);
                    break;
                case "Person ID":
                    DriversView.RowFilter = "[Person ID] = " + clsGlobalSettings.TryParse(FilterValue);
                    break;
                case "National No.":
                    DriversView.RowFilter = "[National No.] LIKE '%" + FilterValue + "%'";
                    break;
                case "Full Name":
                    DriversView.RowFilter = "[Full Name] LIKE '%" + FilterValue + "%'";
                    break;
                case "Date":
                    DriversView.RowFilter = "Date LIKE '%" + FilterValue + "%'";
                    break;
                case "Active Licenses":
                    DriversView.RowFilter = "[Active Licenses] = " + clsGlobalSettings.TryParse(FilterValue);
                    break;
                default:
                    DriversView.RowFilter = "";
                    break;
            }

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDriversManagement_Load(object sender, EventArgs e)
        {
            tbFilterBy.Visible = false;
            cbFilterBy.SelectedIndex = 0;
            GetDriversListWithFilter();

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
            GetDriversListWithFilter();
        }

        private void tbFilterBy_KeyUp(object sender, KeyEventArgs e)
        {
            GetDriversListWithFilter();
        }

    }
    
}
