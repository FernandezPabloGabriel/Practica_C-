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
    public partial class Principal : Form
    {
        public Principal(Usuario usu)
        {
            //inicializa y ejecuta todos los elementos del formulrio
            InitializeComponent();
            lblBienvenido.Text = "Hola " + usu.NombreDeUsuario;
            lblBienvenido.Visible = true;
        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }
    }
}
