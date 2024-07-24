using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess_Layer
{
    public class clsDataAccessTestAppointments
    {
        public static bool Find(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID,
           ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, 
           ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select * from TestAppointments where TestAppointmentID = @TestAppointmentID ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    IsLocked = (bool)reader["IsLocked"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    RetakeTestApplicationID = reader["RetakeTestApplicationID"] == DBNull.Value ? -1 : 
                        (int)reader["RetakeTestApplicationID"];

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

        public static int AddTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID,
            DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            int ID = -1;

            string Query = @"INSERT INTO [dbo].[TestAppointments]
                                       ([TestTypeID]
                                       ,[LocalDrivingLicenseApplicationID]
                                       ,[AppointmentDate]
                                       ,[PaidFees]
                                       ,[CreatedByUserID]
                                       ,[IsLocked]
                                       ,[RetakeTestApplicationID])
                                 VALUES
                                       (@TestTypeID,
                                        @LocalDrivingLicenseApplicationID,
                                        @AppointmentDate,
                                        @PaidFees,@CreatedByUserID,@IsLocked,
                                        @RetakeTestApplicationID);
                                       select SCOPE_IDENTITY(); ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            cmd.Parameters.AddWithValue("@IsLocked", IsLocked);

            cmd.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID == -1 ? 
                (object)DBNull.Value : RetakeTestApplicationID);

          

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
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();

            }
            return ID;
        }


        public static bool UpdateTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID,
            DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @"UPDATE [dbo].[TestAppointments]
                                   SET [TestTypeID] = @TestTypeID
                                      ,[LocalDrivingLicenseApplicationID] = @LocalDrivingLicenseApplicationID
                                      ,[AppointmentDate] = @AppointmentDate
                                      ,[PaidFees] = @PaidFees
                                      ,[CreatedByUserID] = @CreatedByUserID
                                      ,[IsLocked] = @IsLocked
                                      ,[RetakeTestApplicationID] = @RetakeTestApplicationID
                                 WHERE TestAppointmentID = @TestAppointmentID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsLocked", IsLocked);

            cmd.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID == -1 ?
                (object)DBNull.Value : RetakeTestApplicationID);

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

        public static bool LockedTestAppointment(int TestAppointmentID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @"UPDATE [dbo].[TestAppointments]
                                   SET 
                                      [IsLocked] = 1
                                 WHERE TestAppointmentID = @TestAppointmentID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

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

        public static DataTable GetTestAppointmentsList(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @" select TestAppointmentID as 'Appointment ID', 
                                    convert(varchar, AppointmentDate , 0) as 'Appointment Date'
                                    , PaidFees as 'Paid Fees', IsLocked as 'Is Locked' from TestAppointments Where 
                                    LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID = @TestTypeID Order by TestAppointmentID desc ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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


        public static bool isExist(int TestAppointmentID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select found = 1 from TestAppointments where TestAppointmentID = @TestAppointmentID ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

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

        public static bool isHasActiveAppointment(int LocalDrivingLicenseApplicationID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = @" select Found = 1 from TestAppointments Where
                        LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and IsLocked = 0; ";

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

        public static bool isPassedTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = @" select Found = 1 From Tests t
                    Join TestAppointments ta on ta.TestAppointmentID = t.TestAppointmentID
                    join TestTypes tp on tp.TestTypeID = ta.TestTypeID
                    join LocalDrivingLicenseApplications ldla on ldla.LocalDrivingLicenseApplicationID = ta.LocalDrivingLicenseApplicationID
                    where ldla.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and tp.TestTypeID = @TestTypeID and t.TestResult = 1; ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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

        public static int CountTrail(int LocalDrivingLicenseApplicationID,int TestTypeID)
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            int CountTrail = 0;


            string Query = @"select Count(*) from TestAppointments where 
									LocalDrivingLicenseApplicationID  = @LocalDrivingLicenseApplicationID
									and TestTypeID = @TestTypeID and IsLocked = 1; ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
          

            try
            {
                connection.Open();

                Object Respone = cmd.ExecuteScalar();

                if (Respone != null)
                {
                    CountTrail = Convert.ToInt32(Respone);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();

            }
            return CountTrail;
        }

        /*     public static bool Delete(int TestAppointmentID)
             {

                 int RowEffects = 0;

                 SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

                 string Query = " DELETE from TestAppointments where TestAppointmentID = @TestAppointmentID ";

                 SqlCommand cmd = new SqlCommand(Query, connection);

                 cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

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
    }
}
