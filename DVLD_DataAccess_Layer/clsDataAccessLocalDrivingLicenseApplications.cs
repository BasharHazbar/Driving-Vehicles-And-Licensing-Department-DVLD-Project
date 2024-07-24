using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess_Layer
{
    public class clsDataAccessLocalDrivingLicenseApplications
    {
        public static bool FindByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = @" select * from LocalDrivingLicenseApplications where 
                                    LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];


                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                isFind = false;
            }
            finally
            {
                connection.Close();
            }
            return isFind;
        }

        public static bool FindByApplicationID(int ApplicationID , ref int LocalDrivingLicenseApplicationID, ref int LicenseClassID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = @" select * from LocalDrivingLicenseApplications where 
                                    ApplicationID = @ApplicationID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];


                }

                reader.Close();
            }
            catch (Exception ex)
            {
                isFind = false;
            }
            finally
            {
                connection.Close();
            }
            return isFind;
        }
        public static bool AddLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            int ID = -1;

            string Query = @"INSERT INTO [dbo].[LocalDrivingLicenseApplications]
                                           ([ApplicationID]
                                           ,[LicenseClassID])
                                     VALUES
                                           (@ApplicationID,@LicenseClassID) ;
                                    select SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            

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


        public static bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @"UPDATE [dbo].[LocalDrivingLicenseApplications]
                                           SET [ApplicationID] = @ApplicationID
                                              ,[LicenseClassID] = @LicenseClassID
                                         WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            

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


        /*        public static DataTable GetTestAppointmentsList()
                {
                    DataTable dt = new DataTable();

                    SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

                    string Query = " select * from Applications_View ";


                    SqlCommand cmd = new SqlCommand(Query, connection);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }

                        cmd.ExecuteReader();


                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }

                    return dt;
                }*/


        public static bool isExist(int LocalDrivingLicenseApplicationID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select found = 1 from LocalDrivingLicenseApplications where " +
                " LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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
                isExist = false;
            }
            finally
            {
                connection.Close();
            }
            return isExist;
        }

        public static bool DeleteByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = " DELETE from LocalDrivingLicenseApplications where " +
                "LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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
                Console.WriteLine(ex.Message);
            }

            finally
            {
                connection.Close();
            }
            return RowEffects > 0;
        }

        public static bool DeleteByApplicationID(int ApplicationID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = " DELETE from LocalDrivingLicenseApplications where " +
                "ApplicationID = @ApplicationID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
                Console.WriteLine(ex.Message);
            }

            finally
            {
                connection.Close();
            }
            return RowEffects > 0;
        }
    }
}
