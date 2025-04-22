using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public  class Lampara :Encendible
    {

        public void On ()
        {
            Console.WriteLine("la lampara se enciende");

        }
        public void Off()
        {
            Console.WriteLine("la lampara se apaga");

        }
    }
}
