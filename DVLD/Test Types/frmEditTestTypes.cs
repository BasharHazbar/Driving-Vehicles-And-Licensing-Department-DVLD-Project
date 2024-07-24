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

namespace DVLD.Test_Types
{
    public partial class frmEditTestTypes : Form
    {
        private int _TestTypeID;

        private clsTestTypes _TestType;
        public frmEditTestTypes(int TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;

        }

        void LoadData()
        {
            _TestType = clsTestTypes.Find(_TestTypeID);

            if (_TestType != null)
            {
                lbTestTypeIDValue.Text = _TestTypeID.ToString();
                tbTittle.Text = _TestType.TestTypeTitle;
                tbDescription.Text = _TestType.TestTypeDescription;
                tbFees.Text = Convert.ToUInt16(_TestType.TestTypeFees).ToString();
            }
            else
            {
                MessageBox.Show("There is No Test Types With ID = " + _TestTypeID, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void frmEditTestTypes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _TestType.TestTypeTitle = tbTittle.Text;
            _TestType.TestTypeDescription = tbDescription.Text;
            _TestType.TestTypeFees = decimal.Parse(tbFees.Text);

            if (_TestType.Save())
            {
                MessageBox.Show("Data Save Successfly", "Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Not Save Successfly", "Not Saved", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }
    }
}
