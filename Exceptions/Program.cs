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
            catch (FormatException e)
            {
                Console.WriteLine("Formato incorrecto");
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Overflow: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
                //throw;
            }

            Console.ReadLine();
        }
    }
}
