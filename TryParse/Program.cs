using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa un numero: ");
            string numInput = Console.ReadLine();
            int num = 0;

            bool success = int.TryParse(numInput, out num);

            if (success)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("No se pudo convertir");
            }


            Console.ReadLine();
        }
    }
}
