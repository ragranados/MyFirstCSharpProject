using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesTry
{
    class Student : Person
    {
        //public string Name { get; set; }

        //public int Age { get; set; }

        public int Grade { get; set; }

        public Student(string name, int age, int grade) : base(name, age)
        {
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Nota: {Grade}";
        }
    }
}
