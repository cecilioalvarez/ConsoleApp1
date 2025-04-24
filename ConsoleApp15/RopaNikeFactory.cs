using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class RopaNikeFactory : RopaAbstractFactory
    {
        public override Sudadera GetSudadera()
        {
            return new SudaderaNike();
        }

        public override Zapatilla GetZapatilla()
        {
            return new ZapatillaNike();
        }
    }
}
