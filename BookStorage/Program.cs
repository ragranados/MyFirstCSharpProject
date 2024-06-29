using BookStorage.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStorage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("Raul", "Correo", Gender.Male);

            Console.WriteLine(author);

            Console.ReadLine();
        }
    }
}
