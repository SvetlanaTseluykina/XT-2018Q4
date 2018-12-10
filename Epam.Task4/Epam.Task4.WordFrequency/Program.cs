using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.WordFrequency
{
    public class Program
    {
        public static Dictionary<string, int> WordFrequency(ref string str)
        {
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsPunctuation(str[i]) && str[i] != '.')
                {
                    str = str.Remove(i, 1);
                }
            }

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string[] str2 = str.Split(' ', '.');

            foreach (string s in str2)
            {
                if (dictionary.ContainsKey(s))
                {
                    dictionary[s]++; 
                }
                else
                {
                    dictionary.Add(s, 1);
                }
            }

            dictionary.Remove(string.Empty);
            return dictionary;
        }

        public static void Main(string[] args)
        {
            Console.Write("Print your string: ");
            string str = Console.ReadLine();
            while (str.Trim() == string.Empty)
            {
                Console.WriteLine("You didn't print a string, try again");
                Console.Write("Print your string: ");
                str = Console.ReadLine();
            }

            Dictionary<string, int> dictionary = WordFrequency(ref str);          
            foreach (KeyValuePair<string, int> keyValue in dictionary)
            {
                Console.WriteLine("Frequency of {0} is {1}", keyValue.Key, keyValue.Value);
            }
        }
    }
}
