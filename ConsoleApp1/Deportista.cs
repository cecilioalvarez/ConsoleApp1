using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Deportista : Persona
    {
        public Deportista(string nombre) : base(nombre)
        {
        }

        public override void Andar()
        {
            Console.WriteLine("el deportista anda a 8 km/hora");
        }
    }
}
