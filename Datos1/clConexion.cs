using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_Empleado.Datos1
{
    class clConexion
    {

        MySqlConnection objConexion = null;


        public clConexion()
        {
            try
            {
                objConexion = new MySqlConnection("server=localhost; user id=root;Port=3306;database=bdempleadoi;Password=1234");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }



        }
    }
}
