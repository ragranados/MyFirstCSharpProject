using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textBigNumber = "-900000000";
            long bigNumber = Convert.ToInt64(textBigNumber); ;
            Console.WriteLine(bigNumber);

            double negative = -55.2D; // ToDouble
            Console.WriteLine(negative);

            string textPrecision = "5.00001";
            float precision = Convert.ToSingle(textPrecision); //un float por deficion es single
            Console.WriteLine(precision);

            decimal money = 14.99M;
            Console.WriteLine(money);

            Console.ReadLine();
        }
    }
}
