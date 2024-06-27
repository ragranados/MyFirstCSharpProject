using Classes.ClassesTry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Teacher : Staff
    {

        public string Subject { get; set; }

        public Teacher(string name, int age, int salary, string subject) : base(name, age, salary)
        {
            Subject = subject;
        }
    }
}
