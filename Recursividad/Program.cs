using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("igresar el numero para calular el factorial");
            int numero= Convert.ToInt32(Console.ReadLine());

            int numerof = factorial(numero);

            Console.WriteLine("El factorial de " + numero + "es igual a " + numerof);
        }
          public static int factorial  (int numero)
        {
        if (numero == 1) 
            { 
                return 1;
            }
        else
            {
                return numero * factorial(numero-1);
            }
        }
    }
}
