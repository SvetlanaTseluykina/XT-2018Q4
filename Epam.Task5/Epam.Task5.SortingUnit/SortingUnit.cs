using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epam.Task5.SortingUnit
{
    public class SortingUnit
    {
        public delegate void NewEvent();

        public event NewEvent SortIsFinished;

        public void QuickSort<T>(List<T> array, int left, int right, Func<T, T, int> func)
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
                this.QuickSort(array, left, j, func);
            }

            if (i < right)
            {
                this.QuickSort(array, i, right, func);
            }
        }

        public int CompareString(string str1, string str2)
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

        public void NewThread<T>(List<T> array, int left, int right, Func<T, T, int> func)
        {
            ThreadStart threadStart = new ThreadStart(() => this.QuickSort(array, left, right, func));
            Thread th = new Thread(threadStart);
            th.Start();
            th.Join();
            this.SortIsFinished();
        }
    }
}
