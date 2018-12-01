using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Square
{
    class Program
    {
        public static void Square(int n)
        {
            int i = 0;
            while (i != n)
            {
                if (i == n / 2)
                {
                    for (int j = 0; j != n; j++)
                    {
                        if (j == n / 2)
                        {
                            Console.Write(' ');
                        }
                        else
                        {
                            Console.Write('*');
                        }
                    }
                }
                else
                {
                    for (int j = 0; j != n; j++)
                    {
                        Console.Write('*');
                    }
                }
                Console.Write("\n");
                i++;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Print a positive odd number n = ");
            int n;
            if (int.TryParse(Console.ReadLine(), out n) && n > 0 && n % 2 == 1)
            {
                Square(n);
            }
            else
            {
                Console.WriteLine("Wrong input, n should be a positive odd number");
            }
        }
    }
}