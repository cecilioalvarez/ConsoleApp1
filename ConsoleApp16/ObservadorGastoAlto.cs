using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class ObservadorGastoAlto : IObservadorGastos
    {
        public void notificar(List<double> gastos)
        {
            if (gastos[gastos.Count - 1]>500)
            {
                 Console.WriteLine(" email a mi jefe hemos añadido un gasto de " + gastos[gastos.Count - 1]);
            }
           
        }
    }
}
