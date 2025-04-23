using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class RegaloSencillo : Regalo
    {
        public RegaloSencillo(string nombre) : base(nombre)
        {
        }

        //regalo sencillo no tiene mas no es una caja
        public override bool esCaja()
        {
          return false;
        }
    }
}
