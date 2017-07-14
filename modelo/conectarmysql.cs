
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace venta.modelo
{
    
    public class conectarmysql
    {

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=venta; Uid=root; pwd=;");

            conectar.Open();
            return conectar;
        }
    }
}