using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.NoPositive
{
     public class Program
    {
        public static void NoPositive()
        {
            while (true)
            {
                int n;
                Console.Write("Print a positive integer number (> 0 && < 6) n = ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0 && n < 6)
                {
                    Random random = new Random();
                    int[,,] arr = new int[n, n, n];
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            for (int k = 0; k < arr.GetLength(2); k++)
                            {
                                arr[i, j, k] = random.Next(-10, 10);
                            }
                        }
                    }

                    Console.WriteLine("Initial 3D array:");
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            for (int k = 0; k < arr.GetLength(2); k++)
                            {
                                Console.Write(arr[i, j, k] + " ");
                            }

                            Console.WriteLine();
                        }

                        Console.WriteLine();
                    }

                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            for (int k = 0; k < arr.GetLength(2); k++)
                            {
                                if (arr[i, j, k] > 0)
                                {
                                    arr[i, j, k] = 0;
                                }
                            }
                        }
                    }

                    Console.WriteLine("Changed 3D array:");
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            for (int k = 0; k < arr.GetLength(2); k++)
                            {
                                Console.Write(arr[i, j, k] + " ");
                            }

                            Console.WriteLine();
                        }

                        Console.WriteLine();
                    }

                    Console.WriteLine();
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
            NoPositive();
        }
    }
}
