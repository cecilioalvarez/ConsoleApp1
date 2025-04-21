
using ConsoleApp2;

var lectorFichero = new LectorFichero("C:\\Users\\cecilioalvarezcaules\\source\\repos\\ConsoleApp1\\ConsoleApp2\\prueba3.txt3");
var procesadorLineas = new ProcesadorLineasFactura(lectorFichero);

List<Factura> facturas=procesadorLineas.Procesar();

foreach(var f in facturas)
{

    Console.WriteLine("|"+f.Numero+"|"+ f.Concepto+"|" +f.Importe);
}



