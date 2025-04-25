// See https://aka.ms/new-console-template for more information
using ConsoleApp23;

Documento documento = new Documento();
documento.addParrafo("hola que tal estas");
documento.addParrafo("hola amigos");

Editor editor = new Editor();
editor.SalvarVersionDocumento(documento);



documento.addParrafo("blabla bla");

//editor.SalvarVersionDocumento(documento);
Console.WriteLine("***********************");
documento.imprimir();

Console.WriteLine("************************");
documento = editor.ObtenerVersion(0);
documento.imprimir();


