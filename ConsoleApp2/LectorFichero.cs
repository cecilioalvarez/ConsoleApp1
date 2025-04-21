using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class LectorFichero
    {

        private string _ruta = "";

        public LectorFichero(string ruta) {

            _ruta=ruta;
        }
        public List<string> LeerLineas()
        {      
            List<string> lineas = new List<string>();

            foreach (string linea in File.ReadLines(_ruta))
            {
            
                if (!linea.StartsWith("------"))
                        lineas.Add(linea);
            }

            return lineas;
        }
        public string Extension()
        {
            int indice= _ruta.LastIndexOf(".");
            string extension=_ruta.Substring(indice+1);
            return extension;

        }
    }
    
}
