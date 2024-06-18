using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else if (i % 2 == 1)
                {
                    odd.Add(i);
                }
            }

            foreach (var item in odd)
            {
                Console.WriteLine(item);
            }

            foreach (var item in even)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
