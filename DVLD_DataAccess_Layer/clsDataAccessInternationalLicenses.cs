using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess_Layer
{
    public class clsDataAccessInternationalLicenses
    {
        public static bool Find(int InternationalLicenseID, ref int ApplicationID,ref int DriverID,
            ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate,ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = @" select * from InternationalLicenses where 
                                    InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
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

        public static bool FindByDriverID(int DriverID, ref int InternationalLicenseID, ref int ApplicationID,
          ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = @" select * from InternationalLicenses where 
                                    DriverID = @DriverID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    InternationalLicenseID = (int)reader["InternationalLicenseID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
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

        public static int AddLInternationalLicense(int ApplicationID, int DriverID,
            int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            int ID = -1;

            string Query = @"INSERT INTO [dbo].[InternationalLicenses]
                                               ([ApplicationID]
                                               ,[DriverID]
                                               ,[IssuedUsingLocalLicenseID]
                                               ,[IssueDate]
                                               ,[ExpirationDate]
                                               ,[IsActive]
                                               ,[CreatedByUserID])
                                         VALUES
                                               (@ApplicationID,@DriverID,
                                                @IssuedUsingLocalLicenseID,
                                                @IssueDate,@ExpirationDate,
                                                @IsActive,@CreatedByUserID); 
                                    select SCOPE_IDENTITY(); ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);

            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);

            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
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


        public static bool UpdateInternationalLicenses(int InternationalLicenseID, int ApplicationID, int DriverID,
            int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @"UPDATE [dbo].[InternationalLicenses]
                                       SET [ApplicationID] = @ApplicationID
                                          ,[DriverID] = @DriverID
                                          ,[IssuedUsingLocalLicenseID] = @IssuedUsingLocalLicenseID
                                          ,[IssueDate] = @IssueDate
                                          ,[ExpirationDate] = @ExpirationDate
                                          ,[IsActive] = @IsActive
                                          ,[CreatedByUserID] = @CreatedByUserID
                                     WHERE InternationalLicenseID = @InternationalLicenseID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            cmd.Parameters.AddWithValue("@DriverID", DriverID);

            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);

            cmd.Parameters.AddWithValue("@IsActive", IsActive);

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


        public static DataTable GetIntLicensesList()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @" select InternationalLicenseID as 'Int.License ID', ApplicationID as 
                        'Application ID', il.DriverID as 'Driver ID', IssuedUsingLocalLicenseID 
                        as 'L.License ID', dr.PersonID ,convert(varchar, IssueDate  , 0) as 'Issue Date', 
                        convert(varchar, ExpirationDate  , 0) as 'Expiration Date', IsActive as 'Is Active'
                        from InternationalLicenses il
                        join Drivers dr on dr.DriverID = il.DriverID; ";
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

        public static DataTable GetInternationalLicensesListByPersonID(int PersonID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @"  select il.InternationalLicenseID as 'Int License ID', il.ApplicationID as 'Application ID',
                                    il.IssuedUsingLocalLicenseID as 'L.License ID', 
                                     convert(varchar,  il.IssueDate, 0) as 'Issue Date',
                                      convert(varchar,  il.ExpirationDate, 0) as 'Expiration Date',
                                      il.IsActive
                                    from InternationalLicenses il
                                    join Drivers dr on dr.DriverID = il.DriverID
                                    Where dr.PersonID = @PersonID; ";


            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static DataTable GetInternationalLicensesInfo(int InternationalLicenseID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @" Select case  when p.ThirdName is not null then p.FirstName + ' '  + p.SecondName + ' '  + 
                            + ' '  + p.ThirdName + ' '  +  p.LastName when p.ThirdName is null then 
                            p.FirstName + ' '  + p.SecondName + ' '  + p.LastName 
                            else 'Unknown' end as FullName, il.InternationalLicenseID,
                            il.ApplicationID,il.IssuedUsingLocalLicenseID as LicenseID,
                            p.NationalNo,convert(varchar,p.DateOfBirth , 106) as DateOfBirth,
                            case 
                            when p.Gendor = 0 then 'Male'
                            when p.Gendor = 1 then 'Female'
                            else 'Unknown' end as Gender,
                            case 
					        when il.IsActive = 0 then 'No'
					        when il.IsActive = 1 then 'Yes' 
					        else 'Unknown'
					        end as IsActive,
                            il.DriverID,
                            p.ImagePath,
                            convert(varchar,il.IssueDate , 106) as IssueDate,
                            convert(varchar,il.ExpirationDate , 106) as ExpirationDate
                            from InternationalLicenses il
                            join Drivers dr on dr.DriverID = il.DriverID
                            join People p on p.PersonID = dr.PersonID
                            where il.InternationalLicenseID = @InternationalLicenseID; ";


            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

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
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }


        public static bool isExist(int InternationalLicenseID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = @"select Found = 1 from InternationalLicenses where InternationalLicenseID = @InternationalLicenseID; ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

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


        public static bool isExistByDriverID(int DriverID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = @" select Found = 1 from InternationalLicenses where DriverID = @DriverID; ";

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
        }

        public static bool Delete(int LocalDrivingLicenseApplicationID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = " DELETE from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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
