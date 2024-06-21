using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Program
    {

        struct Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
        static void Main(string[] args)
        {

            Person person = ReturnPerson();

            Console.WriteLine(person.name);

            Console.ReadLine();

        }

        static Person ReturnPerson()
        {

            Person person = new Person("Raul", 26);
            //person.name = "Raul";
            //person.age = 26;

            return person;
        }
    }
}
