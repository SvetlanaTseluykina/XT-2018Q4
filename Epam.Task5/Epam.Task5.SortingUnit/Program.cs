using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epam.Task5.SortingUnit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SortingUnit sortingUnit = new SortingUnit();
            CallEvent callEvent = new CallEvent();
            sortingUnit.SortIsFinished += callEvent.Message;
            List<string> list = new List<string>() { "Ivanov", "Petrov", "stroka", "join", "SortingUnit", "12234567898" };
            int left = 0;
            int right = list.Count() - 1;
            Func<string, string, int> func = sortingUnit.CompareString;
            sortingUnit.NewThread(list, left, right, func);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0} ", list[i]);
            }

            Console.WriteLine();
        }
    }
}
