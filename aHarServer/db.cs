using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aHarServer
{
    static class db
    {
        public static OracleConnection conn;
        public static void connect()
        {
            //открываем соединение и сохраняем дескриптор
            string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= C##vladkv;Password=C##vladkv;";

            conn = new OracleConnection(oradb);
            conn.Open();
        }
    }
}