using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class ServicioGastos :IObservableGastos
    {
        List<double> gastos= new List<double>();
        List<IObservadorGastos> observadores= new List<IObservadorGastos> { };

        public void AddGasto(double gasto)
        {



            gastos.Add(gasto);

            foreach (IObservadorGastos observador in observadores) {

                observador.notificar(gastos);

            }

        }

        public void AddObservador(IObservadorGastos observador)
        {
           observadores.Add(observador);
        }

        public double GastoTotal() {
            
            return gastos.Sum();
        
        }

        public void RemoveObservador(IObservadorGastos observador)
        {
            observadores.Remove(observador);
        }
    }
}
