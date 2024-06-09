using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            Console.WriteLine(age);
            age++;
            Console.WriteLine(age);

            string name = "Ra";

            name += " está aprendiendo C#";
            Console.WriteLine(name);

            int primeroNumero = 10;
            int segundoNumero = 3;

            Console.WriteLine(primeroNumero % segundoNumero);

            Console.ReadLine();
        }
    }
}
