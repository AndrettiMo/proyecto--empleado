using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_Empleado.Datos1
{
    class clLiquidacion
    {
       
        public int idEmpleado { get; set; }

        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string fechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }


        public List<clLiquidacion> mtdMostrar()
        {
            string consulta = "select ";
            clConexion objConexion = new clConexion();
            DataTable tblAprendiz = new DataTable();
            tblAprendiz = objConexion.mtdDesconectado(consulta);



        }
}
