using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.Lost
{
    public class Program
    {
        public static List<int> CreateList(int n)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(i + 1);
            }

            return list;
        }

        public static void Cycle(List<int> list)
        {
            while (list.Count > 1)
            {
                if (list.Count % 2 == 1)
                {
                    list.Remove(list[0]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        list.Remove(list[i]);
                    }
                }
                else
                {
                    for (int i = 1; i < list.Count; i++)
                    {
                        list.Remove(list[i]);
                    }
                }
            }
        }

        public static void Main(string[] args)
        { 
            try
            {
                List<int> list = new List<int>();
                int numOfPeople;
                Console.Write("Print number of people: ");
                int.TryParse(Console.ReadLine(), out numOfPeople);
                list = CreateList(numOfPeople);
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write("{0} ", list[i]);
                }

                Console.WriteLine();
                Cycle(list);
                Console.WriteLine("The lost one is: {0}", list[0]);
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}
