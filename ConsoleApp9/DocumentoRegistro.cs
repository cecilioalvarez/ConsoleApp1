using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class DocumentoRegistro : Documento
    {
        public DocumentoRegistro(string textoInicio, string textoContenido, string textoPie) : base(textoInicio, textoContenido, textoPie)
        {
        }

        protected override void Cabecera()
        {

            Console.WriteLine("la cabecer2 del documento" + TextoInicio);
           

        }


        protected override void Pie()
        {

             Console.WriteLine("El pie 2 del documento " + TextoPie);


        }
    }
}
