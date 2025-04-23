using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Documento
    {
        public string TextoInicio { get; set; }
        public string TextoContenido { get; set; }

        public string TextoPie { get; set; }
       
        public Documento(string textoInicio, string textoContenido, string textoPie)
        {
            TextoInicio = textoInicio;
            TextoContenido = textoContenido;
            TextoPie = textoPie;
        }
       
        protected virtual void Cabecera()
        {
            Console.WriteLine("la cabecera del documento" + TextoInicio);


        }

        protected  virtual void Contenido()
        {
            Console.WriteLine("el contenido del documento" + TextoContenido);


        }

        protected virtual void Pie()
        {
            Console.WriteLine("el pie del documento" + TextoPie);


        }

        public virtual void Imprimir()
        {
          Cabecera();
          Contenido();
          Pie();


        }
    }
}
