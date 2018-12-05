using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Ring
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

            Console.Write("Print double inner radius > 0 = ");
            double innerRadius;
            check = double.TryParse(Console.ReadLine(), out innerRadius);
            while (!check || innerRadius <= 0 || innerRadius >= radius)
            {
                Console.WriteLine("Wrong inner radius, try again");
                Console.Write("Print double inner radius > 0 = ");
                check = double.TryParse(Console.ReadLine(), out innerRadius);
            }

            Ring ring = new Ring(x, y, radius, innerRadius);
            Console.WriteLine("Ring with coordinates ({0}, {1}), radius {2} and inner radius {3} is created", ring.GetX, ring.GetY, ring.GetRad, ring.GetInnerRadius);
            Console.WriteLine("Ring's square = {0}", ring.Square);
            Console.WriteLine("Ring's inner and outer length = {0}", ring.Length);
        }
    }
}
