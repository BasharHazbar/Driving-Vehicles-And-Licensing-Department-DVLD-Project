using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess_Layer
{
    public class clsDataAccessTests
    {
        public static bool Find(int TestID, ref int TestAppointmentID, ref bool TestResult,ref string Notes, ref int CreatedByUserID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " SELECT * FROM Tests where TestID = @TestID ";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];
                    if (reader["Notes"] != DBNull.Value)
                    {
                        Notes = (string)reader["Notes"];
                    }
                    CreatedByUserID = (int)reader["CreatedByUserID"];

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

        public static int AddTset(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            int ID = -1;

            string Query = @"INSERT INTO [dbo].[Tests]
                                       ([TestAppointmentID]
                                       ,[TestResult]
                                       ,[Notes]
                                       ,[CreatedByUserID])
                                 VALUES
                                       (@TestAppointmentID,@TestResult,@Notes,@CreatedByUserID) ;
                                    select SCOPE_IDENTITY(); ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestResult", TestResult);
            cmd.Parameters.AddWithValue("@Notes", Notes != "" ? Notes : (object)DBNull.Value);

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
            return ID;
        }


        public static bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @"UPDATE [dbo].[Tests]
                                       SET [TestAppointmentID] = @TestAppointmentID
                                          ,[TestResult] = @TestResult
                                          ,[Notes] = @Notes
                                          ,[CreatedByUserID] = @CreatedByUserID
                                     WHERE TestID = @TestID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@TestID", TestID);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestResult", TestResult);

            cmd.Parameters.AddWithValue("@Notes", Notes != "" ? Notes : (object)DBNull.Value);

            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
           

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


        public static DataTable GetTestsList()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = " select * from Tests_View ";


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

        public static bool isExist(int TestID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select found = 1 from Tests where TestID = @TestID ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestID", TestID);

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

/*        public static bool Delete(int TestID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = " DELETE from Tests where TestID = @TestID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@TestID", TestID);

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
