using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.X_masTree
{
    public class Program
    {
        public static void XmasTree(int n)
        {
            const char Asterics = '*';
            const char Space = ' ';
            for (int count = 0; count != n; count++)
            {
                for (int i = 0; i <= count; i++)
                {
                    for (int k = 0; k < (n - i - 1); k++)
                    {
                        Console.Write(Space);
                    }

                    for (int j = 0; j < ((i * 2) + 1); j++)
                    {
                        Console.Write(Asterics);
                    }

                    Console.WriteLine();
                }
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
                   XmasTree(n);
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
