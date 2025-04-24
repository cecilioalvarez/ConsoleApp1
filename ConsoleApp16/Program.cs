
using ConsoleApp16;

ServicioGastos gastos = new ServicioGastos();
gastos.AddObservador(new ObservadorGastosCorreoFacturacion());
gastos.AddObservador(new ObservadorLogGastos());
gastos.AddObservador(new ObservadorGastoAlto());
gastos.AddGasto(600);
Console.WriteLine(gastos.GastoTotal());
