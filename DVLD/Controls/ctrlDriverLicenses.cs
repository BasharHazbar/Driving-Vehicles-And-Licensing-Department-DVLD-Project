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
    public partial class ctrlDriverLicenses : UserControl
    {
     
        private DataTable _LocalLicensesList, _InternationalLicensesList;
        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }

        public void LoadDriverLicensesData(int PersonID)
        {
            _LocalLicensesList = clsLicenses.GetLicensesListByPersonID(PersonID);

            dgvLocalDrivingLicensesList.DataSource = _LocalLicensesList;

            lbLocalRecordsCountValue.Text = _LocalLicensesList.Rows.Count.ToString();

            _InternationalLicensesList = clsInternationalLicenses.GetInternationalLicensesListByPersonID(PersonID);

            dgvInternationalDrivingLicensesList.DataSource = _InternationalLicensesList;

            lbInternationalRecordsCountValue.Text = _InternationalLicensesList.Rows.Count.ToString();

        }



    }
}
