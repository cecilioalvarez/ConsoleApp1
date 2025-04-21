using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class FacturaIVANormal : Factura
    {

        public FacturaIVANormal(int numero, string concepto, double importe) :base (numero,concepto,importe)
        {

        }
      
        public override double calcularIva()
        {
            return Importe * 1.21;
        }
    }
}
