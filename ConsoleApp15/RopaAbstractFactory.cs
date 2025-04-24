using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public abstract class RopaAbstractFactory
    {
        public RopaAbstractFactory() { 
        
        }

        public static RopaAbstractFactory GetInstance(string marca)
        {

            if (marca.Equals("nike"))
            {
                return new RopaNikeFactory();
            }else
            {
                return new RopaAdidasFactory();
            }
        }

        public abstract Zapatilla GetZapatilla();
        public abstract Sudadera GetSudadera();
    }
}
