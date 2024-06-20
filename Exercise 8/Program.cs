using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe un numero: ");


            if (TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine($"Si se convirtió, {result}");
            }
            else
            {
                Console.WriteLine($"No se convirtió {result}");
            }

            Console.ReadLine();
        }

        static bool TryParse(string s, out int result)
        {
            bool converted = false;
            result = -1;

            try
            {
                result = Convert.ToInt32(s);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
