using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Person
    {
        //private string name;

        //auto property
        private int Age { set; get; }

        //normal property (with private string name;)
        public string Name { set; get; }

        //public int Age
        //{
        //    get
        //    {
        //        return age;
        //    }
        //    set
        //    {
        //        age = value;
        //    }
        //}

        public Person() { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string ReturnDetails(string extra)
        {
            return $"Nombre: {Name}, edad: {Age}, {extra}";
        }

        public override string ToString()
        {
            return $"Nombre: {Name}, edad: {Age}";
        }

        public override bool Equals(object obj)
        {

            if (obj is Person person)
            {
                //Person person = obj as Person;
                //Console.WriteLine($"{Name}, {person.Name}, {Age}, {person.Age}");
                return Name.Equals(person.Name) && Age == person.Age;
            }

            return false;
        }

        //public override int GetHashCode()
        //{
        //    // Using a tuple to generate a combined hash code of Name and Age
        //    return (Name, Age).GetHashCode();
        //}

        //public int GetAge() => this.age;
    }
}
