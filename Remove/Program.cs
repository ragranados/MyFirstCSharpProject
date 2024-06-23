using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensaje = "C# es asombroso";

            mensaje = mensaje.Remove(1,1); //(desde donde se va a remover, cuantos se va a remover) 
            //Cuando solo es un parametro, desde ese hasta el final


            Console.WriteLine(mensaje);

            Console.ReadLine();
        }
    }
}
