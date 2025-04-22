
using Biblioteca;
using biblioteca1;
using ConsoleApp4;

/*
Encendible encendible = new Lampara();
Encendible encendible2 = new Televisor();
Habitacion habitacion= new Habitacion();
habitacion.AddEncendible(encendible);
habitacion.AddEncendible(encendible2);
PortatilAmericano portatilAmericano = new PortatilAmericano();
EnchufeAdaptadorPortatil enchufe= new EnchufeAdaptadorPortatil(portatilAmericano);
habitacion.AddEncendible(enchufe);
habitacion.On();

*/
// es decir existe un intermediario que me crea el telefono
ITelefono t = FactoriaTelefono.CrearTelefono(1234);
t.EnviarMensaje("hola vamos al cine");

