using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace HarrisCSharp
{
    public class DbConn
    {
        //Database connection string for connecting to the AWS harris Database instance.
        private string connstring = "server=harris.cxw8qnxlxaco.us-east-1.rds.amazonaws.com; Port=3306; Database=harris; User ID=admin; Password=Harrisandsons";

        //Stored procedure for getting all Personal contacts stored in the database.
        public DataTable selectAllPersonal()
        {
            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();
                DataTable personalContactDt = new DataTable();
                List<PersonalContact> personalContacts = new List<PersonalContact>();
                using (var cmd = new MySqlCommand("CALL selectAllPersonal();", conn))

                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        personalContacts.Add(new PersonalContact
                        {
                            ContactID = reader.GetInt32(0),
                            ContactFName = reader.GetString(1),
                            ContactLName = reader.GetString(2),
                            ContactEmail = reader.GetString(3),
                            ContactAddr1 = reader.GetString(4),
                            ContactAddr2 = reader.GetString(5),
                            ContactCity = reader.GetString(6),
                            ContactPostcode = reader.GetString(7),
                            ContactPersonalTel = reader.GetString(8),
                        });
                    }
                personalContactDt.Columns.Add("ContactID");
                personalContactDt.Columns.Add("ContactFirstName");
                personalContactDt.Columns.Add("ContactLastName");
                personalContactDt.Columns.Add("ContactEmail");
                personalContactDt.Columns.Add("ContactAddressLine1");
                personalContactDt.Columns.Add("ContactAddressLine2");
                personalContactDt.Columns.Add("ContactCity");
                personalContactDt.Columns.Add("ContactPostcode");
                personalContactDt.Columns.Add("ContactPersonalTel");

                foreach (var item in personalContacts)
                {
                    var row = personalContactDt.NewRow();

                    row["ContactID"] = item.ContactID;
                    row["ContactFirstName"] = item.ContactFName;
                    row["ContactLastName"] = item.ContactLName;
                    row["ContactEmail"] = item.ContactEmail;
                    row["ContactAddressLine1"] = item.ContactAddr1;
                    row["ContactAddressLine2"] = item.ContactAddr2;
                    row["ContactCity"] = item.ContactCity;
                    row["ContactPostcode"] = item.ContactPostcode;
                    row["ContactpersonalTel"] = item.ContactPersonalTel;

                    personalContactDt.Rows.Add(row);
                }
                return personalContactDt;
            }
        }

        //Stored procedure for getting all Business contacts stored in the database.
        public DataTable selectAllBusiness()
        {
            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();
                DataTable businessContactDt = new DataTable();
                List<BusinessContact> businessContacts = new List<BusinessContact>();
                using (var cmd = new MySqlCommand("CALL selectAllBusiness();", conn))

                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        businessContacts.Add(new BusinessContact
                        {
                            ContactID = reader.GetInt32(0),
                            ContactFName = reader.GetString(1),
                            ContactLName = reader.GetString(2),
                            ContactEmail = reader.GetString(3),
                            ContactAddr1 = reader.GetString(4),
                            ContactAddr2 = reader.GetString(5),
                            ContactCity = reader.GetString(6),
                            ContactPostcode = reader.GetString(7),
                            ContactBusinessTel = reader.GetString(8),
                        });
                    }
                businessContactDt.Columns.Add("ContactID");
                businessContactDt.Columns.Add("ContactFirstName");
                businessContactDt.Columns.Add("ContactLastName");
                businessContactDt.Columns.Add("ContactEmail");
                businessContactDt.Columns.Add("ContactAddressLine1");
                businessContactDt.Columns.Add("ContactAddressLine2");
                businessContactDt.Columns.Add("ContactCity");
                businessContactDt.Columns.Add("ContactPostcode");
                businessContactDt.Columns.Add("ContactBusinessTel");

                foreach (var item in businessContacts)
                {
                    var row = businessContactDt.NewRow();

                    row["ContactID"] = item.ContactID;
                    row["ContactFirstName"] = item.ContactFName;
                    row["ContactLastName"] = item.ContactLName;
                    row["ContactBusinessTel"] = item.ContactBusinessTel; ;
                    row["ContactEmail"] = item.ContactEmail;
                    row["ContactAddressLine1"] = item.ContactAddr1;
                    row["ContactAddressline2"] = item.ContactAddr2;
                    row["ContactCity"] = item.ContactCity;
                    row["ContactPostcode"] = item.ContactPostcode;
                    row["ContactBusinessTel"] = item.ContactBusinessTel;

                    businessContactDt.Rows.Add(row);
                }
                return businessContactDt;
            }
        }
        //Stored procedure for inserting a new Personal contact into the database.
        public async void InsertPersonal(PersonalContact personalContact)
        {
            using (var conn = new MySqlConnection(connstring))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL insertPersonal(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8);";
                    cmd.Parameters.AddWithValue("p1", personalContact.ContactFName);
                    cmd.Parameters.AddWithValue("p2", personalContact.ContactLName);
                    cmd.Parameters.AddWithValue("p3", personalContact.ContactPersonalTel);
                    cmd.Parameters.AddWithValue("p4", personalContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p5", personalContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p6", personalContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p7", personalContact.ContactCity);
                    cmd.Parameters.AddWithValue("p8", personalContact.ContactPostcode);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        //Stored procedure for inserting a new Business contact into the database.
        public async void InsertBusiness(BusinessContact businessContact)
        {
            using (var conn = new MySqlConnection(connstring))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL insertBusiness(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8);";
                    cmd.Parameters.AddWithValue("p1", businessContact.ContactFName);
                    cmd.Parameters.AddWithValue("p2", businessContact.ContactLName);
                    cmd.Parameters.AddWithValue("p3", businessContact.ContactBusinessTel);
                    cmd.Parameters.AddWithValue("p4", businessContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p5", businessContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p6", businessContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p7", businessContact.ContactCity);
                    cmd.Parameters.AddWithValue("p8", businessContact.ContactPostcode);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        //Stored procedure for updating an existing Personal contact in the database.
        public async void UpdatePersonal(PersonalContact personalContact)
        {
            using (var conn = new MySqlConnection(connstring))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL updatePersonal(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9);";
                    cmd.Parameters.AddWithValue("p1", personalContact.ContactID);
                    cmd.Parameters.AddWithValue("p2", personalContact.ContactFName);
                    cmd.Parameters.AddWithValue("p3", personalContact.ContactLName);
                    cmd.Parameters.AddWithValue("p4", personalContact.ContactPersonalTel);
                    cmd.Parameters.AddWithValue("p5", personalContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p6", personalContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p7", personalContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p8", personalContact.ContactCity);
                    cmd.Parameters.AddWithValue("p9", personalContact.ContactPostcode);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        //Stored procedure for updating an existing Business contact in the database.
        public async void UpdateBusiness(BusinessContact businessContact)
        {
            using (var conn = new MySqlConnection(connstring))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL updateBusiness(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9);";
                    cmd.Parameters.AddWithValue("p1", businessContact.ContactID);
                    cmd.Parameters.AddWithValue("p2", businessContact.ContactFName);
                    cmd.Parameters.AddWithValue("p3", businessContact.ContactLName);
                    cmd.Parameters.AddWithValue("p4", businessContact.ContactBusinessTel);
                    cmd.Parameters.AddWithValue("p5", businessContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p6", businessContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p7", businessContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p8", businessContact.ContactCity);
                    cmd.Parameters.AddWithValue("p9", businessContact.ContactPostcode);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        //Stored procedure for deleting a Personal contact from the database using the id value.
        public async void DeletePersonal(int id)
        {
            using (var conn = new MySqlConnection(connstring))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL deletePersonal(@p1);";
                    cmd.Parameters.AddWithValue("p1", id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        //Stored procedure for deleting a Business contact from the database using the id value.
        public void DeleteBusiness(int id)
        {
            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL deleteBusiness(@p1);";
                    cmd.Parameters.AddWithValue("p1", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}