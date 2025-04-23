using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class CajaRegalo : Regalo
    {
        public CajaRegalo(string nombre) : base(nombre)
        {
        }

        public override bool esCaja()
        {
            return true;
        }

        public void AddRegalo(Regalo regalo)
        {

            Regalos.Add(regalo);

        }
    }
}
