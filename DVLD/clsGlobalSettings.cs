using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DVLD
{
    public class clsGlobalSettings
    {
        public static clsUsers User { get; set; }

        private static int KeyOfDecEnc = 3;

        public enum enApplicationTypes
        {
            NewLocalDrivingLicense = 1, RenewDrivingLicense = 2,
            ReplacementForLostDrivingLicense = 3, ReplacementForDamagedDrivingLicense = 4,
            ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };

        public enum enTestTypes { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };

        public enum enApplicationStatus { New = 1, Canceled = 2, Complated = 3 };

        public enum enIssuedReason { FirstTime = 1, Renew = 2, ReplacementForDamaged = 3, ReplacementForLost = 4 };

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

        public static string HashPassword(string Password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Password));
                return Convert.ToBase64String(bytes);
            }
        }

        public static string EncryptText(string Text)
        {
            char[] buffer = Text.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (char)(buffer[i] + KeyOfDecEnc);
            }
            return new string(buffer);
        }

        public static string DecryptText(string Text)
        {
            char[] buffer = Text.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (char)(buffer[i] - KeyOfDecEnc);
            }
            return new string(buffer);
        }
    }
}
