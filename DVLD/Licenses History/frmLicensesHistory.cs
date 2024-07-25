using DVLD.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses_History
{
    public partial class frmLicensesHistory : Form
    {
        private int _PersonID;
        public frmLicensesHistory(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
        }

        private void frmLicensesHistory_Load(object sender, EventArgs e)
        {
            ctrlFindPersonCard.LoadPersonData(_PersonID);
            ctrlDriverLicenses.LoadDriverLicensesData(_PersonID);
            //this.Width = 1024;
            this.Height = 768;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
