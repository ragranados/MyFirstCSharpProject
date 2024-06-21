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
            //person.age = 27;
            person.name = "Raul 2";

            Console.WriteLine(person.ReturnDetails("Contenido extra"));
            ReturnDetails(person);

            Console.ReadLine();
        }

        static void ReturnDetails(Person person)
        {
            Console.WriteLine($"{person.name}");
        }
    }
}
