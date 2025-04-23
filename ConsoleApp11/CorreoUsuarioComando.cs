using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class CorreoUsuarioComando : ComandoUsuario
    {
        public override void Ejecutar(Usuario usuario)
        {
            Console.WriteLine("mandamos correo usuario" + usuario.Nombre);

        }
    }
}
