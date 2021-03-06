﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.AnotherTriangle
{
   public class Program
    {
        public static void AnotherTriangle(int n)
        {
            const char Asterisk = '*';
            const char Space = ' ';
            for (int i = 0; i != n; i++)
            {
                for (int k = 0; k < (n - i - 1); k++)
                {
                    Console.Write(Space);
                }

                for (int j = 0; j < ((i * 2) + 1); j++)
                {
                    Console.Write(Asterisk);
                }

                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                int n;
                Console.Write("Print a positive integer number n = ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    AnotherTriangle(n);
                    break;
                }
                else
                {
                    Console.WriteLine("Error, \"n\" should be a positive integer number");
                }
            }
        }
    }
}
