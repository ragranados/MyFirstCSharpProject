using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            Assign(ref num);
            Console.WriteLine(num);

            Console.ReadLine();
        }

        /*
        La diferencia es que out si hay que asignar por obligacion y ref no
        ref es como dar un "link" a la variable de afuera

        Tambien para ref, siempre hay que declarar la variable antes, por ser un
        "link" hacia la variable

        ref es un poco mas rapido
         */
        static void Assign(ref int num)
        {
            num = 10;
        }
    }
}
