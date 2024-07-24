using DVLD.Test_Types;
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
    public partial class frmTestTypesManagement : Form
    {
        public frmTestTypesManagement()
        {
            InitializeComponent();
        }

        void GetTestTypesList()
        {
            DataView TestTypesView = new DataView(clsTestTypes.GetTestTypesList());

            dgvTestTypesList.DataSource = TestTypesView;
            lbRecordsCountValue.Text = TestTypesView.Count.ToString();
        }

        private void frmTestTypesManagement_Load(object sender, EventArgs e)
        {
            GetTestTypesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmEditTestTypes_Click(object sender, EventArgs e)
        {
            frmEditTestTypes EditTestTypes = new frmEditTestTypes((int)(dgvTestTypesList.CurrentRow.Cells[0].Value));
            EditTestTypes.ShowDialog();
            GetTestTypesList();
        }

        
    }
}
