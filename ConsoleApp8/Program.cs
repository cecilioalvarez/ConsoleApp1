// See https://aka.ms/new-console-template for more information
using ConsoleApp8;

Regalo r1 = new RegaloSencillo("tablet");
Regalo r2 = new RegaloSencillo("auricular");

CajaRegalo caja = new CajaRegalo("regalo tia maria");

caja.AddRegalo(r1);
caja.AddRegalo(r2);

CajaRegalo caja2 = new CajaRegalo("regalo tio antonio");

Regalo r3 = new RegaloSencillo("camisa");
Regalo r4= new RegaloSencillo("corbata");
caja2.AddRegalo(r3);
caja2.AddRegalo(r4);


// que aqui ya estamos empezando a manejar temas recursivos
//una caja contiene otras cajas
CajaRegalo caja3 = new CajaRegalo("tio antonio y tia maria");
caja3.AddRegalo(caja);
caja3.AddRegalo(caja2);


MostrarRegalos(caja3);

//Console.WriteLine(r1.Nombre);
//Console.WriteLine(r2.Nombre);



/*
foreach (Regalo r in caja3.Regalos)
{

    Console.WriteLine(r.Nombre);

    foreach (Regalo rhijo in r.Regalos)
    {
        Console.WriteLine(rhijo.Nombre);

    }
}*/

  void  MostrarRegalos (Regalo regalo)
{

    Console.WriteLine(regalo.Nombre);

    if (regalo.esCaja())
    {
        foreach(Regalo r in regalo.Regalos) {

            MostrarRegalos(r);
        }
    }

}