using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace TestSQL
{
    internal class DB
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; port = 3306; username = root; password = Sultan74; database = telegram");

        public void openConnection()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }

        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        public MySqlConnection getConnection()
        {
            return conn;
        }
    }
}
