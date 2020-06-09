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
    public class Update_filmController : ApiController
    {
        public void Get(string id, string avtor, string nazvanie, string annotacia, string strana, string god, string zhanr)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = db.conn;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE films SET avtor = '" + avtor + "', nazvanie = '" +nazvanie + "', annotacia = '" + annotacia + "', strana_prioizvodstva = '" + strana + "', GOD = " + god + ", zhanr = '" + zhanr + "' WHERE id_film = " + id;


            cmd.ExecuteNonQuery();
        }
    }
}
