using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess_Layer
{
    public class clsDataAccessTestTypes
    {

        public static bool Find(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref decimal TestTypeFees)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select * from TestTypes where TestTypeID = @TestTypeID; ";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    TestTypeID = (int)reader["TestTypeID"];
                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestTypeDescription = (string)reader["TestTypeDescription"];
                    TestTypeFees = (decimal)reader["TestTypeFees"];

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

        public static bool UpdateTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @"UPDATE [dbo].[TestTypes]
                                       SET [TestTypeTitle] = @TestTypeTitle
                                          ,[TestTypeDescription] = @TestTypeDescription
                                          ,[TestTypeFees] = @TestTypeFees
                                     WHERE TestTypeID = @TestTypeID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            cmd.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            cmd.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

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
                Console.WriteLine(ex.ToString());
            }

            finally
            {
                connection.Close();
            }
            return RowEffects > 0;
        }

        public static DataTable GetTestTypesList()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = " select TestTypeID AS ID, TestTypeTitle AS Title, TestTypeDescription AS Description, TestTypeFees AS Fees from TestTypes; ";


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


        public static bool Delete(int TestTypeID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = " DELETE from TestTypes where TestTypeID = @TestTypeID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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


    }
}
