using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected
{
    internal class Program
    {

        //protected, si es privado, la clase que herede de ella no lo podra usar, pero si es protectec y privado, la clase que herede de ella si podra hacer uso de ese campo
        class Point
        {
            private protected int x;
            private int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        class Position : Point
        {
            int z;

            public Position(int x, int y, int z) : base(x, y)
            {
                this.z = z;
                this.x = z;
            }
        }
        static void Main(string[] args)
        {

            Point point = new Point(2, 5);

            Position position = new Position(4, 5, 6);

            Console.ReadLine();
        }
    }
}
