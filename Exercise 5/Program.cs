using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 10;
            int length = 10;

            int[] ints = new int[length];

            for (int i = 0; i < length; i++)
            {
                ints[i] = num * (i + 1);
            }

            foreach (var item in ints)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
