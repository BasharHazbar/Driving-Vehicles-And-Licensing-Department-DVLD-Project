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
    public partial class ctrlFindPersonCard : UserControl
    {

        private int _PersonID = -1;
        public ctrlFindPersonCard()
        {
            InitializeComponent();
        }


        public int PersonID
        {
            get { return _PersonID; }
        }



        private void frmAddEditPerson_dataBack(object sender, int PersonID)
        {
            if (PersonID != -1)
            {
                _PersonID = PersonID;
                ctrlPersonCard.LoadPersonData(_PersonID);
                tbFind.Text = _PersonID.ToString();
                cbFind.SelectedIndex = 0;
            }
        }

        void LoadPersonData()
        {
            if (cbFind.Text == "Person ID")
            {
                if (int.TryParse(tbFind.Text, out int PersonID))
                {
                    PersonID = ctrlPersonCard.LoadPersonData(PersonID);

                    if (PersonID != -1)
                    {
                        _PersonID = PersonID;
                    }

                }
                return;

            }
            else if (cbFind.Text == "National No")
            {
                int PersonID = ctrlPersonCard.LoadPersonData(tbFind.Text);
                if (PersonID != -1)
                {
                    _PersonID = PersonID;
                }
            }
        }

        private void cbFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFind.Text = string.Empty;
        }



        private void pbFind_Click(object sender, EventArgs e)
        {
            LoadPersonData();
        }


        private void tbFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadPersonData();
            }
        }

        public void LoadPersonData(int PersonID)
        {
            if (ctrlPersonCard.LoadPersonData(PersonID) != -1)
            {
                _PersonID = PersonID;
                cbFind.SelectedIndex = 0;
                tbFind.Text = _PersonID.ToString();
                gbFilter.Enabled = false;
            }
        }

        private void pbAddPerson_Click(object sender, EventArgs e)
        {
/*            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson(-1);

            frmAddEditPerson.DataBack += frmAddEditPerson_dataBack;
            frmAddEditPerson.ShowDialog();*/
        }

        private void ctrlFindPersonCard_Load(object sender, EventArgs e)
        {
            cbFind.SelectedIndex = 0;
        }

    }
}
