using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess_Layer
{
    public class clsDataAccessUsers
    {


        public static bool Find(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select * from Users where UserID = @UserID ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"]; ;

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

        public static bool Find(string UserName, string Password,ref int UserID, ref int PersonID, ref bool IsActive)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select * from users where UserName = @UserName AND Password = @Password; ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["IsActive"]; ;

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

        public static int AddUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            int ID = -1;

            string Query = @"INSERT INTO [dbo].[Users]
                                           ([PersonID]
                                           ,[UserName]
                                           ,[Password]
                                           ,[IsActive])
                                     VALUES
                                           (@PersonID,
                                            @UserName,
                                            @Password,
                                            @IsActive  
                                            ) ;
                                    select SCOPE_IDENTITY(); ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);

            cmd.Parameters.AddWithValue("@IsActive", IsActive);

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


        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @"UPDATE [dbo].[Users]
                               SET [PersonID] = @PersonID
                                  ,[UserName] = @UserName
                                  ,[Password] = @Password
                                  ,[IsActive] = @IsActive
                             WHERE UserID = @UserID";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);

            cmd.Parameters.AddWithValue("@IsActive", IsActive);


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


        public static DataTable GetUsersList()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = " select * from Users_View Order by 'User ID' desc ";


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


        public static bool isExistByUserID(int UserID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select found = 1 from Users where UserID = @UserID ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool isExistByPersonID(int PersonID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select found = 1 from Users where PersonID = @PersonID ";

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

        public static bool Delete(int UserID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = " DELETE from Users where UserID = @UserID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);

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
