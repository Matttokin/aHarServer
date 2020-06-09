using Newtonsoft.Json;
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
    public class Poisk_id_po_loginuController : ApiController
    {
        public string Get(string login_local)
        {
            OracleDataReader d = SendRequests.send("SELECT tes.Poisk_id_po_loginu('" + login_local + "') as ID FROM dual");

            d.Read();

            if (d.HasRows)
            {
                return d.GetInt32(0).ToString();
            }
            else
            {
                return (-1).ToString();
            }
        }
    }
}
