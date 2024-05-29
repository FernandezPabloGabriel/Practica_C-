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
    public partial class AltaPersona : Form
    {
        public AltaPersona()
        {
            InitializeComponent();
        }

        private void AltaPersona_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            mtxtCantHijos.Enabled = false;

            comCarrera.Items.Add("Ing. en Sistemas");
            comCarrera.Items.Add("Ing. Electrónica");
            comCarrera.Items.Add("Ing. Mecánica");

            comTipoDocumento.Items.Add("Pasaporte");
            comTipoDocumento.Items.Add("DNI");
            comTipoDocumento.Items.Add("Carnet de Conducir");
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string resultado = "";

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string fechaNac = mtxtNacimiento.Text;
            string sexo = "";
            if (radMasculino.Checked)
            {
                sexo = "Masculino";
            }
            if (radFemenino.Checked)
            {
                sexo = "Femenino";
            }
            if (radOtro.Checked)
            {
                sexo = "Otro";
            }
            string tipoDoc = comTipoDocumento.GetItemText(comTipoDocumento.SelectedItem);
            string nroDoc = mtxtNroDoc.Text;
            string calle = txtCalle.Text;
            string nroCalle = txtNroCalle.Text;

            string soltero = "";
            string casado = "";
            string conHijos = "";
            string cantHijos = "";

            if (chkCasado.Checked) 
            {
                casado = "Casado";
            }
            else  
            {
                casado = "No est casado";
            }

            if (chkSoltero.Checked)
            {
                soltero = "Soltero :D";
            }
            else
            {
                soltero = "No es soltero D:";
            }

            if (chkHijos.Checked)
            {
                conHijos = "Tiene Hijos";

            }
            else
            {
                conHijos = "No tiene Hijos";
            }
            cantHijos = mtxtCantHijos.Text;

            string carrera = comCarrera.GetItemText(comCarrera.SelectedItem);

            //Validacion
            bool tieneDoc = false;
            bool tieneNom = false;
            bool tieneApe = false;

            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingrese un Nombre...");
                txtNombre.Focus();
            }
            else
            {
                tieneNom = true;

                if (txtApellido.Text.Equals(""))
                {
                    MessageBox.Show("Por favor ingrese un Apellido...");
                    txtApellido.Focus();
                }
                else
                {
                    tieneApe = true;

                    if (mtxtNroDoc.Text.Equals(""))
                    {
                        MessageBox.Show("Por favor ingrese un Número de Documento...");
                        mtxtNroDoc.Focus();
                    }
                    else
                    {
                        if (ExisteEnGrilla(nroDoc) == false)
                        {
                            tieneDoc = true;
                        }
                        else
                        {
                            MessageBox.Show("Esta persona ya a sido agregada anteriormente...");
                            mtxtNroDoc.Focus();
                        }
                    }
                }
            }

            if (tieneDoc && tieneApe && tieneNom)
            {
                Persona persona = new Persona(nroDoc, apellido, nombre);
                AgregarPersona(persona);
                LimpiarCampos();
                txtNombre.Focus();
            }
            
        }

        private void chkHijos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHijos.Checked)
            {
                mtxtCantHijos.Enabled = true;
            }
            else
            {
                mtxtCantHijos.Enabled = false;
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            mtxtNacimiento.Text = "";
            radMasculino.Checked = true;
            mtxtNroDoc.Text = "";
            txtCalle.Text = "";
            txtNroCalle.Text = "";
            chkCasado.Checked = false;
            chkSoltero.Checked = false;
            chkHijos.Checked = false;
            mtxtCantHijos.Text = "";
        }

        private void AgregarPersona(Persona persona)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaDoc = new DataGridViewTextBoxCell();
            celdaDoc.Value = persona.DocumentoPer;
            fila.Cells.Add(celdaDoc);

            DataGridViewTextBoxCell celdaNom = new DataGridViewTextBoxCell();
            celdaNom.Value = persona.NombrePer;
            fila.Cells.Add(celdaNom);

            DataGridViewTextBoxCell celdaApe = new DataGridViewTextBoxCell();
            celdaApe.Value = persona.ApellidoPer;
            fila.Cells.Add(celdaApe);

            gdrPersonas.Rows.Add(fila);
            MessageBox.Show("Persona agregada con EXITO!");
        }

        private bool ExisteEnGrilla(string criterioABuscar)
        {
            bool resultado = false;

            for (int i = 0; i < gdrPersonas.Rows.Count; i++)
            {
                if (gdrPersonas.Rows[i].Cells["Documento"].Value.Equals(criterioABuscar))
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }
    }
}
