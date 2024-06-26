using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DebuggingTest();

            //Debug.WriteLine();

            Console.ReadLine();
        }

        static void DebuggingTest()
        {
            int age = 35;

            if (age > 18)
            {
                Console.WriteLine("+18");
            }
            else if (age > 30)
            {
                Console.WriteLine("+30");
            }
            else if (age > 50)
            {
                Console.WriteLine("+50");
            }
        }
    }
}
