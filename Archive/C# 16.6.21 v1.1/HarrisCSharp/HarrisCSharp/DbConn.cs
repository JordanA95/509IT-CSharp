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
        private string connstring = "server=harrisandsonsdb.cxw8qnxlxaco.us-east-1.rds.amazonaws.com;User ID=admin;password=Harrisandsons509IT;Database=harrisandsonsdb";

        public DataTable GetAllPersonal()
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

                foreach (var item in personalContacts)
                {
                    var row = personalContactDt.NewRow();

                    row["ContactID"] = item.ContactID;
                    row["ContactFName"] = item.ContactFName;
                    row["ContactLName"] = item.ContactLName;
                    row["ContactpersonalTel"] = item.ContactPersonalTel;
                    row["ContactEmail"] = item.ContactEmail;
                    row["ContactAddr1"] = item.ContactAddr1;
                    row["ContactAddr2"] = item.ContactAddr2;
                    row["ContactCity"] = item.ContactCity;

                    personalContactDt.Rows.Add(row);
                }
                return personalContactDt;
            }
        }

        public DataTable GetAllBusiness()
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

                foreach (var item in businessContacts)
                {
                    var row = businessContactDt.NewRow();

                    row["ContactID"] = item.ContactID;
                    row["ContactFName"] = item.ContactFName;
                    row["ContactLName"] = item.ContactLName;
                    row["ContactBusinessTel"] = item.ContactBusinessTel; ;
                    row["ContactEmail"] = item.ContactEmail;
                    row["ContactAddr1"] = item.ContactAddr1;
                    row["ContactAddr2"] = item.ContactAddr2;
                    row["ContactCity"] = item.ContactCity;

                    businessContactDt.Rows.Add(row);
                }
                return businessContactDt;
            }
        }
        public void InsertPersonal(PersonalContact personalContact)
        {
            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();
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
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void InsertBusiness(BusinessContact businessContact)
        {
            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();
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
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdatePersonal(PersonalContact personalContact)
        {
            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();
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
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateBusiness(BusinessContact businessContact)
        {
            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();
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
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeletePersonal(int id)
        {
            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL deletePersonal(@p1);";
                    cmd.Parameters.AddWithValue("p1", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

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
