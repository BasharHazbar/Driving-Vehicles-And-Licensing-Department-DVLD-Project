using DVLD.Application_Types;
using DVLD.International_Driving_License;
using DVLD.Licenses_History;
using DVLD.Local_Driving_Licenses;
using DVLD.People;
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
            //Application.Run(new frmLogin());
            // Application.Run(new frmUsersManagement());

            Application.Run(new frmIssueInternationalDrivingLicense());
        }
    }
}
