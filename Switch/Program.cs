using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day) 
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2: 
                    Console.WriteLine("Martes");
                    break;
                default:
                    Console.WriteLine("Ninguno");
                    break;
            }

            Console.ReadLine();

        }
    }
}
