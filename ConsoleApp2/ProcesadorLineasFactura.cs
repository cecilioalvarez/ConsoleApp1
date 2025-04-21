using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ProcesadorLineasFactura
    {
        private LectorFichero _lectorFichero;



        public ProcesadorLineasFactura(LectorFichero lectorFichero)
        {
            _lectorFichero = lectorFichero;
        }

        public List<Factura> Procesar()
        {
            List<Factura> listaFacturas = new List<Factura>();

            foreach (string linea in _lectorFichero.LeerLineas())
            {
                string[] textoLineas = new string[3];

                //extension

                ProcesadorLinea procesadorLinea = ProcesadorLinea.getProcesador(_lectorFichero.Extension());
                Factura f =  procesadorLinea.procesar(linea);
                listaFacturas.Add(f);
            }

            return listaFacturas;
        }
    }

}
