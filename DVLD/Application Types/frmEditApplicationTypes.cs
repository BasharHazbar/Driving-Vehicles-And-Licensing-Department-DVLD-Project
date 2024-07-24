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
    public partial class frmEditApplicationTypes : Form
    {
        private int _ApplicationTypeID;

        private clsApplicationTypes _ApplicationType;

        public frmEditApplicationTypes(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = ApplicationTypeID;
        }

        void LoadData()
        {
            _ApplicationType = clsApplicationTypes.Find(_ApplicationTypeID);

            if (_ApplicationType != null)
            {
                lbApplicationTypeValue.Text = _ApplicationType.ApplicationTypeID.ToString();
                tbTittle.Text = _ApplicationType.ApplicationTypeTitle;
                tbFees.Text = Convert.ToInt16(_ApplicationType.ApplicationFees).ToString();
            }
            else
            {
                MessageBox.Show("There is no Application Types With ID = " + _ApplicationTypeID, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void frmEditApplicationTypes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _ApplicationType.ApplicationTypeTitle = tbTittle.Text;

            _ApplicationType.ApplicationFees = decimal.Parse(tbFees.Text);

            if (_ApplicationType.Save())
            {
                MessageBox.Show("The Application Type Save Successfly", "Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The Application Type Not Save Successfly", "Not Saved", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
