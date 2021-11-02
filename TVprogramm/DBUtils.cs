using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TVprogramm
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {

            string host = "localhost"; //"192.168.205.130";
            int port = 3307;
            string database = "TVprogramma";
            string username = "root";
            string password = "33442715";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
