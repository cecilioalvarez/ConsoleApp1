using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Matematicas

    {
        public static int factorial(int numero)
        {

            int resultado = 1;

            for (int i = 1; i <= numero; i++)
            {

                resultado *= i;
            }
            return resultado;
        }

        public static int factorialRecursivo(int numero)
        {

          
            if (numero == 1) { 
                return 1; 
            } else
            {

                return  numero *factorialRecursivo(numero - 1);
            }
        }
    }
}
