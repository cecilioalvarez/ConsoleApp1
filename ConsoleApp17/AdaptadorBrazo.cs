using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class AdaptadorBrazo : BrazoRobot
    {
        public void Girar()
        {
           BrazoViejo brazo = new BrazoViejo();
            brazo.Rotar();
        }
    }
}
