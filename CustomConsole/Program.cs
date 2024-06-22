using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("Hola 2");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Prueba color");

            Console.ResetColor();
            Console.Clear();
            Console.ReadLine();

            Console.CursorSize = 100;

            Console.ReadLine();
        }
    }
}
