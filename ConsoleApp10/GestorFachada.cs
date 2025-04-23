using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class GestorFachada
    {
        private GestorCopiadora Copiadora { get; set; }
        private GestorImpresion Impresora { get; set; }

        public GestorFachada(GestorCopiadora copiadora, GestorImpresion impresora)
        {

            Impresora = impresora;
            Copiadora = copiadora;

        }

        public void CopiarTexto(string texto)
        {

            Copiadora.CopiarTexto(texto);

        }

        public void ImprimirTexto(string texto)
        {

            Impresora.Imprimir(texto);

        }

    }
}
