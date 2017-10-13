using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servey
{
    class Database
    {
        private string CONN_STRING = @"Server=tcp:sstorage.database.windows.net,1433;Initial Catalog=survey;Persist Security Info=False;User ID={sqladmin};Password={Project1};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";



        //        private SqlConnection conn;

        //        public Database()
        //        {
        //            conn = new SqlConnection();
        //            conn.ConnectionString = connString;
        //            conn.Open();
        //        }

        //        public List<User> GetAllUsers()
        //        {
        //            List<User> result = new List<User>();
        //            SqlCommand selectCommand;


        //            selectCommand = new SqlCommand("SELECT * FROM Users ORDER BY Id", conn);


        //            using (SqlDataReader reader = selectCommand.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    int xId = (int)reader["Id"];
        //                    string xName = (string)reader["Name"];
        //                    string xphone = (string)reader["phone"];
        //                    string xEmail = (string)reader["Email"];



        //                    User u = new User
        //                    {
        //                        Id = xId,
        //                        Name = xName,
        //                        phone = phone,
        //                        Email = xEmail,
        //                    };
        //                    result.Add(u);
        //                }
        //            }
        //            return result;
        //        }


        //    }
        //}

    }
}