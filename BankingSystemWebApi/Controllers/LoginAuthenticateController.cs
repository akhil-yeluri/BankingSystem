using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankingSystemWebApi.Controllers
{
    public class LoginAuthenticateController : ApiController
    {
       
        public string Get()
        {
            return "Hello";
        }

        //[HttpGet]
        public string Get(string username,string password)
        {
            string role="failure";
            SqlConnection connection = new SqlConnection(@"Data Source=AKHIL\SQLEXPRESS;Initial Catalog=Bankdb;Integrated Security=True");
            connection.Open();
            string query = "select * from UserTable where id='" + username + "' and password='" + password + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                role = reader.GetString(2);

            connection.Close();
            return role;
        }

        public string Get(string parameter)
        {
            return "You";
        }
    }
}
