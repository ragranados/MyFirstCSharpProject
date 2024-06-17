using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese contraseña: ");
            string contra = Console.ReadLine();

            Console.Write("Ingrese contraseña: ");
            string contraC = Console.ReadLine();

            /*
                Si se quiere comprar, sin tener en cuentra las mayusculas y 
                minusculas se usa ToLower y ToUpper de string
            */

            if (contra.Equals(string.Empty) || contraC.Equals(string.Empty))
            {
                Console.WriteLine("Vacio");
            }
            else
            {
                if (contra.Equals(contraC))
                {
                    Console.WriteLine("Si son iguales");
                }
                else
                {
                    Console.WriteLine("No son iguales");
                }
            }

            Console.ReadLine();
        }
    }
}
