using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.NumberArraySum
{
    public static class SumArray
    {
        public static int SumArr(this IEnumerable<int> collection)
        {
            var sumOfElements = 0;
            foreach (var item in collection)
            {
                sumOfElements += item;
            }

            return sumOfElements;
        }

        public static double SumArr(this IEnumerable<double> collection)
        {
            var sumOfElements = 0.0;
            foreach (var item in collection)
            {
                sumOfElements += item;
            }

            return sumOfElements;
        }

        public static float SumArr(this IEnumerable<float> collection)
        {
            var sumOfElements = 0.0f;
            foreach (var item in collection)
            {
                sumOfElements += item;
            }

            return sumOfElements;
        }

        public static decimal SumArr(this IEnumerable<decimal> collection)
        {
            var sumOfElements = 0.0m;
            foreach (var item in collection)
            {
                sumOfElements += item;
            }

            return sumOfElements;
        }

        public static long SumArr(this IEnumerable<long> collection)
        {
            var sumOfElements = (long)0;
            foreach (var item in collection)
            {
                sumOfElements += item;
            }

            return sumOfElements;
        }

        public static short SumArr(this IEnumerable<short> collection)
        {
            var sumOfElements = (short)0;
            foreach (var item in collection)
            {
                sumOfElements += item;
            }

            return sumOfElements;
        }
    }
}
