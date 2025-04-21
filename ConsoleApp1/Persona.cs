using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Persona
    {

        public string Nombre { get; set; }

        // Constructor
        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public virtual void Andar()
        {
            Console.WriteLine("la persona anda a 4 km hora");
        }
    }
}
