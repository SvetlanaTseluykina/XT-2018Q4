using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epam.Task5.ISeekYou
{
    public class Program
    {
        private static Random rand = new Random();

        public static bool IsPositive(int item)
        {
            if (item > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main(string[] args)
        {
            List<int> list = new List<int>(500);
            for (int i = 0; i < list.Capacity; i++)
            {
                list.Add(rand.Next(-20, 20));
            }

            Stopwatch stopwatch = new Stopwatch();          
            List<int> res = new List<int>();
            Predicate<int> func = IsPositive;
            List<double> median = new List<double>();
            stopwatch.Start();
            res = list.Search();
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("using just method: {0}", ts);
            median.Add(ts.TotalMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();
            res = list.Search(func);
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            Console.WriteLine("usind delegate: {0}", ts);
            median.Add(ts.TotalMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();
            res = list.Search(delegate(int number)
            {
                return number > 0;
            });
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            Console.WriteLine("usind anonymous method: {0}", ts);
            median.Add(ts.TotalMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();
            res = list.Search(number => number > 0);
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            Console.WriteLine("usind lambda expression: {0}", ts);
            median.Add(ts.TotalMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();
            res = (from number in list
                   where number > 0
                   select number).ToList();
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            Console.WriteLine("usind LINQ-expression: {0}", ts);
            median.Add(ts.TotalMilliseconds);
            median.Sort();
            Console.WriteLine("median: {0}", median[median.Count / 2]);
        }
    }
}
