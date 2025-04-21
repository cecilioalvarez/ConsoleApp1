using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Coche 
    {
        private Motor _motor;


        public int Potencia
        {

            get
            {

                return _motor.Potencia;
            }
            set
            {

                _motor.Potencia = value;
            }
        }


        public int Cilindros
        {

            get
            {

                return _motor.Cilindros;
            }
            set
            {

                _motor.Cilindros = value;
            }
        }


        public Coche(Motor motor, string color)
        {
            _motor = motor;
            Color = color;
        }
        public Coche(int cilindros, int potencia, string color) 
        {
            _motor = new Motor(cilindros,potencia,"negro");
            Color = color;
        }
        //color del coche
        public string Color { get; set; }

        public  void Arrancar()
        {
            _motor.Arrancar();
            Console.WriteLine("el coche arranca");
        }

    }
}
