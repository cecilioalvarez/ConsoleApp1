using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class ProcesadorLinea
    {
        public static ProcesadorLinea getProcesador(string extension)
        {

            ProcesadorLinea procesadorLinea = null;

            string extensionFinal = char.ToUpper(extension[0]) + extension.Substring(1);

            Type tipo = Type.GetType("ConsoleApp2.ProcesadorLinea" + extensionFinal);

            procesadorLinea = (ProcesadorLinea?)Activator.CreateInstance(tipo);

          
            return procesadorLinea;

        }

        public abstract Factura procesar(string linea);
       
    }
}
