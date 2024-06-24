using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un mensaje: ");
            string mensaje = Console.ReadLine();
            //StringBuilder mensaje = new StringBuilder(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            //Console.WriteLine(mensaje);

            foreach (var i in mensaje)
            {
                sb.Append(char.IsLower(i) ? char.ToUpper(i) : char.ToLower(i));
            }

            Console.Write(sb.ToString());

            Console.ReadLine();
        }
    }
}
