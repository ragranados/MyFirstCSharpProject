using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int vat = 20;
            const double percentVAT = vat / 100D;

            int balanace = 1000;

            Console.WriteLine(balanace * percentVAT);

            //vat = 10;

            Console.ReadLine();
        }
    }
}
