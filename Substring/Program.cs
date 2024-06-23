using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensaje = "C# es asombroso";

            //mensaje = mensaje.Substring(1); //desde ese hasta el final
            Console.WriteLine(mensaje);

            mensaje = mensaje.Substring(1, 3); //desde ese hasta el final
            Console.WriteLine(mensaje);

            Console.ReadLine();
        }
    }
}
