using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDetails();
            Convert.ToInt32("Hola");

            Console.ReadLine();
        }

        static void PrintDetails()
        {
            Console.WriteLine("Prueba");
        }
    }
}
