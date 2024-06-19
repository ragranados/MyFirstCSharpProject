using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Altura: ");
            int altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ancho: ");
            int ancho = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CalcArea(altura, ancho));

            Console.ReadLine();
        }

        static int CalcArea(int altura, int ancho)
        {
            return (altura * ancho) / 2;
        }
    }
}
