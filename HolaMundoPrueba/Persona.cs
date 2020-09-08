using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoPrueba
{
    public class Persona
    {
        public string Nombre { set; get; }
        public string Apellido { set; get; }

        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
