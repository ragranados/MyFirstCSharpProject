using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Hello ");
            stringBuilder.Append("World");
            stringBuilder.Insert(stringBuilder.Length,"Hi", 5);
            stringBuilder.Replace("Hi", "Equis de");
            stringBuilder.Remove(0,8);

            Console.WriteLine(stringBuilder.ToString());

            string mensaje = "";
            mensaje += "Hola" + Environment.NewLine;
            mensaje += "Adios";

            Console.WriteLine(mensaje);

            Console.ReadLine();
        }
    }
}
