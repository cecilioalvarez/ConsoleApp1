
using ConsoleApp10;

GestorImpresion gestorImpresion = new GestorImpresion();
GestorCopiadora gestorCopiadora= new GestorCopiadora();

GestorFachada gestor = new GestorFachada(gestorCopiadora, gestorImpresion);

gestor.CopiarTexto("hola");
gestor.ImprimirTexto("hola2");
