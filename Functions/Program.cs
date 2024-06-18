using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {

        //funciones "void"
        static void WelcomeMessage(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }

        //funciones que retornan algo
        static string WelcomeMessage2(string name)
        {
            return $"Welcome {name}";
        }

        //funciones con parametos
        static int Add(int a, int b)
        {
            return a + b;
        }

        //funciones con parametros opcionales
        static int Sumar(int a, int b = default)
        {
            return a + b;
        }

        static int Sumar_2(int a, [Optional] int b)
        {
            return a + b;
        }

        //funciones con "named parameters"

        static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"{name}, {age}, {address}");
        }

        //funciones con parametros de salida
        static bool Test(out int num)
        {
            num = 5;
            return true;
        }

        static void Main(string[] args)
        {

            //Cambia el titulo de la consola
            Console.Title = "Prueba de cambio";

            //WelcomeMessage("Raul");

            //Console.WriteLine(WelcomeMessage2("Alejandra"));

            //PrintDetails(age: 10,
            //             name: "Raul",
            //             address: "direccion");

            int num = 0;

            bool prueba = Test(out num);
            Console.WriteLine(num);
            Console.WriteLine(prueba);

            Console.ReadLine();
        }

    }
}
