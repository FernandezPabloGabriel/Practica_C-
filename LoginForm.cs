using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica_V2.Entidades;

namespace Practica_V2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Creamos un objeto de tipo usuario con los valores de las cajas de textp
            Usuario usu = new Usuario(txtUsuario.Text, txtPassword.Text);

            // essageBox.Show("Hola " + usu.NombreDeUsuario + " " + usu.Password);

            string usoCorrecto = "Pablo";
            string passCorrecto = "123456";
            
            //Usuario correcto
            if (txtUsuario.Text.Equals(usoCorrecto) && txtPassword.Text.Equals(passCorrecto))
            {
                MessageBox.Show("Datos CORRECTISIMOS!!!");

                //LLamamos a la ventana principal
                Principal ventana = new Principal(usu);
                ventana.Show();

                /* No podemos usar este metodo ya que se cierra la ventana que inicio el proceso de ejecucion
                 * por lo que se detiene la applicacion
                this.Close();*/

                //Asi que la ocultamos
                this.Hide();
            }
            //Usuario incorrecto
            else
            {
                MessageBox.Show("No es un usuario registrado...");
            }
        }
    }
}
