using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public int Edad { get; set; }

        public string Correo { get; set; }
        public Usuario(string nombre, string clave, int edad, string correo)
        {
            Nombre = nombre;
            Clave = clave;
            Edad = edad;
            Correo = correo;

        }
    }
}
