using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class GestorUsuario
    {

        public void AltaUsuario(Usuario usuario)
        {
            Console.WriteLine("damos de alta al usuario" + usuario.Nombre);

        }
        public void BajaUsuario(Usuario usuario)
        {
            Console.WriteLine("damos de baja al usuario" + usuario.Nombre);

        }

        public void EnviarCorreoUsuario(Usuario usuario)
        {
            Console.WriteLine("mandamos correo usuario" + usuario.Nombre);

        }

        public void GenerarClaveUsuario(Usuario usuario)
        {
            Console.WriteLine("generamos clave usuario" + usuario.Nombre);

        }

        public void ArchivamosUsuario(Usuario usuario)
        {
            Console.WriteLine("generamos clave usuario" + usuario.Nombre);

        }
    }
}
