﻿using Exercise_11.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(0, 15,56);

            Console.WriteLine(box.ToString());

            Console.ReadLine();
        }
    }
}
