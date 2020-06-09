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
    public class Update_userController : ApiController
    {
        public void Get(string id, string login, string password, string roleid)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = db.conn;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE users_list SET login_user = '" + login + "', password_user = '" +
                password + "', role = '" +
                roleid + "' WHERE id_user = " + id;

            cmd.ExecuteNonQuery();
        }
    }
}
