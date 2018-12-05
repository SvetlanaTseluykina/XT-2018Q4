using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Round
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.Write("Print double x = ");
            double x;
            bool check = double.TryParse(Console.ReadLine(), out x);

            while (!check)
            {
                Console.WriteLine("Wrong x, try again");
                Console.Write("Print double x = ");
                check = double.TryParse(Console.ReadLine(), out x);
            }

            Console.Write("Print double y = ");
            double y;
            check = double.TryParse(Console.ReadLine(), out y);
            while (!check)
            {
                Console.WriteLine("Wrong y, try again");
                Console.Write("Print double y = ");
                check = double.TryParse(Console.ReadLine(), out y);
            }

            Console.Write("Print double radius > 0 = ");
            double radius;
            check = double.TryParse(Console.ReadLine(), out radius);
            while (!check || radius <= 0)
            {
                Console.WriteLine("Wrong radius, try again");
                Console.Write("Print double radius > 0 = ");
                check = double.TryParse(Console.ReadLine(), out radius);
            }

             Round round = new Round(x, y, radius);
             Console.WriteLine("Circle with coordinates ({0}, {1}) and radius {2} is created", round.GetX, round.GetY, round.GetRad);
             Console.WriteLine("Circle length = {0}", round.Length);
             Console.WriteLine("Circle square = {0}", round.Square);
        }
    }
}
