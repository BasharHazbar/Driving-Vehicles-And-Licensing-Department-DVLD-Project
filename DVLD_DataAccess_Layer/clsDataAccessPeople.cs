using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;


namespace DVLD_DataAccess_Layer
{
    public class clsDataAccessPeople
    {

        private static object CheckIsNullOrEmpty(string Value)
        {
            return string.IsNullOrEmpty(Value) ? (object)DBNull.Value : Value;
        }

        public static bool Find(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, 
            ref string LastName, ref DateTime DateOfBirth, ref short Gendor, ref string Address, ref string Email,ref string Phone,
           ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " SELECT * FROM People Where PersonID = @PersonID ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    NationalNo = (string)reader["NationalNo"];

                    FirstName = (string)reader["FirstName"];

                    SecondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                    {

                        ThirdName = (string)reader["ThirdName"];
                    }


                    LastName = (string)reader["LastName"];

                    DateOfBirth = (DateTime)reader["DateOfBirth"];

                    Gendor = (byte)reader["Gendor"];

                    Address = (string)reader["Address"];

                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }

                    Phone = (string)reader["Phone"];
                   

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }

                   
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

        public static bool Find(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName,
            ref string LastName, ref DateTime DateOfBirth, ref short Gendor, ref string Address, ref string Email, ref string Phone,
            ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " SELECT * FROM People Where NationalNo = @NationalNo";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    PersonID = (int)reader["PersonID"];

                    FirstName = (string)reader["FirstName"];

                    SecondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }

                    LastName = (string)reader["LastName"];

                    DateOfBirth = (DateTime)reader["DateOfBirth"];

                    Gendor = (byte)reader["Gendor"];

                    Address = (string)reader["Address"];

                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }

                    Phone = (string)reader["Phone"];


                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
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


        public static int AddPerson(string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, short Gendor, string Address, string Phone,
            string Email, int NationalityCountryID, string ImagePath)
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            int ID = -1;

            string Query = @"INSERT INTO [dbo].[People]
                                   ([NationalNo]
                                   ,[FirstName]
                                   ,[SecondName]
                                   ,[ThirdName]
                                   ,[LastName]
                                   ,[DateOfBirth]
                                   ,[Gendor]
                                   ,[Address]
                                   ,[Phone]
                                   ,[Email]
                                   ,[NationalityCountryID]
                                   ,[ImagePath])
                             VALUES
                                   (@NationalNo,@FirstName,@SecondName,
		                            @ThirdName,@LastName,@DateOfBirth,@Gendor,@Address,@Phone,@Email,
		                            @NationalityCountryID,@ImagePath
		                           );
                                    select SCOPE_IDENTITY(); ";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);

            cmd.Parameters.AddWithValue("@ThirdName", CheckIsNullOrEmpty(ThirdName));

            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

            cmd.Parameters.AddWithValue("@Gendor", Gendor);

            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);

            cmd.Parameters.AddWithValue("@Email", CheckIsNullOrEmpty(Email));

            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            cmd.Parameters.AddWithValue("@ImagePath", CheckIsNullOrEmpty(ImagePath));


            try
            {
                connection.Open();

                Object Respone = cmd.ExecuteScalar();

                if (Respone != null )
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


        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, short Gendor, string Address, string Phone,
            string Email, int NationalityCountryID, string ImagePath)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @"UPDATE [dbo].[People]
                           SET [NationalNo] = @NationalNo
                              ,[FirstName] = @FirstName
                              ,[SecondName] = @SecondName
                              ,[ThirdName] = @ThirdName
                              ,[LastName] = @LastName
                              ,[DateOfBirth] = @DateOfBirth
                              ,[Gendor] = @Gendor
                              ,[Address] = @Address
                              ,[Phone] = @Phone
                              ,[Email] = @Email
                              ,[NationalityCountryID] = @NationalityCountryID
                              ,[ImagePath] = @ImagePath
                         WHERE PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);

            cmd.Parameters.AddWithValue("@ThirdName", CheckIsNullOrEmpty(ThirdName));


            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor", Gendor);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);

            cmd.Parameters.AddWithValue("@Email",CheckIsNullOrEmpty(Email));

            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            cmd.Parameters.AddWithValue("@ImagePath", CheckIsNullOrEmpty(ImagePath));

            try {
                connection.Open();

                Object Respone = cmd.ExecuteNonQuery();

                if (Respone != null)
                {
                    RowEffects = Convert.ToInt32(Respone);
                }
            }

            catch(Exception ex) { 
                
            }

            finally
            {
                connection.Close();
            }
            return RowEffects > 0;
        }


        public static DataTable GetPeapleList()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = " select * from People_View Order by PersonID desc; ";

            
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


        public static bool isExist(int PersonID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select found = 1 from People where PersonID = @PersonID ";

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

        public static bool isExist(string NationalNo)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select found = 1 from People where NationalNo = @NationalNo ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);

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


        public static bool Delete(int PersonID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = " DELETE from People where  PersonID = @PersonID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

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
