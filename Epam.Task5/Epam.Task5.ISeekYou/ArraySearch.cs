using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.ISeekYou
{
    public static class ArraySearch
    {
        public static List<int> Search(this IEnumerable<int> collection)
        {
            var positiveElements = new List<int>();
            foreach (var item in collection)
            {
                if (item > 0)
                {
                    positiveElements.Add(item);
                }
            }

            return positiveElements;
        }

        public static List<int> Search(this IEnumerable<int> collection, Predicate<int> func)
        {
            var positiveElements = new List<int>();
            foreach (var item in collection)
            {
                if (func(item))
                {
                    positiveElements.Add(item);
                }
            }

            return positiveElements;
        }
    }
}
