using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aHarServer.Controllers
{
    public class Get_rules_and_othrController : ApiController
    {
        public string Get(int id_polz, int id_table)
        {
            return SendRequests.get_rules_and_othr(id_polz, id_table);
        }

    }
}
