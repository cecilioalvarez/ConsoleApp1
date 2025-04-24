using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class DiccionarioCajaFlyWeight

    {
        private static DiccionarioCajaFlyWeight instance;

        public   Dictionary<string, CajaFlyWeight> CajaFlyWeight { get; }= new Dictionary<string, CajaFlyWeight>();

        private  DiccionarioCajaFlyWeight()
        {

            CajaFlyWeight.Add("azul", new CajaFlyWeight("azul", 1));
            CajaFlyWeight.Add("verde", new CajaFlyWeight("rojo", 2));
            CajaFlyWeight.Add("rojo", new CajaFlyWeight("rojo", 3));
        }

        public static DiccionarioCajaFlyWeight GetInstance()
        {

            if (instance == null)
            {
                instance = new DiccionarioCajaFlyWeight();
            }

            return instance;
        }
    }
}
