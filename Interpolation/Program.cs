using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "Raul";
            int edad = 26;

            Console.WriteLine($"Tu nombre es {name} y tu edad es {edad}");

            string test = string.Concat("Tu nombre es: ", name," y tu edad es: " ,edad ); // concatenacion

            Console.ReadLine();

        }
    }
}
