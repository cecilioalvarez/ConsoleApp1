using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class DecoradorArmaduraTitanio : Luchador
    {
        private Luchador Lucha;

        public DecoradorArmaduraTitanio(Luchador lucha)
        {

            Lucha = lucha;
        }

        public int Fuerza { get => Lucha.Fuerza; set => Lucha.Fuerza=value; }
        public int Destreza { get => Lucha.Destreza; set => Lucha.Destreza = value; }

        public void Luchar()
        {
            Lucha.Fuerza++;
            Lucha.Destreza--;
            Console.WriteLine("monto la armadura de titanio");
            Lucha.Luchar();
        }
    }
}
