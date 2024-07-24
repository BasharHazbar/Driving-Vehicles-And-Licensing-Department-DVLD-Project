using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess_Layer
{
    public class clsDataAccessLicenseClasses
    {
        public static bool FindByID(int LicenseClassID, ref string ClassName, ref string ClassDescription,
           ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select * from LicenseClasses where LicenseClassID = @LicenseClassID; ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    ClassName = (string)reader["ClassName"];

                    ClassDescription = (string)reader["ClassDescription"];

                    LicenseClassID = (int)reader["LicenseClassID"];

                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];

                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];

                    ClassFees = (decimal)reader["ClassFees"];

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isFind = false;
            }
            finally
            {
                connection.Close();
            }
            return isFind;
        }


        public static bool FindByClassName(string ClassName , ref int LicenseClassID, ref string ClassDescription,
                 ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select * from LicenseClasses where ClassName = @ClassName; ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ClassName", ClassName);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    LicenseClassID = (int)reader["LicenseClassID"];

                    ClassDescription = (string)reader["ClassDescription"];

                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];

                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];

                    ClassFees = (decimal)reader["ClassFees"];

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                isFind = false;
            }
            finally
            {
                connection.Close();
            }
            return isFind;
        }

        /*       public static bool AddLicense(int LicenseClassID, string ClassName, string ClassDescription,
                   short MinimumAllowedAge, short DefaultValidityLength, float ClassFees)
               {


                   SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

                   int ID = -1;

                   string Query = @"INSERT INTO [dbo].[Licenses]
                                                  ([ApplicationID]
                                                  ,[DriverID]
                                                  ,[LicenseClassID]
                                                  ,[IssueDate]
                                                  ,[ExpirationDate]
                                                  ,[Notes]
                                                  ,[PaidFees]
                                                  ,[IsActive]
                                                  ,[IssueReason]
                                                  ,[CreatedByUserID])
                                            VALUES
                                                  (@ApplicationID,@DriverID,@LicenseClassID,@IssueDate,@ExpirationDate
                                                    ,@Notes,@PaidFees,@IsActive,@IssueReason,@CreatedByUserID) ";

                   SqlCommand cmd = new SqlCommand(Query, connection);
                   cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                   cmd.Parameters.AddWithValue("@DriverID", DriverID);
                   cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);



                   cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
                   cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);



                   if (Notes != "")
                   {
                       cmd.Parameters.AddWithValue("@Notes", Notes);
                   }
                   cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                   cmd.Parameters.AddWithValue("@IsActive", IsActive);

                   cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
                   cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


                   try
                   {
                       connection.Open();

                       Object Respone = cmd.ExecuteScalar();

                       if (Respone != null)
                       {
                           ID = Convert.ToInt32(Respone);
                       }

                   }
                   catch (Exception ex)
                   {
                       Console.WriteLine(ex.Message);

                   }
                   finally
                   {
                       connection.Close();

                   }
                   return ID != -1;
               }


               public static bool UpdatLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate,
                  DateTime ExpirationDate, string Notes, float PaidFees, short IsActive, short IssueReason, int CreatedByUserID)
               {

                   int RowEffects = 0;

                   SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

                   string Query = @"UPDATE [dbo].[Licenses]
                                              SET [ApplicationID] = @ApplicationID
                                                 ,[DriverID] = @DriverID
                                                 ,[LicenseClassID] = @LicenseClassID
                                                 ,[IssueDate] = @IssueDate
                                                 ,[ExpirationDate] = @ExpirationDate
                                                 ,[Notes] = @Notes
                                                 ,[PaidFees] = @PaidFees
                                                 ,[IsActive] = @IsActive
                                                 ,[IssueReason] = @IssueReason
                                                 ,[CreatedByUserID] = @CreatedByUserID
                                            WHERE  LicenseID = @LicenseID; ";

                   SqlCommand cmd = new SqlCommand(Query, connection);

                   cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                   cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                   cmd.Parameters.AddWithValue("@DriverID", DriverID);
                   cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                   cmd.Parameters.AddWithValue("@IssueDate", IssueDate);

                   cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

                   if (Notes != "")
                   {
                       cmd.Parameters.AddWithValue("@Notes", Notes);
                   }

                   cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                   cmd.Parameters.AddWithValue("@IsActive", IsActive);
                   cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
                   cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


                   try
                   {
                       connection.Open();

                       Object Respone = cmd.ExecuteScalar();

                       if (Respone != null)
                       {
                           RowEffects = Convert.ToInt32(Respone);
                       }
                   }

                   catch (Exception ex)
                   {

                   }

                   finally
                   {
                       connection.Close();
                   }
                   return RowEffects > 0;
               }*/

        public static DataTable GetLicenseClassesList()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = " select * from LicenseClasses ";


            SqlCommand cmd = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }


        /*       public static bool isExist(int LicenseID)
               {
                   bool isExist = false;

                   SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

                   string query = " select found = 1 from Licenses where LicenseID = @LicenseID ";

                   SqlCommand cmd = new SqlCommand(query, connection);

                   cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

                   try
                   {
                       connection.Open();
                       SqlDataReader reader = cmd.ExecuteReader();

                       if (reader.HasRows)
                       {
                           isExist = true;
                       }

                       reader.Close();
                   }
                   catch (Exception ex)
                   {

                       Console.WriteLine(ex.Message);
                       isExist = false;
                   }
                   finally
                   {
                       connection.Close();
                   }
                   return isExist;
               }*/

        public static bool Delete(int LicenseClasseID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = " DELETE from LicenseClasses where LicenseClasseID = @LicenseClasseID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@LicenseClasseID", LicenseClasseID);

            try
            {
                connection.Open();

                Object Respone = cmd.ExecuteScalar();

                if (Respone != null)
                {
                    RowEffects = Convert.ToInt32(Respone);
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }
            return RowEffects > 0;
        }
    }
}
