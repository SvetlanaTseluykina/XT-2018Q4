using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.AverageStringLength
{
   public class Program
    {
        public static void AverStrLen()
        {
            string str;
            Console.Write("Print your string: ");
            str = Console.ReadLine();
            int countLetters = 0;
            int countWords = 0;
            for (int i = 0; i != str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    countLetters++;
                }
                else if (char.IsPunctuation(str[i]) && i != str.Length - 1 && str[i + 1] == ' ' ) 
                {
                    countWords++;
                    i++;
                }
                else if (char.IsPunctuation(str[i]) && i != str.Length - 1)
                {
                    countWords++;
                }
                else if (str[i] == ' ' && i != str.Length - 1)
                {
                    countWords++;
                }
            }
            countWords++;
            int length = countLetters / countWords;
            Console.WriteLine("The average word length in the string = " + length);
        }
        static void Main(string[] args)
        {
            AverStrLen();
        }
    }
}
