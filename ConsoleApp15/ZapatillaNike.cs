using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class ZapatillaNike : Zapatilla

    {
        public override void Andar()
        {
            Console.WriteLine("andamos muy bien con la zapa nike");
        }

        public override void Correr()
        {
            Console.WriteLine("corremos bien con la zapa nike");
        }
    }
}
