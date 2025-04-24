using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class FactoriaSudaderas
    {
        public static Sudadera GetInstance(string tipo)
        {

            if (tipo.Equals("nike"))
            {
                return new SudaderaNike();
            }else
            {

                return new SudaderaAdidas();
            }
        }
    }
}
