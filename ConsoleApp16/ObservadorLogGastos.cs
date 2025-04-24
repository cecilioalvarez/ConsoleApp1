using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class ObservadorLogGastos : IObservadorGastos
    {
        public void notificar(List<double> gastos)
        {
            Console.WriteLine(" log de nuevo gasto de " + gastos[gastos.Count - 1] + "" + DateTime.Now);
        }
    }
}
