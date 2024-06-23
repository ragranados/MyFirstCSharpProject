using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //replace aqui tiene efecto en todos los que encuentra
            string mensaje = "Prueba de replace";

            Console.WriteLine(mensaje.Replace("a", "z"));

            Console.ReadLine();
        }
    }
}
