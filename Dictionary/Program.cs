using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> names = new Dictionary<int, string>();

            names.Add(1, "Raul");
            names.Add(2, "Alejandra");

            Console.WriteLine(names[2]);

            for (int i = 0; i < names.Count; i++) 
            {
                KeyValuePair<int, string> par = names.ElementAt(i);

                Console.WriteLine($"{par.Key}, {par.Value}");
            };

            foreach (var par in names) 
            {
                Console.WriteLine($"{par.Key}, {par.Value}");
            }

            //si no se encuentra

            if (names.TryGetValue(2, out string nombre)) //busca si existe, seguno argumento devuelve el valor (si lo encuentra)
            {
                Console.WriteLine(nombre);
            }
            else
            {
                Console.WriteLine("No existe");
            }

            Console.ReadLine();
        }
    }
}
