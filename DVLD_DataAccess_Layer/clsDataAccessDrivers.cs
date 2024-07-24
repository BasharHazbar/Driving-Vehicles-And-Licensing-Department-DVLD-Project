using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess_Layer
{
    public class clsDataAccessDrivers
    {


        public static bool Find(int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select * from Drivers where DriverID = @DriverID; ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    PersonID = (int)reader["PersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    

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

        public static bool FindByPersonID(int PersonID, ref int DriverID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select * from Drivers where PersonID = @PersonID; ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    DriverID = (int)reader["DriverID"];
                    PersonID = (int)reader["PersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];


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

        public static int AddDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            int ID = -1;

            string Query = @"INSERT INTO [dbo].[Drivers]
                                           ([PersonID]
                                           ,[CreatedByUserID]
                                           ,[CreatedDate])
                                     VALUES
                                           (@PersonID,
                                            @CreatedByUserID,
                                            @CreatedDate
                                           ); select SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);

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


        /*        public static bool UpdateDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
                {

                    int RowEffects = 0;

                    SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

                    string Query = @"UPDATE [dbo].[Drivers]
                                               SET [PersonID] = @PersonID
                                                  ,[CreatedByUserID] = @CreatedByUserID 
                                                  ,[CreatedDate] = @CreatedDate
                                                 WHERE DriverID = @DriverID ;
                                            select SCOPE_IDENTITY(); ";

                    SqlCommand cmd = new SqlCommand(Query, connection);

                    cmd.Parameters.AddWithValue("@DriverID", DriverID);
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);

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
        */
        public static int ActiveLicensesCount(int DriverID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            int ActiveLicensesCount = -1;

            string Query = @" select Count(*) from Drivers d
                                join Licenses ls on ls.DriverID = d.DriverID
                                where d.DriverID = @DriverID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                Object Respone = cmd.ExecuteScalar();

                if (Respone != null)
                {
                    ActiveLicensesCount = Convert.ToInt32(Respone);
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
            return ActiveLicensesCount;
        }

        public static DataTable GetDriversList()
        {
            DataTable dt = new DataTable("DriversList");

            dt.Columns.Add("Driver ID", typeof(int));
            dt.Columns.Add("Person ID", typeof(int));
            dt.Columns.Add("National No.", typeof(string));
            dt.Columns.Add("Full Name", typeof(string));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Active Licenses", typeof(int));

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @" select d.DriverID as 'Driver ID', p.PersonID as 'Person ID',
                                    p.NationalNo as 'National No.' 
                                    ,case 
                                    when p.ThirdName is not null then 
                                     p.FirstName + ' '  + p.SecondName + ' '  + 
					                                    + ' '  + p.ThirdName + ' '  + 
					                                    p.LastName
                                    when p.ThirdName is null then 
                                     p.FirstName + ' '  + p.SecondName + ' '  + p.LastName
 					                                    else 'Unknown'
					                                    end as 'Full Name', 
					                                    convert(varchar,  d.CreatedDate, 0) as Date 
					                                    from Drivers d
                                    join People p on p.PersonID = d.PersonID ";


            SqlCommand cmd = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {

                    DataRow row = dt.NewRow();

                    row["Driver ID"] = (int)reader["Driver ID"];
                    row["Person ID"] = (int)reader["Person ID"];
                    row["National No."] = (string)reader["National No."];
                    row["Full Name"] = (string)reader["Full Name"];
                    row["Date"] = (string)reader["Date"];
                    row["Active Licenses"] = ActiveLicensesCount((int)reader["Driver ID"]);

                    dt.Rows.Add(row);

                }

                cmd.Clone();


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


/*        public static bool isExist(int DriverID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select found = 1 from Drivers where DriverID = @DriverID ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DriverID", DriverID);

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
        }*/

        public static bool isExistByPersonID(int PersonID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select found = 1 from Drivers where PersonID = @PersonID ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

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


        /*       public static bool Delete(int DriverID)
               {

                   int RowEffects = 0;

                   SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

                   string Query = " DELETE from Drivers where DriverID = @DriverID ";

                   SqlCommand cmd = new SqlCommand(Query, connection);

                   cmd.Parameters.AddWithValue("@DriverID", DriverID);

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

