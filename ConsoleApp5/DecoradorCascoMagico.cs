using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class DecoradorCascoMagico : Luchador
    {
        private Luchador Lucha;

        public int Fuerza { get => Lucha.Fuerza; set => Lucha.Fuerza = value; }
        public int Destreza { get => Lucha.Destreza; set => Lucha.Destreza = value; }

        public void Luchar()
        {
            Lucha.Fuerza = Lucha.Fuerza + 5;
            Lucha.Destreza=Lucha.Destreza + 5;
            Console.WriteLine("monto el casco magico");
            Lucha.Luchar();
        }

        public DecoradorCascoMagico(Luchador lucha)
        {

            Lucha = lucha;
        }
       
    }
}
