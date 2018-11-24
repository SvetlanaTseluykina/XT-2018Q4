using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Rectangle
{
   public class Program
    {
        public static void Rectangle(ref int a, ref int b)
        {
            var s = a * b;
            Console.WriteLine("Square s = " + s);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int a;
                Console.Write("Print a positive integer number a = ");
                if (int.TryParse(Console.ReadLine(), out a) && a > 0)
                {
                    int b;
                    Console.Write("Print a positive integer number b = ");
                    if (int.TryParse(Console.ReadLine(), out b) && b > 0)
                    {
                        Rectangle(ref a, ref b);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error, \"b\" should be a positive integer number");
                    }
                }
                else
                {
                    Console.WriteLine("Error, \"a\" should be a positive integer number");
                }
            }
        }
    }
}
