using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.ArrayProcessing
{
    public class Program
    {
        public static void ArrayProcessing()
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
                        arr[i] = random.Next(100);
                        Console.Write(arr[i] + " ");
                    }
                    Console.WriteLine();
                    int max = Int32.MinValue;
                    int min = Int32.MaxValue;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] > max)
                        {
                            max = arr[i];
                        }
                        if (arr[i] < min)
                        {
                            min = arr[i];
                        }
                    }
                    for (int i = 1; i <= arr.Length - 1; i++)
                    {
                        int j = i;
                        while (j > 0 && arr[j] < arr[j - 1])
                        {
                            arr[j - 1] = arr[j] + arr[j - 1];
                            arr[j] = arr[j - 1] - arr[j];
                            arr[j - 1] = arr[j - 1] - arr[j];
                            j--;
                        }
                    }
                    Console.WriteLine("max = " + max + " min = " + min);
                    Console.Write("Sorted array: ");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write(arr[i] + " ");
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
        static void Main(string[] args)
        {
            ArrayProcessing();
        }
    }
}
