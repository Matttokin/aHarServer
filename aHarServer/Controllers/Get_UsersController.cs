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
    public class Get_UsersController : ApiController
    {
        public string Get()
        {
            OracleDataReader d = SendRequests.send("SELECT * FROM users_list");


            List<users> dataList = new List<users>();
            while (d.Read())
            {
                users fl = new users();
                fl.id_user = d.GetInt32(0);
                fl.login = d.GetString(1);
                fl.password = d.GetString(2);
                fl.data = d.GetDateTime(3).ToString();
                fl.role = d.GetInt32(4);
                dataList.Add(fl);
            }

            return JsonConvert.SerializeObject(dataList);
        }
    }
}
