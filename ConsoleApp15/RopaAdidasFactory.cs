using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class RopaAdidasFactory : RopaAbstractFactory
    {
        public override Sudadera GetSudadera()
        {
             return new SudaderaAdidas();
        }

        public override Zapatilla GetZapatilla()
        {
            return  new ZapatillaAdidas();
        }
    }
}
