using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aHarServer.Controllers
{
    public class Poisk_password_po_idController : ApiController
    {
        public string Get(string id_local)
        {
            OracleDataReader d = SendRequests.send("SELECT tes.Poisk_password_po_id(" + id_local + ") as Password FROM dual");

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
