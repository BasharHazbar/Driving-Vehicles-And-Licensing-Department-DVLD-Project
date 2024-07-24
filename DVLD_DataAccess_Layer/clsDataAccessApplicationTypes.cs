using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess_Layer
{
    public class clsDataAccessApplicationTypes
    {

        public static bool Find(int ApplicationTypeID, ref string ApplicationTypeTitle, ref decimal ApplicationFees)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select * from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = (decimal)reader["applicationFees"];
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

   /*     public static bool AddApplicationType(string ApplicationTypeTitle, float ApplicationFees)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            int ID = -1;

            string Query = @"INSERT INTO [dbo].[ApplicationTypes]
                                               ([ApplicationTypeTitle]
                                               ,[ApplicationFees])
                                         VALUES
                                               (@ApplicationTypeTitle,
		                                       @ApplicationFees);`          
                                    select SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            cmd.Parameters.AddWithValue("@applicationFees", ApplicationFees);

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
        }*/


        public static bool UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @"UPDATE [dbo].[ApplicationTypes]
                                           SET [ApplicationTypeTitle] = @ApplicationTypeTitle
                                              ,[ApplicationFees] = @ApplicationFees
                                         WHERE ApplicationTypeID = @ApplicationTypeID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            cmd.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

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


        public static DataTable GetApplicationTypesList()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = " select ApplicationTypeID as ID, ApplicationTypeTitle AS Title, ApplicationFees AS Fees from ApplicationTypes ";


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
        }


        public static bool isExist(int ApplicationTypeID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select found = 1 from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

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

/*        public static bool Delete(int ApplicationTypeID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = " DELETE from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

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
