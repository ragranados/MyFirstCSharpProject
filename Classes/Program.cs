using Classes.ClassesTry;
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

            /*Person person = new Person("Raul", 26);
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
            }*/

            // ------------- Box ----------------

            /*Box box = new Box(0,2,5);
            Console.WriteLine(box.ToString());

            */

            // ----- Operator Overloading ------

            /*Person person = new Person("Raul", 26);
            Person test = new Person("Raul", 27);

            Console.WriteLine(person.ReturnDetails("Prueba"));

            if (person == test)
            {
                Console.WriteLine("Si son iguales");
            }
            else
            {
                Console.WriteLine("Diferentes");
            }

            Console.WriteLine($"Edad antes: {person.Age}");

            person++;

            Console.WriteLine($"Edad despues: {person.Age}");

            Console.WriteLine(person > test);*/

            Student student = new Student("Raul", 26, 10);
            Staff staff = new Staff("Raul", 28, 10000);

            Console.WriteLine(student.ToString());
            Console.WriteLine(staff.ToString());

            Console.WriteLine(staff > student);

            Console.ReadLine();
        }

        static void ReturnDetails(Person person)
        {
            //Console.WriteLine($"{person.name}");
        }
    }
}
