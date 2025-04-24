using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class CajaFlyWeight
    {

        public string Color { get; set; }
        public int Lado { get; set; }


        public CajaFlyWeight(string Color, int Lado) { 
        
            this.Color = Color;
            this.Lado = Lado;
        }
    }
}
