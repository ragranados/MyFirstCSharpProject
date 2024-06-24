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

            //los siguientes argumentos son para el rango de busqueda.
            Console.WriteLine(Array.IndexOf(numeros_indexof, 733));

            //copiar arreglos
            int[] numeros_copiar = new int[]
                {
                    0,1,2,3,4,5,6
                };

            int[] copia_numeros = new int[numeros_copiar.Length];

            //Array.Copy(numeros_copiar, copia_numeros, numeros_copiar.Length);

            Array.Copy(numeros_copiar, 2,copia_numeros,0, 5);

            //copia_numeros = numeros_copiar;

            //numeros_copiar[0] = 256;

            //si un arreglo se asigna a otro normalmente, se le asigna la memoria, por eso existe la funcion para copiar

            foreach (var item in numeros_copiar)
            {
                Console.Write(item);
            }

            Console.WriteLine(Environment.NewLine);

            foreach (var item in copia_numeros)
            {
                Console.Write(item);
            }

            Console.ReadLine();
        }
    }
}
