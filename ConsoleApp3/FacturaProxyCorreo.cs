using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class FacturaProxyCorreo : Factura
    {
        private FacturaIVAReducido Factura;
        public FacturaProxyCorreo(FacturaIVAReducido factura)
        {

            this.Factura = factura;
            Console.WriteLine(Factura.Numero);
            Console.WriteLine(Factura.Concepto);
            Console.WriteLine(Factura.Importe);
            Console.WriteLine(" se ha creado una factura con iva reducido emviando correo");
        }

        public override  int Numero
        {
            get
            {

                Console.WriteLine(" accedemos a numero");

                return Factura.Numero;
            }
            set
            {

                Factura.Numero = value;
            }
        }


        public override string Concepto
        {
            get
            {

                Console.WriteLine(" accedemos a cooncepto");

                return Factura.Concepto;
            }
            set
            {

                Factura.Concepto = value;
            }
        }


        public override double Importe
        {
            get
            {


                Console.WriteLine(" accedemos a importe");
                return Factura.Importe;
            }
            set
            {

                Factura.Importe = value;
            }
        }
        public override double calcularIva()
        {
            
           return Factura.calcularIva();
        }



    }
}
