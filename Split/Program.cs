using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comma = "Raul,26,1";

            string[] commas = comma.Split(',');

            foreach (var item in commas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(string.Join(" ",commas));

            Console.ReadLine();
        }
    }
}
