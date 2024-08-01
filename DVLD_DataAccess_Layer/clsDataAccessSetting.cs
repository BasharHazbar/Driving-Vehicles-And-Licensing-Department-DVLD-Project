
using System;

namespace DVLD_DataAccess_Layer
{

    public class clsDataAccessSetting
    {
        public static string connectionDbInfo = "Server=.;Database=DVLD;User Id=sa;Password=sa123456";
        public static object CheckIsNullOrEmpty(string Value)
        {
            return string.IsNullOrEmpty(Value) ? (object)DBNull.Value : Value;
        }
    }
}
