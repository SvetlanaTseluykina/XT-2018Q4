using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.NumberArraySum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 2, 4, 6, 8 };
            List<float> list2 = new List<float>() { 2.3f, 1.7f, 4.5f };
            List<double> list3 = new List<double>() { 2.2, 5.5, 3.4 };
            List<short> list4 = new List<short>() { 1, 7, 12, 8, 34 };
            List<long> list5 = new List<long>() { 4, 67, 11, 8, 32 };
            List<decimal> list6 = new List<decimal>() { 4.6m, 6.7m, 1.1m, 8.9m, 3.2m };
            int sum1 = list1.SumArr();
            float sum2 = list2.SumArr();
            double sum3 = list3.SumArr();
            short sum4 = list4.SumArr();
            long sum5 = list5.SumArr();
            decimal sum6 = list6.SumArr();
            Console.WriteLine("example of int sum: {0}", sum1);
            Console.WriteLine("example of float sum: {0}", sum2);
            Console.WriteLine("example of double sum: {0}", sum3);
            Console.WriteLine("example of short sum: {0}", sum4);
            Console.WriteLine("example of long sum: {0}", sum5);
            Console.WriteLine("example of decimal sum: {0}", sum6);
        }
    }
}
