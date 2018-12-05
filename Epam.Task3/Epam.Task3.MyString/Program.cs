using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.MyString
{
   public class Program
    {
      public static void Main(string[] args)
        {
            Console.Write("Print your string: ");
            string str = Console.ReadLine();
            int length = str.Length;
            MyString myString = new MyString(length);
            for (int i = 0; i < str.Length; i++)
            {
                myString[i] = str[i];
            }

            myString.ShowCharArray();
            Console.WriteLine("Length of your string is {0}", myString.MyLength());
            Console.Write("Print symbol you want to find: ");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Index of your symbol is {0}", myString.MyIndexOf(symbol));
            Console.WriteLine("Last index of your symbol is {0}", myString.MyLastIndexOf(symbol));
            Console.Write("Print another string: ");
            str = Console.ReadLine();
            length = str.Length;
            MyString myString2 = new MyString(length);
            for (int i = 0; i < str.Length; i++)
            {
                myString2[i] = str[i];
            }

            myString.MyConcat(myString2);
            Console.Write("After concatenation: ");
            myString.ShowCharArray();
            Console.WriteLine("Comparasion of two strings {0}", myString.MyCompare(myString2));
            Console.Write("Print symbol you want to delete: ");
            symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();
            myString.MyDelete(symbol);
            Console.WriteLine("After deletion: ");
            myString.ShowCharArray();
            Console.Write("Print symbol you want to insert: ");
            symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Print position: ");
            int pos;
            bool check = int.TryParse(Console.ReadLine(), out pos);
            while (!check || pos < 0 || pos >= myString.MyLength())
            {
                Console.WriteLine("Wrong position, try again");
                check = int.TryParse(Console.ReadLine(), out pos);
            }

            myString.MyInsert(symbol, pos);
            Console.WriteLine("After insertion:");
            myString.ShowCharArray();
            StringBuilder sb = myString.MyToString();
            Console.WriteLine("ToString: {0}", sb);           
            myString.MyToCharArray(sb);
            Console.Write("To charArray: ");
            myString.ShowCharArray();
        }
    }
}
