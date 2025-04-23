using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class ComposicionComandoUsuario : ComandoUsuario
    {
        private List<ComandoUsuario> comandos = new List<ComandoUsuario>();

        public override void Ejecutar(Usuario usuario)
        {
            
            foreach(var comando in comandos)
            {

                comando.Ejecutar(usuario);
            }
        }

        public void AddComando(ComandoUsuario comando)
        {

            comandos.Add(comando);
        }
    }
}
