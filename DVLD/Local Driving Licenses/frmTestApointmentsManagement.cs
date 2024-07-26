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

namespace DVLD.Local_Driving_Licenses
{
    public partial class frmTestApointmentsManagement : Form
    {
        private DataTable _TestAppointments;
        private int _ApplicationID;
        private byte _TestTypeID;
        private int _LocalDrivingLicenseApplicationID;
        private bool _IsRetakeTest;

        public frmTestApointmentsManagement(int LocalDrivingLicenseApplicationID, int ApplicationID, byte TestTypeID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _ApplicationID = ApplicationID;
            _TestTypeID = TestTypeID;
        }


        void GetTestAppoimentsList()
        {
            _TestAppointments = clsTestAppointments.GetTestAppointmentsList(_LocalDrivingLicenseApplicationID, _TestTypeID);

            dgvTestAppointmentsList.DataSource = _TestAppointments;
            lbRecordsCountValue.Text = _TestAppointments.Rows.Count.ToString();
            ChangeTitleText();
        }


        private void ChangeTitleText()
        {
            switch (_TestTypeID)
            {
                case (byte)clsGlobalSettings.enTestTypes.VisionTest:
                    this.Text = "Vision Test Appoiments";
                    lbTitleTestType.Text = "Vision Test Appoiments";
                    break;
                case (byte)clsGlobalSettings.enTestTypes.WrittenTest:
                    this.Text = "Written Test Appoiments";
                    lbTitleTestType.Text = "Written Test Appoiments";
                    break;
                case (byte)clsGlobalSettings.enTestTypes.StreetTest:
                    this.Text = "Street Test Appoiments";
                    lbTitleTestType.Text = "Street Test Appoiments";
                    break;
            }
        }

        private bool IsRetakeTest()
        {
            return clsTestAppointments.CountTrail(_LocalDrivingLicenseApplicationID, _TestTypeID) > 0;
        }

        private void frmTestApointmentsManagement_Load(object sender, EventArgs e)
        {
            ctrlApplicationCard.LoadApplicationData(_ApplicationID);
            GetTestAppoimentsList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAddTestAppointment_Click(object sender, EventArgs e)
        {


            if (clsTestAppointments.isHasActiveAppointment(_LocalDrivingLicenseApplicationID))
            {

                MessageBox.Show("Person Aready have an Active Appointment For this Test, You Can not add New appointment", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsTestAppointments.isPassedTest(_LocalDrivingLicenseApplicationID, _TestTypeID))
            {
                MessageBox.Show("Person Aready Passed The Test", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsRetakeTest())
            {

                _IsRetakeTest = true;
            }




            frmAddEditLocalLicenseTestAppointments AddEditLocalLicenseTestAppointments = new
            frmAddEditLocalLicenseTestAppointments(-1, _ApplicationID, _TestTypeID, _IsRetakeTest);
            AddEditLocalLicenseTestAppointments.ShowDialog();
            AddEditLocalLicenseTestAppointments.Dispose();
            GetTestAppoimentsList();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {

            if (IsRetakeTest())
            {
                _IsRetakeTest = true;
            }

            frmAddEditLocalLicenseTestAppointments AddEditLocalLicenseTestAppointments = new
            frmAddEditLocalLicenseTestAppointments((int)dgvTestAppointmentsList.CurrentRow.Cells[0].Value,_ApplicationID, _TestTypeID, _IsRetakeTest);
            AddEditLocalLicenseTestAppointments.ShowDialog();
            AddEditLocalLicenseTestAppointments.Dispose();
            GetTestAppoimentsList();
            ctrlApplicationCard.LoadApplicationData(_ApplicationID);
        }

        private void tsmTakeTest_Click(object sender, EventArgs e)
        {
            frmTakeLocalDrivingLicenseTest TakeLocalDrivingLicenseTest = new frmTakeLocalDrivingLicenseTest((int)dgvTestAppointmentsList.CurrentRow.Cells[0].Value, _ApplicationID,
                _TestTypeID, _IsRetakeTest);
            TakeLocalDrivingLicenseTest.ShowDialog();
            TakeLocalDrivingLicenseTest.Dispose();
            GetTestAppoimentsList();
            ctrlApplicationCard.LoadApplicationData(_ApplicationID);
        }

        private void ctmEditTakeTest_Opening(object sender, CancelEventArgs e)
        {
            if ((bool)dgvTestAppointmentsList.CurrentRow.Cells[3].Value)
            {
                tsmEdit.Enabled = false;
                tsmTakeTest.Enabled = false;
            }
            else
            {
                tsmEdit.Enabled = true;
                tsmTakeTest.Enabled = true;
            }
        }

    }
}
