using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aHarServer.Controllers
{
    public class Get_dif1Controller : ApiController
    {
        public string Get(string login_local)
        {
            OracleDataReader d = SendRequests.send("SELECT TO_CHAR(MONTHS_BETWEEN((SELECT CURRENT_DATE FROM DUAL),(select data_izmenenia FROM users_list WHERE login_user = '" + login_local + "'))) as dif1 FROM DUAL");

            d.Read();

            if (d.HasRows)
            {
                return d.GetString(0);
            }
            else
            {
                return (-1).ToString();
            }
        }
    }
}
