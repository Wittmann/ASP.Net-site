using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MySite.Models
{
    public class UserModel
    {
        private string connStr = "";

        public string[] GetUserNames()
        {
            SqlConnection myConn = new SqlConnection(connStr);
            myConn.Open();

            SqlCommand com = myConn.CreateCommand();
            com.CommandText = "SELECT User FROM User";

            SqlDataReader reader = com.ExecuteReader();

            List<string> Users = new List<string>();

            while(reader.Read())
            {
                Users.Add(reader["User"].ToString());
            }

            return Users.ToArray();
        }
    }
}