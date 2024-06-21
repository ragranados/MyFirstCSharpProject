using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Person
    {
        public string name { get; set; }
        public int age { get; }

        public Person() { }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string ReturnDetails(string extra)
        {
            return $"Nombre: {this.name}, edad: {this.age}, {extra}";
        }

        public int GetAge() => this.age;
    }
}
