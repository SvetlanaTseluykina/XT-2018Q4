using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._2DArray
{
   public class Program
    {
        public static void TwoDimArray()
        {
            while (true)
            {
                int n;
                Console.Write("Print a positive integer number (> 0 && < 6) n = ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0 && n < 6)
                {
                    Random random = new Random();
                    int[,] arr = new int[n, n];
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            arr[i, j] = random.Next(10);
                            Console.Write(arr[i, j] + " ");
                        }

                        Console.WriteLine();
                    }

                    int sum = 0;
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            if ((i + j) % 2 == 0)
                            {
                                sum += arr[i, j];
                            }
                        }
                    }

                    Console.WriteLine("sum = " + sum);
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
            TwoDimArray();
        }
    }
}
