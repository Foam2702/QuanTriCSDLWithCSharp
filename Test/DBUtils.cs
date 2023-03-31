using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace SqlConn
{
    static class DBOracleUtils
    {

        public static OracleConnection
        GetDBConnection(string host, int port, String sid, String user, String password)
        {

            Console.WriteLine("Getting Connection …");

            // ‘Connection String’ kết nối trực tiếp tới Oracle.
            string connString = "Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = "
+ host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
+ sid + "))); Password =" + password + "; User ID = " + user + "; DBA Privilege=SYSDBA";

            OracleConnection conn = new OracleConnection();

            conn.ConnectionString = connString;

            return conn;
        }
        public static class DBUtils
        {
            public static OracleConnection GetDBConnection()
            {
                string host = "localhost";
                int port = 1521;
                string sid = "xe";
                string user = "sys";
                string password = "123";
                return DBOracleUtils.GetDBConnection(host, port, sid, user, password);
            }
        }
    }
}
