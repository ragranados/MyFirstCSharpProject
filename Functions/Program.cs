using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Cambia el titulo de la consola
            Console.Title = "Prueba de cambio";

            //WelcomeMessage("Raul");

            //Console.WriteLine(WelcomeMessage2("Alejandra"));

            Console.WriteLine(Add(10, 6));

            Console.ReadLine();
        }

        //funciones "void"
        static void WelcomeMessage(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }

        //funciones que retornan algo
        static string WelcomeMessage2(string name)
        {
            return $"Welcome {name}";
        }

        //funciones con parametos
        static int Add(int a, int b)
        {
            return a + b;
        }

    }
}
