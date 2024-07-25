using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Local_Driving_Licenses
{
    public partial class frmLicenseDetails : Form
    {
        private int _ApplicationID;
        public frmLicenseDetails(int ApplicationID)
        {
            InitializeComponent();
            _ApplicationID = ApplicationID;
        }


        private void frmLicenseDetails_Load(object sender, EventArgs e)
        {
            ctrlLicenseCard.LoadLicenseData(_ApplicationID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
