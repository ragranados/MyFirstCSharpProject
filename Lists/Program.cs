﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> listNumbers = new List<int>();

            for (int i = 0; i < 3; i++) 
            {
                Console.Write("Ingrese Numero: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < listNumbers.Count; i++) 
            {
                Console.WriteLine(listNumbers[i]);
            }

            Console.ReadLine();
        }
    }
}
