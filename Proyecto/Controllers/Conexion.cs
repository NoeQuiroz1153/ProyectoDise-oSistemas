using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Controllers
{
    internal class Conexion
    {
        public SqlConnection GetConexion()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["DBPROYECTO"].ToString());
        }


    }
}
