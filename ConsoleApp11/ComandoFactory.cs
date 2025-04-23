using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class ComandoFactory
    {

        public static ComandoUsuario CrearComando(string nombre)
        {
            if (!nombre.Contains(",")) { 


            string nombreClase = "ConsoleApp11."+nombre+"Comando";
            Console.WriteLine(nombreClase);
            Type tipo = Type.GetType(nombreClase);
            return (ComandoUsuario) Activator.CreateInstance(tipo);

            } else
            {

                ComposicionComandoUsuario comandoCompuesto = new ComposicionComandoUsuario();

                string[] comandos= nombre.Split(",");

                foreach (string comando in comandos)
                {

                    string nombreClase = "ConsoleApp11." + comando + "Comando";              
                    Type tipo = Type.GetType(nombreClase);
                    ComandoUsuario comandoUsuario= (ComandoUsuario)Activator.CreateInstance(tipo);
                    comandoCompuesto.AddComando(comandoUsuario);
                  
                }
                return comandoCompuesto;
            }

        }
    }
}


    
