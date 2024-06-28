using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed
{

    //No se puede heredar de una clase "sealed"
    //Tambien se puede usar en funciones
    //Sirve para hacer optimizaciones porque el compilador sabra que esas funciones no se van a usar al heredar o esas clases
    // no se puede tener un public sealed sin override

    class A { }

    sealed class B : A { }

    //class C : B { }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
