


using ConsoleApp7;


Regalo regalo = new Regalo("raton");
Regalo regalo2 = new Regalo("perfume");
Regalo regalo3 = new Regalo("balon");


CajaRegalos caja= new CajaRegalos();
caja.AddRegalo(regalo);
caja.AddRegalo(regalo2);
caja.AddRegalo(regalo3);

 foreach( Regalo regalo1 in caja.Regalos )
{
    Console.WriteLine( regalo1.Nombre );

}
