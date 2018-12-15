using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.ToIntOrNotToInt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Print string: ");
            string str = Console.ReadLine();
            while (str.Trim() == string.Empty)
            {
                Console.WriteLine("You didn't print anything, try again");
                Console.Write("Print string: ");
                str = Console.ReadLine();
            }

            bool check = str.CheckNumber();
            Console.WriteLine("Is it Int? {0}", check);
        }
    }
}
