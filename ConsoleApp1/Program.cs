// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

/*
Console.WriteLine("Hello, World!");
Motor m1 = new Motor(4, 100,"verde");
Console.WriteLine(m1.Cilindros);
Console.WriteLine(m1.Potencia);

Coche c = new Coche(4, 100, "azul");
Console.WriteLine(c.Color);
c.Arrancar();
*/

Persona p = new Persona("pepito");
Deportista d = new Deportista("miguel");

//encapsulacion completa del Motor

Coche c = new Coche(4,100, "verde");
c.Arrancar();

Console.WriteLine(c.Potencia);
/*
d.Andar();
p.Andar();

*/