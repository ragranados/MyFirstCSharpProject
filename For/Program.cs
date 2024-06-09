using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for(int i = 0; i < 10; i += 2)
            {
                Console.WriteLine("Hi " + i);
            }

            Console.ReadLine();
        }
    }
}
