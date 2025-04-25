using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Documento
    {
        public List<String> Parrafos { get; set; } = new List<string>();

        public Documento() { }

        public void addParrafo(String parrafo)
        {
            Parrafos.Add(parrafo);
        }
        public void imprimir()
        {

            foreach (String parrafo in Parrafos)
            {
                Console.WriteLine(parrafo);
            }
        }

    }
}
