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

namespace DVLD.Application_Types
{
    public partial class frmApplicationTypesManagement : Form
    {
        public frmApplicationTypesManagement()
        {
            InitializeComponent();
        }

        void GetApplicationTypesList()
        {
            DataView ApplicationTypesView = new DataView(clsApplicationTypes.
                GetApplicationTypesList());

            dgvApplicationTypesList.DataSource = ApplicationTypesView;
            lbRecordsCountValue.Text = ApplicationTypesView.Count.ToString();
        }

        private void frmApplicationTypesManagement_Load(object sender, EventArgs e)
        {
            GetApplicationTypesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmEditApplicationTypes_Click(object sender, EventArgs e)
        {
            frmEditApplicationTypes frmEditApplicationTypes = new frmEditApplicationTypes((int)dgvApplicationTypesList.CurrentRow.Cells[0].Value);
            frmEditApplicationTypes.ShowDialog();
            GetApplicationTypesList();
        }

    }
}
