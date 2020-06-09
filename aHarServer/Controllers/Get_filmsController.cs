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
    public class Get_filmsController : ApiController
    {
        public string Get()
        {
            OracleDataReader d = SendRequests.send("SELECT * FROM films");


            List<films> dataList = new List<films>();
            while (d.Read())
            {
                films fl = new films();
                fl.id_film = d.GetInt32(0); 
                fl.avtor = d.GetString(1);
                fl.nazvanie = d.GetString(2);
                fl.annotacia = d.GetString(3);
                fl.strana = d.GetString(4);
                fl.god = d.GetInt32(5);
                fl.zhanr = d.GetString(6);
                dataList.Add(fl);
            }

            return JsonConvert.SerializeObject(dataList);
        }
    }
}
