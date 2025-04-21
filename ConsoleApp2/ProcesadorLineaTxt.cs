using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ProcesadorLineaTxt : ProcesadorLinea
    {
        public override Factura procesar(string linea)
        {
            var textoLineas = linea.Split(",");
            return  new Factura(Convert.ToInt32(textoLineas[0]), textoLineas[1], Convert.ToDouble(textoLineas[2]));

        }
    }
}
