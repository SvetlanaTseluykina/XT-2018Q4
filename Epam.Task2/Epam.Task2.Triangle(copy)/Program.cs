using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Triangle_copy_
{
    public class Program
    {
        public static void Triangle(int n)
        {
           const char Ch = '*';
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(Ch);
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
                    Triangle(n);
                    break;
                }
                else
                {
                    Console.WriteLine("Error, n should be a positive integer number");
                }
            }
        }
    }
}
