using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Televisor : Encendible
    {
        public void Off()
        {
            Console.WriteLine("el televisor se apaga");
        }

        public void On()
        {
            Console.WriteLine("el televisor se enciende");
        }
    }
}
