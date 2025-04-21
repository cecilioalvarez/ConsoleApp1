using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Configurador
    {

        public string ruta { get; private set; }
        private static Configurador configurador;



        private Configurador()
        {
            ruta = "miruta";

        }

        public static Configurador getConfigurador()
        {

            if (configurador == null)
            {

                configurador = new Configurador();
                return configurador;
            }
            else
            {

                return configurador;
            }
        }
    }
}
