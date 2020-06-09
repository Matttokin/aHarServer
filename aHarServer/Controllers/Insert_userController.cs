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
    public class Insert_userController : ApiController
    {
        public void Get(string login, string password, string roleid)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = db.conn;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText =
                "INSERT INTO users_list VALUES ( (SELECT MAX(ID_USER) + 1 FROM users_list), '" + login + "', '" + password + "', '"
                + DateTime.Today.ToString("d") + "', '" + roleid + "' )";

            cmd.ExecuteNonQuery();

        }
    }
}
