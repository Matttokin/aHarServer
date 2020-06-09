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
    public class syshnosteController : ApiController
    {
        public string Get(string id_pol)
        {
            OracleDataReader d = SendRequests.send("SELECT data_lists.ID_TABLE " +
                                                    "FROM data_lists, users_list, role_user " +
                                                    "WHERE data_lists.UROVEN_KRITICHNOSTI <= role_user.UROVEN_PROZRACHNOSTI AND users_list.role = role_user.id_role AND users_list.id_user = " + id_pol);


            List<int> dataList = new List<int>();
            while (d.Read())
            {
                dataList.Add(d.GetInt32(0));
            }

            return JsonConvert.SerializeObject(dataList);
        }
    }
}
