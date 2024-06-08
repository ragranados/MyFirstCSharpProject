using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25; //caso 26 :D

            Console.WriteLine(age);

            long bigNumber = 90000000L; //para numerlos largos se agrega la L
            Console.WriteLine(bigNumber);

            double negative = -55.2D; //la D es para asegurarse que es double

            float precision = 5.0000001F; //F para float

            decimal money = 14.99M; // para decimal que se usa para dinero

            Console.ReadLine();
        }
    }
}
