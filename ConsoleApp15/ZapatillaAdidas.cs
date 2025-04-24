using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class ZapatillaAdidas : Zapatilla
    {
        public override void Andar()
        {
            Console.WriteLine("andamos muy amortiguados con adidas");
        }

        public override void Correr()
        {
            Console.WriteLine("corremos muy amortiguados con adidas");
        }
    }
}
