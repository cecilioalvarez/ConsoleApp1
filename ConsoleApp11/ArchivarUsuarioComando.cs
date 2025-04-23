using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class ArchivarUsuarioComando : ComandoUsuario
    {
        public override void Ejecutar(Usuario usuario)
        {
            Console.WriteLine("generamos clave usuario" + usuario.Nombre);


        }
    }
}
