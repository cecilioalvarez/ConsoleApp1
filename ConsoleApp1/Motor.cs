using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Motor
    {
        
        public int Cilindros { get; set; }
        public int Potencia { get; set; }

        //motor
        public string Color { get; set; }

        // Constructor
        public Motor(int cilindros, int potencia, string color)
        {
            Cilindros = cilindros;
            Potencia = potencia;
            Color = color;
        }

        public virtual void Arrancar()
        {
            Console.WriteLine("el motor arranca");
        }
    }
}
