using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Proyecto_Empleado.Datos
{
    class clConexion
    {
        public static MySqlConnection obtenerConexion()
        {
         MySqlConnection conexion = new MySqlConnection("server=localhost,database=dbEmpleado,user=root,password=1234");
            conexion.Open();
            return conexion;
        }

    }
}
