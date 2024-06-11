using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //en este caso la arroba es para decir "lo que se ve ahi, es lo que se usa"
            //el $ es para lo mismo que en JS, parecido
            string prueba = @"prueba ""raul""";

            Console.WriteLine(@"C:\Users\raul\n");
            Console.WriteLine($"{prueba} esto es asi: {145}");

            Console.ReadLine();
        }
    }
}
