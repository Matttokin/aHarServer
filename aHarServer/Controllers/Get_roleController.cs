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
    public class Get_roleController : ApiController
    {
        public string Get()
        {
            OracleDataReader d = SendRequests.send("SELECT * FROM role_user");


            List<role> dataList = new List<role>();
            while (d.Read())
            {
                role fl = new role();
                fl.id_role = d.GetInt32(0);
                fl.name = d.GetString(1);
                fl.lvl = d.GetInt32(2);
                dataList.Add(fl);
            }

            return JsonConvert.SerializeObject(dataList);
        }
    }
}
