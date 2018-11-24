using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.X_masTree
{
    class Program
    {
        public static void XmasTree(ref int n)
        {
            for (int count = 0; count != n; count++){
                for (int i = 0; i <= count; i++)
                {
                    for (int k = 0; k < (n - i - 1); k++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < (i * 2 + 1); j++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int n;
                Console.Write("Print a positive integer number n = ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                   XmasTree(ref n);
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
