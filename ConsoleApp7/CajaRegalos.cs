using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class CajaRegalos
    {

        public List<Regalo> Regalos= new List<Regalo>();

        public void AddRegalo(Regalo regalo)
        {
            Regalos.Add(regalo);
        }
    }
}
