using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DVLD_DataAccess_Layer
{
    public class clsDataAccessDetainedLicenses
    {
        public static bool Find(int DetainID, ref int LicensesID, ref DateTime DetainDate, ref float FineFees,
            ref int CreatedByUserID, ref short IsReleased, ref DateTime ReleaseDate,ref int ReleasedByUserID,
            ref int ReleaseApplicationID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select * from DetainedLicenses where DetainID = @DetainID ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    LicensesID = (int)reader["LicensesID"];

                    DetainDate = (DateTime)reader["DetainDate"];

                    FineFees = (float)reader["FineFees"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    IsReleased = (short)reader["IsReleased"];

                    if (reader["ReleaseDate"] != DBNull.Value)
                    {
                        ReleaseDate = (DateTime)reader["ReleaseDate"];
                    }

                    if (reader["ReleasedByUserID"] != DBNull.Value)
                    {
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    }

                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                    {
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                    }
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

        public static bool AddDetainedLicense(int LicenseID, DateTime DetainDate, float FineFees,
            int CreatedByUserID, short IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            int ID = -1;

            string Query = @"INSERT INTO [dbo].[DetainedLicenses]
                                   ([LicenseID]
                                   ,[DetainDate]
                                   ,[FineFees]
                                   ,[CreatedByUserID]
                                   ,[IsReleased]
                                   ,[ReleaseDate]
                                   ,[ReleasedByUserID]
                                   ,[ReleaseApplicationID])
                             VALUES
                                   (@LicenseID,@DetainDate,FineFees,CreatedByUserID,IsReleased,
                                    ReleaseDate,ReleasedByUserID,ReleaseApplicationID); 
                                    select SCOPE_IDENTITY(); ";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
            cmd.Parameters.AddWithValue("@FineFees", FineFees);



            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsReleased", IsReleased);

            if (ReleaseDate != DateTime.Now)
            {
                cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            }

            if (ReleasedByUserID != -1)
            {
                cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            }

            if (ReleaseApplicationID != -1)
            {
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }


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


        public static bool UpdateDetainedLicense(int DetainID,int LicenseID, DateTime DetainDate, float FineFees,
            int CreatedByUserID, short IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @"UPDATE [dbo].[DetainedLicenses]
                                       SET [LicenseID] = @LicenseID
                                          ,[DetainDate] = @DetainDate
                                          ,[FineFees] = @FineFees
                                          ,[CreatedByUserID] = @CreatedByUserID
                                          ,[IsReleased] = @IsReleased
                                          ,[ReleaseDate] = @ReleaseDate
                                          ,[ReleasedByUserID] = @ReleasedByUserID
                                          ,[ReleaseApplicationID] = @ReleaseApplicationID
                                     WHERE DetainID = @DetainID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@DetainID", DetainID);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
            cmd.Parameters.AddWithValue("@FineFees", FineFees);

            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsReleased", IsReleased);

            if (ReleaseDate != DateTime.Now)
            {
                cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            }

            if (ReleasedByUserID != -1)
            {
                cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            }


            if (ReleaseApplicationID != -1)
            {
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }

            try
            {
                connection.Open();

                Object Respone = cmd.ExecuteNonQuery();

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

///*
//        public static DataTable GetDetainedLicensesList()
//        {
//            DataTable dt = new DataTable();

//            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

//            string Query = " select * from People_View ";


//            SqlCommand cmd = new SqlCommand(Query, connection);

//            try
//            {
//                connection.Open();

//                SqlDataReader reader = cmd.ExecuteReader();

//                if (reader.HasRows)
//                {
//                    dt.Load(reader);
//                }

//                cmd.ExecuteReader();


//            }
//            catch (Exception ex)
//            {

//            }
//            finally
//            {
//                connection.Close();
//            }

//            return dt;
//        }

//*/
        public static bool isExist(int DetainID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select found = 1 from DetainedLicenses where DetainID = @DetainID ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DetainID", DetainID);

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
        }

        public static bool Delete(int DetainID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = " DELETE from DetainedLicenses where DetainID = @DetainID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@DetainID", DetainID);

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
