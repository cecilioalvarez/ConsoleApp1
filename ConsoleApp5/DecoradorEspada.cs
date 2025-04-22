using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class DecoradorEspada : Luchador
    {
        private Luchador Lucha;

        public DecoradorEspada(Luchador lucha)
        {

            Lucha = lucha;
        }

        public int Fuerza { get => Lucha.Fuerza; set => Lucha.Fuerza=value; }
        public int Destreza { get => Lucha.Destreza; set => Lucha.Destreza = value; }

        public void Luchar()
        {

            Lucha.Destreza = Lucha.Destreza + 4;
            Console.WriteLine("monto la espada");
            Lucha.Luchar();
        }
    }
}
