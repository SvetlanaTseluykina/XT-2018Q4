using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.CustomSortDemo
{
    public class Program
    {
        public static void QuickSort<T>(List<T> array, int left, int right, Func<T, T, int> func)
        {
            int i = left;
            int j = right;
            int pivot = (i + j) / 2;
            while (i <= j)
            {
                while (func(array[i], array[pivot]) == -1)
                {
                    i++;
                }

                while (func(array[j], array[pivot]) == 1)
                {
                    j--;
                }

                if (i <= j)
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (j > left)
            {
                QuickSort<T>(array, left, j, func);
            }

            if (i < right)
            {
                QuickSort<T>(array, i, right, func);
            }
        }

        public static int CompareString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return -1;
            }
            else if (str1.Length > str2.Length)
            {
                return 1;
            }
            else if (str1.Equals(str2))
            {
                return 0;
            }
            else
            {
                bool fl = false;
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] > str2[i])
                    {
                        fl = true;
                        break;
                    }
                }

                if (!fl)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Print number of strings: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Wrong input, try again");
                Console.Write("Print number of strings: ");
            }

            List<string> list = new List<string>();
            for (int i = 0; i < number; i++)
            {
                Console.Write("Print {0} string: ", i + 1);
                string str = Console.ReadLine();
                list.Add(str);
            }

            int left = 0;
            int right = list.Count() - 1;
            Func<string, string, int> func = CompareString;
            QuickSort(list, left, right, func);
            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
        }
    }
}
