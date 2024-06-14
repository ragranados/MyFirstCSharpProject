using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNullOrEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombre: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Tu nombre es: {name}");

            if (name != "") Console.WriteLine("0");

            if (!name.Equals("")) Console.WriteLine("1");

            if(!string.IsNullOrEmpty(name)) Console.WriteLine("2");

            Console.ReadLine();
        }
    }
}
