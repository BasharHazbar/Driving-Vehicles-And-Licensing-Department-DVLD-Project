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
        clsLicenses _License;
        public ctrlFindLicenseCard()
        {
            InitializeComponent();
        }

/*        public int LicenseID
        {
            get { return _LicenseID; }
        }

        public int DriverID
        {
            get { return _License.DriverID; }
        }
*/

        void LoadLicenseData()
        {
            if (int.TryParse(tbFind.Text, out int LicenseID))
            {
                _License = clsLicenses.Find(LicenseID);
                
                if (_License == null)
                {
                    MessageBox.Show("NO License With ID = " + LicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlLicenseCard.ResetLicenseData();
                    return;
                }
/*
                if (!_License.IsActive)
                {
                    MessageBox.Show("This License With ID = " + LicenseID + " Not Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _LicenseID = -1;
                    ctrlLicenseCard.ResetLicenseData();
                    return;

                }

                if (_License.ExpirationDate <= DateTime.Now)
                {
                    MessageBox.Show($"This License with ID = {LicenseID} is already expired.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlLicenseCard.ResetLicenseData();
                    _LicenseID = -1;
                    return;
                }

                if (!clsLicenses.IsOrdinarydrivinglicense(_License.DriverID,_License.LicenseClassID))
                {
                    MessageBox.Show("This License  with ID = " + LicenseID + " It Not Ordinary Drivig", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlLicenseCard.ResetLicenseData();
                    _LicenseID = -1;
                    return;
                }*/

                ctrlLicenseCard.LoadLicenseData(_License.ApplicationID);

 //               _LicenseID = _License.LicenseID;
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
