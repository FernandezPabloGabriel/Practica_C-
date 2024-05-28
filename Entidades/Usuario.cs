using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_V2.Entidades
{
    public class Usuario //Puede ser accedida por cualquier elemento fuera del namespace
    {
        // Declaramos atributos como privados, estableciendo que solo puede ser modificado por la propía clase
        private string NomUsuario;
        private string Pass;

        public Usuario(string nombreUsuario, string password) //Constructor
        {
            /* Opcion 1
            this.NomUsuario = NomUsuario;
            this.Pass = Pass; */

            // Opcion 2
            NomUsuario = nombreUsuario;
            Pass = password;   
        }

        //Tipo public ya que voy a setear u otener los valores atributos por medio de estos metodos
        public string NombreDeUsuario //Utilizamos un solo metodo para get y set pero pueden estar separados
        {
            // Si invoco NomUsuario, obtengo su valor
            get => NomUsuario;
            // Si utilizo "NomUsuario = valor" le seteo un valor a este atributo
            set => NomUsuario = value;
        }

        public string Password
        {
            get => Pass;
            set => Pass = value;
        }
    }
}
