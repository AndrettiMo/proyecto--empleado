using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Empleado.Presentacion1;

namespace Proyecto_Empleado
{
    public partial class frmLogin : Form
    {
        string[,] arreglo = { { "ramiro@gmail.com", "alessa@gmail.com", "luisa@gmail.com" }, { "1234", "5678", "4321" } };
        int intentos;
        public frmLogin()
        {
            InitializeComponent();
        }



        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text == arreglo[0, 0] && txtContraseña.Text == arreglo[1, 0])
            {
                this.Hide();
                frmPrincipal p = new frmPrincipal();
                p.Show();
            }
            else if (intentos == 3)
            {
                MessageBox.Show("Ha alcanzado el nivel maximo de intentos, Por favor vuelva a intentarlo", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                intentos += 1;
                MessageBox.Show("Error de autenticacion, verifique usuario y/O contraseña ", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContraseña.Text = "";
            }
        }
    }
}
