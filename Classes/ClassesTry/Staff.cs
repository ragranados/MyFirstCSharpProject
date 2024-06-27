using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesTry
{
    class Staff : Person
    {

        public int Salary { get; set; }

        public Staff(string name, int age, int salary) : base(name, age)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\tSalary: {Salary}";
        }

        public override void something()
        {
            throw new NotImplementedException();
        }
    }
}
