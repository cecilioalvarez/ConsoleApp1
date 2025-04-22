using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class EnchufeAdaptadorPortatil: Encendible
    {
        public PortatilAmericano PortatilAmericano { get; set; }

        public EnchufeAdaptadorPortatil(PortatilAmericano portatilAmericano)
        {
            PortatilAmericano = portatilAmericano;
        }

        public void On()
        {
          PortatilAmericano.Start();
        }

        public void Off()
        {
            PortatilAmericano.Stop();
        }
    }
}
