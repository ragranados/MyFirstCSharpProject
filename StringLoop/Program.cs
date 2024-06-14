using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StringLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string message = "C# is awesome";

            //Console.WriteLine(message[0]);

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(250);
            }

            Console.WriteLine(message.Contains("#"));

            Console.ReadLine();
        }
    }
}
