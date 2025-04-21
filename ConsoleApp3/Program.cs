
using ConsoleApp3;

Factura f = FacturaFactory.getInstance("reducida", 1, "ordenador", 100);

Console.WriteLine(f.calcularIva());

Configurador c = Configurador.getConfigurador();
Console.WriteLine(c.ruta);