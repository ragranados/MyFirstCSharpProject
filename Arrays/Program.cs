using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Creacion

            int[] numbers = new int[3];

            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;

            //Console.WriteLine(numbers[2]);

            foreach (int num in numbers)
            {
                //Console.WriteLine(num);
            }

            // Sorting

            Console.WriteLine("Sorting");

            int[] numeros = new int[]
            {
                1,2,3,1000,2,45,7,10,9,
            };

            Array.Sort(numeros);

            foreach (int num in numeros)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            //reverse

            Console.WriteLine("Reverse");

            Array.Reverse(numeros);

            foreach (int num in numeros)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            //clearing

            Console.WriteLine("Clearing");

            Array.Clear(numeros, 0, numeros.Length);

            foreach (int num in numeros)
            {
                Console.Write(num + " ");
            }

            /*si se iguala una variable a defualt, se convierte en el valor
            por defecto de ese tipo de variable*/

            Console.WriteLine();

            //indexof

            Console.WriteLine("IndexOf");

            int[] numeros_indexof = new int[]
            {
                1,2,3,1000,2,45,7,10,9, 1000
            };

            Console.WriteLine(Array.IndexOf(numeros_indexof,733));

            Console.ReadLine();
        }
    }
}
