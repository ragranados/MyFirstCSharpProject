using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensaje = " Prueba Trim ";
            Console.WriteLine(mensaje.TrimEnd());
            Console.WriteLine(mensaje.TrimStart());
            Console.WriteLine(mensaje.Trim());

            Console.ReadLine();
        }
    }
}
