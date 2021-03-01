using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Empleado.Datos1;
using MySql.Data.MySqlClient;

namespace Proyecto_Empleado.Presentacion1
{
    public partial class frmLiquidacion : Form
    {
        public frmLiquidacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            clConexion conexion = new clConexion();
            
            string consulta = ("select Documento from empleado where documento=@documento"+ txtDocumento.Text+"");

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion;

 
              


                


        }
    }
}
