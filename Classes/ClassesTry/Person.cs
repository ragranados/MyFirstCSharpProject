using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    interface IPerson
    {
        void DoWork();

        //en una interfaz solo se pueden "restringir propiedades, no las variables privadas."
        string Name { get; set; }
    }
    //Abstractas es como una plantilla.
    abstract class Person : IPerson
    {
        //private string name;

        //auto property
        public int Age { set; get; }

        //normal property (with private string name;)
        public string Name { set; get; }

        /*public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }*/

        //public Person() { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        /// <summary>
        /// The method <c>ReturnDetails</c> return a string with the details of the person.
        /// </summary>

        public string ReturnDetails(string extra)
        {
            return $"Nombre: {Name}, Edad: {Age}, {extra}";
        }

        public override string ToString()
        {
            return $"Nombre: {Name}\tEdad: {Age}";
        }

        public override bool Equals(object obj)
        {

            if (obj is Person person)
            {
                /*Person person = obj as Person;
                Console.WriteLine($"{Name}, {person.Name}, {Age}, {person.Age}");*/

                return Name.Equals(person.Name) && Age == person.Age;
            }

            return false;
        }

        //all "sobrecargar" el operador de ==, tambien se debe hacer !=
        public static bool operator ==(Person a, Person b)
        {
            return a.Name.Equals(b.Name) && a.Age == b.Age;
        }

        public static bool operator !=(Person a, Person b)
        {
            return (!a.Name.Equals(b.Name)) || a.Age != b.Age; ;
        }

        //sobrecarga de ++
        //En caso de la sobrecarga, siempre se pasan por referencia los parametros.
        public static Person operator ++(Person a)
        {
            a.Age++;
            return a;
        }

        public static bool operator >(Person a, Person b)
        {
            return a.Age > b.Age;
        }

        public static bool operator <(Person a, Person b)
        {
            return a.Age < b.Age;
        }

        public abstract void something();

        public void DoWork() { }

        //Aqui deberian ir >= y <=

        /* public override int GetHashCode()
         {
             // Using a tuple to generate a combined hash code of Name and Age
             return (Name, Age).GetHashCode();
         }

         public int GetAge() => this.age;*/
    }
}
