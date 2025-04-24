using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class ObservadorGastosCorreoFacturacion : IObservadorGastos
    {
        public void notificar(List<double> gastos)
        {
            Console.WriteLine("enviando el gasto a facturación" +gastos[gastos.Count - 1]);
        }
    }
}
