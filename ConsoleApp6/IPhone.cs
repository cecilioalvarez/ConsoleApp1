using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class IPhone : ITelefono
    {
        public void foto()
        {
            Console.WriteLine("foto");
        }

        public void llamar()
        {
            Console.WriteLine("llamar");
        }

        public void mensaje()
        {
            Console.WriteLine("mensaje");
        }

        public void video()
        {
            Console.WriteLine("video");
        }
    }
}
