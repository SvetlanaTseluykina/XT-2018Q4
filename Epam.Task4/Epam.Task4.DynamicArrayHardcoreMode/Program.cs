using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.DynamicArrayHardcoreMode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DynamicArrayHard<int> array = new DynamicArrayHard<int>();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            Console.WriteLine("Vice versa:");
            try
            {
                for (int i = -1; i >= -array.Length; i--)
                {
                    Console.Write(array[i]);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            array.ChangeCapacity(5);
            Console.WriteLine("New capacity:");
            foreach (int item in array)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            int[] newArray = array.ToArray();
            Console.WriteLine("To Array:");
            foreach (int item in newArray)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            DynamicArray<int> arrayClone = new DynamicArray<int>(array.Length);
            arrayClone = (DynamicArray<int>)array.Clone();
            Console.WriteLine("Cloned Array:");
            foreach (var item in arrayClone)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            CycledDynamicArray<int> arr = new CycledDynamicArray<int>();
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            Console.WriteLine("Cycled Array:");
            foreach (var item in arr)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }
    }
}
