using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aHarServer.Controllers
{
    public class Insert_filmController : ApiController
    {
        public void Get(string avtor, string nazvanie,string annotacia,string strana,int god,string zhanr)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = db.conn;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO films VALUES ( (SELECT nvl(MAX(ID_FILM) + 1, 1) FROM films), '" + avtor + "', '" + nazvanie + "', '" + annotacia + "', '" + strana + "', " + god + ", '" + zhanr + "' )";

            cmd.ExecuteNonQuery();
        }
    }
}
