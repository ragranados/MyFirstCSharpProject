using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola, mi nombre es Raul");

            Console.Write("Escribe tu nombre: ");
            string prueba = Console.ReadLine();

            Console.Write("Escribe tu edad: ");
            string edad = Console.ReadLine();

            //para contacenar

            Console.WriteLine("Tu nombre es " + prueba + " y tu edad es " + edad);
            
            Console.ReadLine();

        }
    }
}
