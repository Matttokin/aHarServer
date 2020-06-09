using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aHarServer.Controllers
{
    public class Get_data_izmeneniaController : ApiController
    {
        public string Get(string login_local)
        {
            OracleDataReader d = SendRequests.send("SELECT data_izmenenia as Dat FROM users_list WHERE login_user ='" + login_local + "'");

            d.Read();

            if (d.HasRows)
            {
                return d["Dat"].ToString();
            }
            else
            {
                return (-1).ToString();
            }
        }
    }
}
