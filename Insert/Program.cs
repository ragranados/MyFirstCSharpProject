using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensaje = "prueba de string.Insert()";

            Console.WriteLine(mensaje.Insert(0, "Esta es una "));

            string error = "Algo falló: ";
            Console.WriteLine(error.Insert(error.Length, "Esto"));

            Console.ReadLine();
        }
    }
}
