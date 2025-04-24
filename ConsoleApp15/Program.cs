// See https://aka.ms/new-console-template for more information
using ConsoleApp15;

/*
Zapatilla zapatilla = FactoriaZapatillas.GetInstance("nike");
zapatilla.Andar();
zapatilla.Correr();

Zapatilla zapatilla2 = FactoriaZapatillas.GetInstance("adidas");
zapatilla2.Andar();
zapatilla2.Correr();

Sudadera sudadera = FactoriaSudaderas.GetInstance("nike");
sudadera.Poner();
sudadera.Cerrar();


Sudadera sudadera2 = FactoriaSudaderas.GetInstance("adidas");
sudadera2.Poner();
sudadera2.Cerrar();
*/
RopaAbstractFactory factoria = RopaAbstractFactory.GetInstance("nike");
Sudadera s = factoria.GetSudadera();
s.Poner();
Zapatilla z= factoria.GetZapatilla();
z.Andar();
