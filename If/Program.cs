using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, mi nombre es Raul");

            Console.Write("Escribe tu nombre: ");
            string prueba = Console.ReadLine();

            Console.Write("Escribe tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            //para contacenar

            Console.WriteLine("Tu nombre es " + prueba + " y tu edad es " + edad);

            if (edad >= 18 && edad <= 25)
            {
                Console.WriteLine("18 a 25");
            }
            else if (edad > 25)
            {
                Console.WriteLine("26 o mas");
            }

            if (edad < 0 || edad > 150)
            {
                Console.WriteLine("Edad no permitida");
            }

            Console.ReadLine();
        }
    }
}
