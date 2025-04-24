


using ConsoleApp14;
Console.WriteLine("empezo");
Documento documento = new Documento("a", "doc1", "blabla");
Console.WriteLine("termino");
Documento d2= (Documento)documento.Clone();
Console.WriteLine(d2.Nombre);
Console.WriteLine("termino2");