using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.DynamicArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DynamicArray<int> dynamicArray1 = new DynamicArray<int>();
            Console.Write("Print length of the second array: ");
            int length;
            bool check = int.TryParse(Console.ReadLine(), out length);
            while (!check || length <= 0)
            {
                Console.WriteLine("Wrong input, try again");
                Console.Write("Print length: ");
                check = int.TryParse(Console.ReadLine(), out length);
            }

            DynamicArray<int> dynamicArray2 = new DynamicArray<int>(length);
            for (int i = 0; i < dynamicArray1.Capacity; i++)
            {
                dynamicArray1.Add(i + 1);
            }

            dynamicArray2.Add(12);
            dynamicArray2.Add(15);
            Console.WriteLine("This is the first array:");
            foreach (var item in dynamicArray1)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            Console.WriteLine("This is the second array:");
            foreach (var item in dynamicArray2)
            {
                Console.Write("{0} ", item);
            }
         
            Console.WriteLine();
            Console.WriteLine("Remove 2 in the first array: {0}", dynamicArray1.Remove(2));
            try
            {
                Console.WriteLine("Remove the element on the first position in the second array:");
                dynamicArray2.RemoveAt(1);
                foreach (var item in dynamicArray2)
                {
                    Console.Write("{0} ", item);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
   
            Console.WriteLine();
            Console.WriteLine("Capacity of the first array: {0}", dynamicArray1.Capacity);
            Console.WriteLine("Capacity of the second array: {0}", dynamicArray2.Capacity);
            Console.WriteLine("Length of the first array: {0}", dynamicArray1.Length);
            Console.WriteLine("Length of the second array: {0}", dynamicArray2.Length);
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            try
            {
                DynamicArray<int> dynamicArray3 = new DynamicArray<int>(stack);
                dynamicArray3.AddRange(stack);
                Console.WriteLine("This is the third array:");
                foreach (var item in dynamicArray3)
                {
                    Console.Write("{0} ", item);
                }
 
                Console.WriteLine();
                try
                {
                    Console.WriteLine("Insert 5 on the third position in the third array:");
                    dynamicArray3.Insert(3, 5);
                    foreach (var item in dynamicArray3)
                    {
                        Console.Write("{0} ", item);
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine();
                Console.WriteLine("Capacity of the third array: {0}", dynamicArray3.Capacity);
                Console.WriteLine("Length of the third array: {0}", dynamicArray3.Length);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
