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
    public class Update_passwordController : ApiController
    {
        public void Get(string id_local, string new_password)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = db.conn;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE users_list SET password_user ='" + new_password + "', data_izmenenia = SYSDATE WHERE  id_user =" + id_local;

            cmd.ExecuteNonQuery();
        }
    }
}
