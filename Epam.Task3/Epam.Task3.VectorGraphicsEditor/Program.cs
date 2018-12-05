using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VectorGraphicsEditor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What type of figure do you need? Choose one of them:");
            Console.WriteLine("line, round, rectangle, circle, ring");
            string pos = Console.ReadLine();
            double x1;
            double y1;
            bool checkX;
            bool checkY;
            string type;
            while (true)
            {
                Console.Write("Print x1: ");
            checkX = double.TryParse(Console.ReadLine(), out x1);
            Console.Write("Print y1: ");
            checkY = double.TryParse(Console.ReadLine(), out y1);
                try
                {
                    switch (pos)
                    {
                        case "line":
                            {
                                double x2;
                                double y2;
                                Console.Write("Print x2: ");
                                bool checkX2 = double.TryParse(Console.ReadLine(), out x2);
                                Console.Write("Print y2: ");
                                bool checkY2 = double.TryParse(Console.ReadLine(), out y2);
                                Line line = new Line(x1, y1, x2, y2, checkX, checkY, checkX2, checkY2);
                                type = line.TypeOfFigure;
                                Console.WriteLine("this is: {0}, {1}:", type, line.GetLine);
                                break;
                            }

                        case "round":
                            {
                                Console.Write("Print radius: ");
                                int radius;
                                bool checkRadius = int.TryParse(Console.ReadLine(), out radius);
                                while (!checkRadius)
                                {
                                    Console.WriteLine("Wrong radius, try again");
                                    Console.Write("Print radius: ");
                                    checkRadius = int.TryParse(Console.ReadLine(), out radius);
                                }

                                Round round = new Round(x1, y1, radius, checkX, checkY, checkRadius);
                                Console.WriteLine("this is: {0}, center ({1}, {2}) and radius {3}", round.TypeOfFigure, round.GetX, round.GetY, round.GetRadius);
                                break;
                            }

                        case "rectangle":
                            {
                                double x2;
                                double y2;
                                Console.Write("Print x2: ");
                                bool checkX2 = double.TryParse(Console.ReadLine(), out x2);
                                Console.Write("Print y2: ");
                                bool checkY2 = double.TryParse(Console.ReadLine(), out y2);
                                Rectangle rectangle = new Rectangle(x1, y1, x2, y2, checkX, checkY, checkX2, checkY2);
                                Console.WriteLine("this is: {0}, AB = {1}, BC = {2}, CD = {3}, AD = {4}, square = {5}", rectangle.TypeOfFigure, rectangle.GetAB, rectangle.GetBC, rectangle.GetCD, rectangle.GetAD, rectangle.GetSquare);
                                break;
                            }

                        case "circle":
                            {
                                Console.Write("Print radius: ");
                                int radius;
                                bool checkRadius = int.TryParse(Console.ReadLine(), out radius);
                                Circle circle = new Circle(x1, y1, radius, checkX, checkY, checkRadius);
                                Console.WriteLine("this is: {0}, center ({1}, {2}), radius = {3}, square = {4}", circle.TypeOfFigure, circle.GetCenterX, circle.GetCenterY, circle.GetRadius, circle.GetSquare);
                                break;
                            }

                        case "ring":
                            {
                                Console.Write("Print radius: ");
                                int radius;
                                bool checkRadius = int.TryParse(Console.ReadLine(), out radius);
                                Console.Write("Print inner radius: ");
                                int innerRadius;
                                bool checkInnerRadius = int.TryParse(Console.ReadLine(), out innerRadius);
                                Ring ring = new Ring(x1, y1, radius, innerRadius, checkX, checkY, checkRadius, checkInnerRadius);
                                Console.WriteLine("this is: {0}, center ({1}, {2}), radius = {3}, inner radius = {4}, square = {5}", ring.TypeOfFigure, ring.GetCenterX, ring.GetCenterY, ring.GetRadius, ring.GetInnerRadius, ring.Square);
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("You didn't choose one of those types");
                                break;
                            }
                    }

                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
