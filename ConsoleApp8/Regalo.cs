using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public abstract class Regalo
    {
        public  string Nombre { get; set; }

        public Regalo(string nombre) {

            Nombre = nombre;
        }
        public abstract bool esCaja();
        public List<Regalo> Regalos { get; set; } = new List<Regalo>();
    }
}
