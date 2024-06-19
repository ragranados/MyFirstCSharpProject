using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] 
            {
                1,2,3,4,5
            };


            if (!SumOfNumbers(numbers, out int resultado))
            {
                Console.WriteLine("El arreglo no puede estar vacio");
            }
            else 
            {
                Console.WriteLine($"Resultado: {resultado}");
            }


            Console.ReadLine();
        }

        static bool SumOfNumbers(int[] array, out int sum) 
        {
            int sumLocal = 0;

            if(array.Length == 0)
            {
                sum = sumLocal;
                return false;
            }

            foreach (var i in array)
            {
                sumLocal += i;
            }

            sum = sumLocal;

            return true;

        }
    }
}
