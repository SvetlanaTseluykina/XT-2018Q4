using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Sequence
{
    public class Program
    {
        public static void Seq(int n)
        {
            for (int i = 1; i != n; i++)
            {
                Console.Write(i + "," + " ");
            }
            Console.WriteLine(n);
        }

        static void Main(string[] args)
        {
            Console.Write("Print a positive number n = ");
            int n;
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                Seq(n);
            }
            else
            {
                Console.WriteLine("Wrong input, n should be a positive number");
            }
        }
    }
}