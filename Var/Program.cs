using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //El compilador interpreta que tipo de valor es
            var age = 23;
            Console.WriteLine(age);

            var nombre = "Hola";
            Console.WriteLine(nombre);

            var caracter = 'A';
            Console.WriteLine(caracter);

            var bigNumber = 90000000L;

            Console.ReadLine();
        }
    }
}
