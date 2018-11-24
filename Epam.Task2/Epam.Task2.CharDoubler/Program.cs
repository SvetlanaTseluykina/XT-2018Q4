using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.CharDoubler
{
    class Program
    {
        public static void CharDoubler()
        {
            Console.Write("Print first string: ");
            string str1;
            var strb = new StringBuilder(Console.ReadLine());
            Console.Write("Print second string: ");
            str1 = Console.ReadLine();
            var sb = new StringBuilder();
            for (int j = 0; j != str1.Length; j++)
            {
                bool fl = false;
                if (char.IsLetter(str1[j]))
                {
                    for (int k = j + 1; k != str1.Length; k++)
                    {
                        if (str1[j] == str1[k]) 
                        {
                            fl = true;
                            break;
                        }
                    }
                    if (!fl)
                    {
                        sb.Append(str1[j]);
                    }
                }
            }
            for (int i = 0; i != sb.Length; i++)
            {
                for (int j = 0; j != strb.Length; j++)
                {
                    if (strb[j] == sb[i])
                    {
                        strb.Insert(j, sb[i]);
                        j++;
                    }
                }
            }
            Console.WriteLine(strb);
        }
        static void Main(string[] args)
        {
            CharDoubler();
        }
    }
}
