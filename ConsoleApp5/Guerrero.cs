using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Guerrero :Luchador
    {
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Destreza { get; set; }

        public Guerrero(string Nombre) {

            Fuerza = 4;
            Destreza = 5;
        

        }

        public void Luchar()
        {
          
            Console.WriteLine("el guerrero lucha con Fuerza "+Fuerza+" y Destreza "+Destreza);
        }
    }
}
