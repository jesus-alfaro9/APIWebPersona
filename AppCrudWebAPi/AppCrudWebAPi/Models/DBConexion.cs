using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AppCrudWebAPi.Models
{
    public class DBConexion
    {
        static string conex;
        public DBConexion()
        {
            conex = ConfigurationManager.ConnectionStrings["conex"].ConnectionString;
        }

        public SqlConnection getconexion()
        {
            SqlConnection cn = new SqlConnection(conex);
            return cn;
        }

    }
}