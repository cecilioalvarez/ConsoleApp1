using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class SudaderaNike : Sudadera
    {
        public override void Cerrar()
        {
            Console.WriteLine("cerramos la sudadera nike ");
        }

        public override void Poner()
        {
            Console.WriteLine("ponemos la sudadera nike");
        }
    }

}
