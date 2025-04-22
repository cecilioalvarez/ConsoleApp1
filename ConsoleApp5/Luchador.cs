using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public interface Luchador
    {
        void Luchar();
        int Fuerza { get; set; }
        int Destreza { get; set; }
    }
}
