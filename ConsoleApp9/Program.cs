// See https://aka.ms/new-console-template for more information


using ConsoleApp9;

Documento d1 = new Documento("los requirimientos del solicitante",
    "por la baja laboral", " la solucitud del solicitante");
d1.Imprimir();

Console.WriteLine("***********************");

Documento d2 = new DocumentoRegistro("los requirimientos del solicitante",
    "por la baja laboral", " la solucitud del solicitante");
d2.Imprimir();
