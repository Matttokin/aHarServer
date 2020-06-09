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
    public class Delete_filmController : ApiController
    {
        public void Get(string id)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = db.conn;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM films WHERE id_film = " + id;


            cmd.ExecuteNonQuery();
        }
    }
}
