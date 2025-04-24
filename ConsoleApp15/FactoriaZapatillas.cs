using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class FactoriaZapatillas
    {
        public static Zapatilla GetInstance(string tipo)
        {

            if (tipo.Equals("nike"))
            {

                return new ZapatillaNike();
            }else
            {
                return new ZapatillaAdidas();
            }
        }
    }
}
