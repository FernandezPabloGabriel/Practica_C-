using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_V2.Entidades
{
    public class Persona
    {

        private string Documento;
        private string Apellido;
        private string Nombre;

        public Persona(string documento, string apellido, string nombre) 
        {
            Documento = documento;
            Apellido = apellido;
            Nombre = nombre;
        }

    
        public string DocumentoPer
        {

            get => Documento;
            set => Documento = value;
        }

        public string ApellidoPer
        {
            get => Apellido;
            set => Apellido = value;
        }

        public string NombrePer
        {
            get => Nombre;
            set => Nombre = value;
        }
    }
}
