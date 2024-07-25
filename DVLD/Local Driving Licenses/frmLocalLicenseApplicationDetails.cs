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
    public partial class frmLocalLicenseApplicationDetails : Form
    {
        private int _ApplicationID;

        public frmLocalLicenseApplicationDetails(int applicationID)
        {
            InitializeComponent();
            _ApplicationID = applicationID;
        }

        private void frmLocalLicenseApplicationDetails_Load(object sender, EventArgs e)
        {
            ctrlApplicationCard.LoadApplicationData(_ApplicationID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
