using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.SumOfNumbers
{
   public class Program
    {
        public static void SumOfNumbers()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("summa = " + sum);
        }

        public static void Main(string[] args)
        {
            SumOfNumbers();
        }
    }
}
