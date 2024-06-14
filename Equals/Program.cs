using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Equals chequea los valores en memoria (literales)
            // == no solo compara los valores, si no tambien la ubicacion en memoria

            string mensaje = "Hello";
            string compare = "Hello";

            if (mensaje.Equals(compare))
            {
                Console.WriteLine("si");
            }
            else
            {
                Console.WriteLine("no");
            }

            Console.ReadLine();
        }
    }
}
