using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.NoNegativeSum
{
   public class Program
    {
        public static void NoNegSum()
        {
            while (true)
            {
                int n;
                Console.Write("Print a positive integer number (> 0 && < 15) n = ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0 && n < 15)
                {
                    int[] arr = new int[n];
                    Random random = new Random();
                    Console.Write("Generated array: ");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = random.Next(-100, 100);
                        Console.Write(arr[i] + " ");
                    }

                    Console.WriteLine();
                    int sum = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] >= 0)
                        {
                            sum += arr[i];
                        }
                    }

                    Console.WriteLine("Summa non-negative numbers = " + sum);
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input, try again");            
                }
            }
        }

        public static void Main(string[] args)
        {
            NoNegSum();
        }
    }
}
