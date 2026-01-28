using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace WinForm.Minimart
{
    internal class connectDB
    {
        public static SqlConnection ConnectMinimart()
        {
            string serverName = @".\SQLEXPRESS";
            string databaseName = "Minimart";

            string connectionString
                = string.Format("data source={0};initial catalog={1};"
                +"integrated security=True;Encrypt=False"
                , serverName, databaseName);
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
