using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>()
            {
                "Item 1", "Item 2", "Item 3"
            };

            Console.Write("Ingrese un nuevo item: ");
            items.Add(Console.ReadLine());

            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            Console.Clear();

            Console.Write("Item a actualizar: ");

            int indexActualizar = items.IndexOf(Console.ReadLine());

            if (indexActualizar >= 0)
            {
                Console.Write("Nuevo Item: ");
                items[indexActualizar] = Console.ReadLine(); ;
            }
            else
            {
                Console.WriteLine("No encontrado");
            }

            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            Console.Clear();

        }
    }
}
