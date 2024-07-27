using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.International_Driving_License
{
    public partial class frmIntLicenseDetails : Form
    {
        private int _InternationalLicenseID;
        public frmIntLicenseDetails(int InternationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = InternationalLicenseID;
        }

        private void frmIntLicenseDetails_Load(object sender, EventArgs e)
        {
            ctrlIntLicenseCard.LoadLInticenseData(_InternationalLicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
