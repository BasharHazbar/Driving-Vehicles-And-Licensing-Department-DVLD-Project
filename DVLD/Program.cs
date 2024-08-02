using DVLD.Application_Types;
using DVLD.Detained_and_Release_License;
using DVLD.International_Driving_License;
using DVLD.Licenses_History;
using DVLD.Local_Driving_Licenses;
using DVLD.People;
using DVLD.Renew_Local_Driving_License;
using DVLD.Replacement_Local_Driving_License;
using DVLD.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLicensesHistory(1));
            //Application.Run(new frmPeopleManagement()); 
            //Application.Run(new frmInternationalLicenseManagement());
            //Application.Run(new frmReplacementForDamageOrLostLocalLicense());

            //Application.Run(new frmRenewLocalDrivingLicense());
            Application.Run(new frmLogin());
            //Application.Run(new frmDetainedAndReleaseLicenseManagement());

            // Application.Run(new frmIssueInternationalDrivingLicense());
        }
    }
}
