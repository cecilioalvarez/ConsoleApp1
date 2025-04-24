using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public interface IObservableGastos
    {
        void AddObservador(IObservadorGastos observador);
        void RemoveObservador(IObservadorGastos observador);
    }
}
