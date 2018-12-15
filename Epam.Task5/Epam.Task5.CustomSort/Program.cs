using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.CustomSort
{
    public class Program
    { 
        public static void QuickSort<T>(List<T> array, int left, int right, Func<T, T, int> func)
        {
            if (func == null)
            {
                throw new ArgumentNullException();
            }

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
                QuickSort(array, left, j, func);
            }

            if (i < right)
            {
                QuickSort(array, i, right, func);
            }
        }

        public static int СompareElements(int first, int second) 
        {
            if (first.Equals(second))
            {
                return 0;
            }
            else if (first < second)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public static void Main(string[] args)
        {
            List<int> list = new List<int>() { 2, 6, 1, 4, 7 };
            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            int left = 0;
            int right = list.Count() - 1;
            Func<int, int, int> func = СompareElements;
            try
            {
                QuickSort(list, left, right, func);
                foreach (var item in list)
                {
                    Console.Write("{0} ", item);
                }

                Console.WriteLine();
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Argument was null");
            }
        }
    }
}
