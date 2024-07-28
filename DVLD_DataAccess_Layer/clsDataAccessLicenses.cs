using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_DataAccess_Layer
{
    public class clsDataAccessLicenses
    {

        private static object CheckIsNullOrEmpty(string Value)
        {
            return string.IsNullOrEmpty(Value) ? (object)DBNull.Value : Value;
        }
        public static bool Find(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClassID,ref DateTime IssueDate,
           ref DateTime ExpirationDate,ref string Notes, ref decimal PaidFees, ref bool IsActive, ref byte IssueReason,
           ref int CreatedByUserID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select * from Licenses where LicenseID = @LicenseID; ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    ApplicationID = (int)reader["ApplicationID"];

                    DriverID = (int)reader["DriverID"];

                    LicenseClassID = (int)reader["LicenseClassID"];

                    IssueDate = (DateTime)reader["IssueDate"];

                    ExpirationDate = (DateTime)reader["ExpirationDate"];

                    if (reader["Notes"] != DBNull.Value)
                    {
                        Notes = (string)reader["Notes"];
                    }

                    PaidFees = (decimal)reader["PaidFees"];

                    IsActive = (bool)reader["IsActive"];

                    IssueReason = (byte)reader["IssueReason"];

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

        public static int AddLicense(int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate,
           DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            int ID = -1;

            string Query = @"INSERT INTO [dbo].[Licenses]
                                           ([ApplicationID]
                                           ,[DriverID]
                                           ,[LicenseClassID]
                                           ,[IssueDate]
                                           ,[ExpirationDate]
                                           ,[Notes]
                                           ,[PaidFees]
                                           ,[IsActive]
                                           ,[IssueReason]
                                           ,[CreatedByUserID])
                                     VALUES
                                           (@ApplicationID,@DriverID,@LicenseClassID,@IssueDate,@ExpirationDate
                                             ,@Notes,@PaidFees,@IsActive,@IssueReason,@CreatedByUserID) ;
                                    select SCOPE_IDENTITY(); ";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);



            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);



            cmd.Parameters.AddWithValue("@Notes", CheckIsNullOrEmpty(Notes));

            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);

            cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
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


        public static bool UpdatLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate,
           DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @"UPDATE [dbo].[Licenses]
                                       SET [ApplicationID] = @ApplicationID
                                          ,[DriverID] = @DriverID
                                          ,[LicenseClassID] = @LicenseClassID
                                          ,[IssueDate] = @IssueDate
                                          ,[ExpirationDate] = @ExpirationDate
                                          ,[Notes] = @Notes
                                          ,[PaidFees] = @PaidFees
                                          ,[IsActive] = @IsActive
                                          ,[IssueReason] = @IssueReason
                                          ,[CreatedByUserID] = @CreatedByUserID
                                     WHERE  LicenseID = @LicenseID; ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);

            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

            cmd.Parameters.AddWithValue("@Notes", CheckIsNullOrEmpty(Notes));

            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
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
                Console.WriteLine(ex);
            }

            finally
            {
                connection.Close();
            }
            return RowEffects > 0;
        }

        public static DataTable GetLicensesListByPersonID(int PersonID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @" Select li.LicenseID as 'L.Lic ID', li.ApplicationID as 'App ID',
                                    lc.ClassName as 'Class Name', 
                                      convert(varchar,  li.IssueDate, 106)  as 'IssueDate Date',
                                      convert(varchar,  li.ExpirationDate, 106)  as 'Expiration Date',
                                    li.IsActive as 'Is Active' from Licenses li
                                    join Drivers dr on dr.DriverID = li.DriverID
                                    join LicenseClasses lc on lc.LicenseClassID = li.LicenseClassID
                                    where dr.PersonID = @PersonID ";


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

        public static DataTable GetLicensesInfo(int ApplicationID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @"select Lc.ClassName,  case 
                                            when p.ThirdName is not null then 
                                             p.FirstName + ' '  + p.SecondName + ' '  + 
					                                            + ' '  + p.ThirdName + ' '  + 
					                                            p.LastName
                                            when p.ThirdName is null then 
                                             p.FirstName + ' '  + p.SecondName + ' '  + p.LastName
 					                                            else 'Unknown'
					                                            end as 'FullName',
					                                            ls.LicenseID,p.NationalNo,
					                                            case 
						                                            when p.Gendor = 0 then 'Male'
						                                            when p.Gendor = 1 then 'Female'
						                                            else 'Unknown'
						                                            end as Gendor,
					                                            convert(varchar,ls.IssueDate , 106) as IssueDate,
					                                            convert(varchar,ls.ExpirationDate , 106) as ExpirationDate,
					                                            case 
						                                        when ls.IssueReason = 1 then 'First Time'
						                                        when ls.IssueReason = 2 then 'Renew'
						                                        when ls.IssueReason = 3 then 'Replacement For Damaged Complated'
						                                        when ls.IssueReason = 4 then 'Replacement For Lost'
						                                        else 'Unknown'
						                                        end as IssueReason,
					                                            case 
					                                            when ls.IsActive = 0 then 'No'
					                                            when ls.IsActive = 1 then 'Yes' 
					                                            else 'Unknown'
					                                            end as IsActive,
					                                            convert(varchar,p.DateOfBirth , 106) as DateOfBirth,
					                                            d.DriverID,
                                                                case 
					                                            when ls.Notes is NULL then 'No Notes'
					                                            when ls.Notes is not null then ls.Notes
					                                            else 'Unknown'
					                                            end as Notes,
                                                                p.ImagePath
                                            from Licenses ls 
                                            join Applications app on app.ApplicationID = ls.ApplicationID
                                            join Drivers d on d.DriverID = ls.DriverID
                                            join LicenseClasses lc on lc.LicenseClassID = ls.LicenseClassID
                                            join People p on p.PersonID = d.PersonID
                                            Where ls.ApplicationID = @ApplicationID";


            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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


        public static bool isExist(int ApplicationID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select found = 1 from Licenses where ApplicationID = @ApplicationID ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static bool IsHasIssuedLicense(int ApplicationID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = @" select Found = 1 from Licenses li
                                        join Applications app  on app.ApplicationID = li.ApplicationID
                                        where li.ApplicationID = @ApplicationID and app.ApplicationStatus = 3; ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static bool IsOrdinarydrivinglicense(int LicenseID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = @"select * from Licenses li
                                where LicenseID = @LicenseID and LicenseClassID = 3;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

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

        public static bool Delete(int LicenseID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = " DELETE from Licenses where LicenseID = @LicenseID ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

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
