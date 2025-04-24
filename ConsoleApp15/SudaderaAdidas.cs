using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class SudaderaAdidas : Sudadera
    {
        public override void Cerrar()
        {
            Console.WriteLine("cerramos la sudadera adidas con cremallera");
        }

        public override void Poner()
        {
            Console.WriteLine("nos ponemos la adidas");
        }
    }
}
