﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WelcomeMessage("Raul");
            WelcomeMessage("Bebesilla");

            Console.ReadLine();
        }

        static void WelcomeMessage(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }
    }
}
