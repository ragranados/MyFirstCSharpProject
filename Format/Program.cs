using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*El formato que se ocupa aqui es que el primer
             numero, indica el numero de argumento, por ejemplo
            0, va con value y si se pone otro, el uno por ejemplo
            iria con el tercer argumento de la funcion, como en
            el primero ejemplo*/

            double value = 1000D / 12.34D;
            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0} {1}", value, "otro"));
            Console.WriteLine(string.Format("{0:0.#}", value));
            Console.WriteLine(string.Format("{0:0.##}", value));

            double money = 10D / 3D;
            Console.WriteLine(money);
            Console.WriteLine(string.Format("${0:0.00}", money));


            Console.ReadLine();

        }
    }
}
