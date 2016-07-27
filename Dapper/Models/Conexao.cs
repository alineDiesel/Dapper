using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace Dapper.Models
{
    public static class Conexao
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
        public static SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            return con;
        }

        public static void desconectar()
        {
            con.Close();
        }
    }
}