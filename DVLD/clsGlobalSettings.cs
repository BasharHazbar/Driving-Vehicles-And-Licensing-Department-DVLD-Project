using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD
{
    public class clsGlobalSettings
    {

        public static clsUsers User { get; set; }

        public enum enApplicationTypes
        {
            NewLocalDrivingLicense = 1, RenewDrivingLicense = 2,
            ReplacementForLostDrivingLicense = 3, ReplacementForDamagedDrivingLicense = 4,
            ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };

        public enum enTestTypes { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };

        public enum enApplicationStatus { New = 1, Canceled = 2, Complated = 3 };

        public enum enIssuedReason { FirstTime = 1, Renew = 2, ReplacementForDamagedComplated = 3, ReplacementForLost = 4 };

        public static int TryParse(string Value)
        {
            if (int.TryParse(Value, out int ID))
            {
                return ID;

            }
            return -1;
        }

        public static bool IsEmpty(string Value)
        {
            return string.IsNullOrWhiteSpace(Value) || string.IsNullOrEmpty(Value);
        }
    }
}
