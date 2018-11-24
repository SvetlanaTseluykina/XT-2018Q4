using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Triangle
{
   public class Program
    {
        public static void Triangle(ref int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
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
                    Triangle(ref n);
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
