using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public  class FacturaFactory
    {
        public  static Factura getInstance(string tipo, int numero,string concepto, double importe)
        {

            if (tipo.Equals("normal"))
            {

                return new FacturaIVANormal(numero,concepto,importe);
            }else
            {

                return new FacturaIVAReducido(numero, concepto, importe);
            }


        }
    }
}
