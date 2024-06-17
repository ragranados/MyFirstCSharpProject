using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Escribe un mensaje: ");
            string mensaje = Console.ReadLine();

            for (int i = 0; i < mensaje.Length; i++)
            {
                Console.Write(mensaje[i]);
                Thread.Sleep(100);
            }

            //el reverso se empieza en menos un porque lo de los arreglos
            for (int i = mensaje.Length - 1; i >= 0; i--)
            {
                Console.Write(mensaje[i]);
                Thread.Sleep(100);
            }

            Console.ReadLine();
        }
    }
}
