using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Console.Write("Numero: ");
                int num = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato incorrecto");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
                //throw;
            }

            Console.ReadLine();
        }
    }
}
