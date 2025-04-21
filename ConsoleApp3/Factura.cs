using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class Factura
    {
        public int Numero { get; set; }

        public string Concepto { get; set; }

        public double Importe { get; set; }

        public Factura (int numero, string concepto, double importe) {

            this.Numero = numero;
            this.Concepto = concepto;
            this.Importe = importe;
        
        }

        public abstract double calcularIva();

    }   
}
