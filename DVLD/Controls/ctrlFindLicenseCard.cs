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

namespace DVLD.Controls
{
    public partial class ctrlFindLicenseCard : UserControl
    {
        private int _LicenseID = -1;
        public ctrlFindLicenseCard()
        {
            InitializeComponent();
        }

        public int LicenseID
        {
            get { return _LicenseID; }
        }


        void LoadLicenseData()
        {
            if (int.TryParse(tbFind.Text, out int LicenseID))
            {
                clsLicenses License = clsLicenses.Find(LicenseID);

                if (License == null)
                {
                    MessageBox.Show("NO License With ID = " + LicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlLicenseCard.ResetLicenseData();
                    return;
                }

                if (!License.IsActive)
                {
                    MessageBox.Show("This License With ID = " + LicenseID + " Not Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlLicenseCard.ResetLicenseData();
                    return;

                }

                ctrlLicenseCard.LoadLicenseData(License.ApplicationID);

                _LicenseID = License.LicenseID;
            }
        }
        private void pbFindLicense_Click(object sender, EventArgs e)
        {
            LoadLicenseData();
        }

        private void tbFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadLicenseData();
            }
        }
    }
}
