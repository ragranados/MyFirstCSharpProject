﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

            while (i < 10)
            {
                i++;
                Console.WriteLine("Prueba " + i);
            }

            Console.ReadLine();

        }
    }
}
