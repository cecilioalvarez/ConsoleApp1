using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public  class Documento : ICloneable
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Contenido { get; set; }

        public Documento(string id, string nombre, string contenido) {
        
            Id = id;
            Nombre = nombre;
            Contenido = contenido;
            Thread.Sleep(5000);
            Console.WriteLine("validado el documento");
        }
        private Documento()
        {

        }

        public object Clone()
        {
           Documento documento1 = new Documento();
            documento1.Id = Id;
            documento1.Nombre = Nombre + "r1";
            documento1.Contenido = Contenido;
            return documento1;
        }
    }
}
