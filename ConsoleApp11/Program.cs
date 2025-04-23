

using ConsoleApp11;

/*
GestorUsuario gestor= new GestorUsuario();
Usuario u = new Usuario("pedro", "123", 20, "pedro@hotmail.com");
gestor.AltaUsuario(u);

Console.WriteLine("*************************");

AltaUsuarioComando comandoAlta= new AltaUsuarioComando();
BajaUsuarioComando comandoBaja = new BajaUsuarioComando();

comandoAlta.Ejecutar(u);
comandoBaja.Ejecutar(u);

*/

//ComandoUsuario comando = CommandoFactory.CrearComando("AltaUsuario");
/*
ComposicionComandoUsuario comandoCompuesto= new ComposicionComandoUsuario();
comandoCompuesto.AddComando( new AltaUsuarioComando() );
comandoCompuesto.AddComando(new CorreoUsuarioComando());
*/

Usuario u = new Usuario("pedro", "123", 20, "pedro@hotmail.com");
ComandoUsuario comando = ComandoFactory.CrearComando("AltaUsuario,CorreoUsuario");
comando.Ejecutar(u);

