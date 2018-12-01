using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Simple
{
    public class Program
    {
        public static void Simple(int n)
        {
            if (n == 1 || n == 2)
            {
                Console.WriteLine("The number isn't simple");
                return;
            }
            bool fl = false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    fl = true;
                    break;
                }
            }
            if (fl)
            {
                Console.WriteLine("The number isn't simple");
            }
            else
            {
                Console.WriteLine("The number is simple");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Print a positive number n = ");
            int n;
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                Simple(n);
            }
            else
            {
                Console.WriteLine("Wrong input, n should be a positive number");
            }
        }
    }
}