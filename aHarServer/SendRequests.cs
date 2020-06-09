using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace aHarServer
{
    static class SendRequests
    {
        static public OracleDataReader send(string s)
        {
            Console.WriteLine(s);
            OracleCommand cmd = new OracleCommand(); //инициализируем новый запрос к бд

            cmd.Connection = db.conn; //получаем дескриптор соединения

            cmd.CommandText =
                s; //запрос
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();  //получаем ответ

            return dr; //считываем строку с ответом
        }

        static public string get_rules_and_othr(int id_polz, int id_table)
        {
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = db.conn;
            cmd.CommandText = "labaTHREE.request_role";
            cmd.CommandType = CommandType.StoredProcedure;


            var a = cmd.Parameters.Add("RETURN", OracleDbType.Varchar2, ParameterDirection.ReturnValue);
            a.Size = 200;
            cmd.Parameters.Add("id_users", id_polz);
            cmd.Parameters.Add("id_tabl", id_table);

            cmd.ExecuteReader();

            return cmd.Parameters["RETURN"].Value.ToString();
        }
    }
}