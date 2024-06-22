using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("Raul", 26);
            Person person2 = new Person("Raul", 26);
            //person.age = 27;
            //person.name = "Raul 2";

            Console.WriteLine(person.ReturnDetails("Contenido extra"));
            ReturnDetails(person);

            //person.Name = "NuevoNombre";

            Console.WriteLine(person.ReturnDetails("Contenido extra"));

            Console.WriteLine(person2);

            if (person.Equals(person2))
            {
                Console.WriteLine("Same!");
            }
            else
            {
                Console.WriteLine("Not Same!");
            }

            Console.ReadLine();
        }

        static void ReturnDetails(Person person)
        {
            //Console.WriteLine($"{person.name}");
        }
    }
}
