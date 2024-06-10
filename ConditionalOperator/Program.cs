using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age = -10;

            string resultado = age <= 0 ? "Invalido" : "Valido";
            Console.WriteLine(resultado);

            Console.ReadLine();

        }
    }
}
