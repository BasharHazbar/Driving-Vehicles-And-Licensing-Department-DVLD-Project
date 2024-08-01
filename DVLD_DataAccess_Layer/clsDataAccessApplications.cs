using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace DVLD_DataAccess_Layer
{
    public class clsDataAccessApplications
    {
        public static bool Find(int ApplicationID, ref int ApplicantPersonID, ref int ApplicationTypeID, 
           ref DateTime ApplicationDate, ref byte ApplicationStatus, ref decimal PaidFees, ref int CreatedByUserID)
        {
            bool isFind = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select * from Applications where ApplicationID = @ApplicationID; ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    isFind = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    PaidFees = (decimal)reader["PaidFees"];
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

        public static int AddApplication(int ApplicantPersonID, int ApplicationTypeID, DateTime ApplicationDate,
            byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            int ID = -1;

            string Query = @"INSERT INTO [dbo].[Applications]
                           ([ApplicantPersonID]
                           ,[ApplicationDate]
                           ,[ApplicationTypeID]
                           ,[ApplicationStatus]
                           ,[LastStatusDate]
                           ,[PaidFees]
                           ,[CreatedByUserID])
                     VALUES
                           (@ApplicantPersonID,
                            @ApplicationDate,
                            @ApplicationTypeID,
                            @ApplicationStatus,
                            @LastStatusDate,
                            @PaidFees,
                            @CreatedByUserID
                            );
                             select SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
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


        public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID, int ApplicationTypeID, DateTime ApplicationDate,
            byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @"UPDATE [dbo].[Applications]
                           SET [ApplicantPersonID] = @ApplicantPersonID
                              ,[ApplicationDate] = @ApplicationDate
                              ,[ApplicationTypeID] = @ApplicationTypeID
                              ,[ApplicationStatus] = @ApplicationStatus
                              ,[LastStatusDate] = @LastStatusDate
                              ,[PaidFees] = @PaidFees
                              ,[CreatedByUserID] = @CreatedByUserID
                         WHERE ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
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
                Console.WriteLine(ex.Message);
            }

            finally
            {
                connection.Close();
            }
            return RowEffects > 0;
        }

        public static int PassedTestCount(int LocalDrivingLicenseApplicationID)
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            int PassedTestCount = -1;


            string Query = @" select count(*) from Tests t join TestAppointments tappo on tappo.TestAppointmentID = t.TestAppointmentID
					                                join LocalDrivingLicenseApplications ldla on ldla.LocalDrivingLicenseApplicationID
					                                = tappo.LocalDrivingLicenseApplicationID
					                                where tappo.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
					                                and t.TestAppointmentID = tappo.TestAppointmentID and t.TestResult = 1 ";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                connection.Open();

                Object Respone = cmd.ExecuteScalar();

                if (Respone != null)
                {
                    PassedTestCount = Convert.ToInt32(Respone);
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();

            }
            return PassedTestCount;
        }


        public static DataTable GetApplicationsList()
        {

            DataTable dt = new DataTable("ApplicationsList");

            dt.Columns.Add("L.D.L.AppID", typeof(int));
            dt.Columns.Add("PersonID", typeof(int));
            dt.Columns.Add("ApplicationID", typeof(int));
            dt.Columns.Add("LicenseClassID", typeof(int));
            dt.Columns.Add("Driving Class", typeof(string));
            dt.Columns.Add("National No.", typeof(string));
            dt.Columns.Add("Full Name", typeof(string));
            dt.Columns.Add("Passed Test", typeof(int)); 
            dt.Columns.Add("Status", typeof(string));

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @" SELECT LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID as 'L.D.L.AppID',
                                People.PersonID,
								Applications.ApplicationID,
                                LicenseClasses.LicenseClassID,
                        
								LicenseClasses.ClassName as 'Driving Class',
								People.NationalNo as 'National No.',
                                case 
                                when People.ThirdName is not null then 
                                 People.FirstName + ' '  + People.SecondName + ' '  + 
					                                + ' '  + People.ThirdName + ' '  + 
					                                People.LastName
                                when People.ThirdName is null then 
                                 People.FirstName + ' '  + People.SecondName + ' '  + People.LastName
 					                                else 'Unknown'
					                                end as 'Full Name',
					                                case 
					                                when Applications.ApplicationStatus = 1 then 'New'
					                                when Applications.ApplicationStatus = 2 then 'Cancelled'
					                                when Applications.ApplicationStatus = 3 then 'Completed'
					                                else 'Unknown'
					                                end as Status
                                                    FROM Applications INNER JOIN
                                                    LocalDrivingLicenseApplications ON Applications.ApplicationID = 
                                                    LocalDrivingLicenseApplications.ApplicationID INNER JOIN
                                                  People ON Applications.ApplicantPersonID = People.PersonID
				                                   INNER JOIN Users ON Users.UserID = Applications.CreatedByUserID
				                                  INNER JOIN
                                                  LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID; ";


            SqlCommand cmd = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    DataRow row = dt.NewRow();

                    row["L.D.L.AppID"] = reader["L.D.L.AppID"];
                    row["PersonID"] = reader["PersonID"];
                    row["ApplicationID"] = reader["ApplicationID"];
                    row["LicenseClassID"] = reader["LicenseClassID"];
                    row["Driving Class"] = reader["Driving Class"];
                    row["National No."] =  reader["National No."];
                    row["Full Name"] = reader["Full Name"];
                    row["Passed Test"] = PassedTestCount((int)reader["L.D.L.AppID"]);
                    row["Status"] = reader["Status"];

                    dt.Rows.Add(row);

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


        public static DataTable GetApplicationInfo(int LocalDrivingLicenseApplicationID)
        {
            DataTable dt = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @" SELECT Applications.ApplicationID as ID, LicenseClasses.ClassName,
                                LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID as 'L.D.L.AppID',
                                ApplicationTypes.ApplicationTypeTitle as Type,ApplicationTypes.ApplicationFees as Fees,
                                case 
                                when People.ThirdName is not null then 
                                 People.FirstName + ' '  + People.SecondName + ' '  + 
					                                + ' '  + People.ThirdName + ' '  + 
					                                People.LastName
                                when People.ThirdName is null then 
                                 People.FirstName + ' '  + People.SecondName + ' '  + People.LastName
 					                                else 'Unknown'
					                                end as Applicant,
                                convert(varchar,  Applications.ApplicationDate, 0) as Date,
                                convert(varchar,  Applications.LastStatusDate, 0) as 'Status Date',
                                People.PersonID,
					                                case 
					                                when Applications.ApplicationStatus = 1 then 'New'
					                                when Applications.ApplicationStatus = 2 then 'Cancelled'
					                                when Applications.ApplicationStatus = 3 then 'Completed'
					                                else 'Unknown'
					                                end as Status,
					                                (select count(*) from Tests t
					                                join TestAppointments tappo on tappo.TestAppointmentID = t.TestAppointmentID
					                                join LocalDrivingLicenseApplications ldla on ldla.LocalDrivingLicenseApplicationID
					                                = tappo.LocalDrivingLicenseApplicationID
					                                where tappo.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
					                                and t.TestAppointmentID = tappo.TestAppointmentID and t.TestResult = 1 ) as 'Passed Test',
					                                Users.UserName as 'User Name'
                                                    FROM Applications INNER JOIN
                                                    LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN
                                                  People ON Applications.ApplicantPersonID = People.PersonID
				                                   INNER JOIN Users ON Users.UserID = Applications.CreatedByUserID
				                                  INNER JOIN
                                                  LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID INNER JOIN
                                                  ApplicationTypes ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID

				                                  where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID; ";


            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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
                Console.WriteLine(ex.ToString());

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }


        public static bool isExistByApplicationID(int ApplicationID)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = " select found = 1 from Applications where ApplicationID = @ApplicationID ";

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

            string query = " select found = 1 from Applications where ApplicationPersonID = @ApplicationPersonID ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationPersonID", PersonID);

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

        public static bool isExistApplicationInSameClassLicense(int ApplicationPersonID, string ClassName)
        {
            bool isExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string query = @" SELECT Found = 1
                  FROM  Applications INNER JOIN
                  People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN
                  LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN
                  LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
				  where (People.PersonID = @ApplicationPersonID and LicenseClasses.ClassName = @ClassName ) and (Applications.ApplicationStatus = 1 or Applications.ApplicationStatus = 3); ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);

            cmd.Parameters.AddWithValue("@ClassName", ClassName);


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

        public static bool Delete(int ApplicationID)
        {

            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = " DELETE from Applications where ApplicationID = @ApplicationID ";

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

        public static bool ChangeStatusApplication(int ApplicationID, byte ApplicationStatus)
        {
            int RowEffects = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionDbInfo);

            string Query = @"UPDATE [dbo].[Applications]
                           SET
                              [ApplicationStatus] = @ApplicationStatus,
                              [LastStatusDate] = @LastStatusDate
                         WHERE ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);

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
