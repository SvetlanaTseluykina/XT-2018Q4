using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Triangle
{
  public class Program
    {
       public static void Main(string[] args)
        {
            Console.Write("Print double a > 0: ");
            double a;
            bool check = double.TryParse(Console.ReadLine(), out a);
            while (!check || a <= 0)
            {
                Console.WriteLine("Wrong a, try again");
                Console.Write("Print double a > 0: ");
                check = double.TryParse(Console.ReadLine(), out a);
            }

            Console.Write("Print double b > 0: ");
            double b;
            check = double.TryParse(Console.ReadLine(), out b);
            while (!check || b <= 0)
            {
                Console.WriteLine("Wrong b, try again");
                Console.Write("Print double b > 0: ");
                check = double.TryParse(Console.ReadLine(), out b);
            }

            Console.Write("Print double c > 0: ");
            double c;
            check = double.TryParse(Console.ReadLine(), out c);
            while (!check)
            {
                Console.WriteLine("Wrong c, try again");
                Console.Write("Print double c > 0: ");
                check = double.TryParse(Console.ReadLine(), out c);
            }

            try
            {
                Triangle triangle = new Triangle(a, b, c);
                Console.WriteLine("A triangle with sides {0}, {1}, {2} exists", triangle.GetA, triangle.GetB, triangle.GetC);
                Console.WriteLine("Perimetr = {0}", triangle.Perimetr);
                Console.WriteLine("Square = {0}", triangle.Square);
            }
            catch (ArgumentException arg)
            {
                Console.WriteLine(arg.Message);
            }
        }
    }
}
