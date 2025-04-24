using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Robot
    {
        public BrazoRobot Brazo { get; set; }
        public string Marca { get; set; }


        public void Girar()
        {
            Brazo.Girar();

        }

        public Robot(BrazoRobot brazo, string marca)
        {
           Brazo = brazo;
           Marca = marca;
        }
    }
}
