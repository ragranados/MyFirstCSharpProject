using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Program
    {

        public enum Grade
        {
            Invalid,
            A = 1,
            B,
            C,
            D,
            E,
        }
        class Person
        {
            public string Name { get; set; }

            public Grade Grade { get; set; }

            public Person(string name, Grade grade)
            {
                Name = name;
                Grade = grade;
            }

            public override string ToString()
            {
                return $"{Name}\n{Grade}";
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person("Raul", Grade.B);

            if (Enum.TryParse("100", out Grade result))
            {
                if (!Enum.IsDefined(typeof(Grade), result))
                {
                    result = default;
                }
            }

            Console.WriteLine(result);

            Console.WriteLine($"{person} = {Convert.ToInt32(person.Grade)}");

            Console.ReadLine();
        }
    }
}
