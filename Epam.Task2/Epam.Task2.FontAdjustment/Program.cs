using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.FontAdjustment
{
   public class Program
    {
        [Flags]
        public enum Font : byte
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 3,
        }

        public static void FontAdjustment()
        {
            Font font = Font.None;
            int n;
            Console.WriteLine("Параметры надписи: {0}", font);
            while (true)
            {
                Console.WriteLine("Введите:");
                Console.WriteLine("{0, 14}", "1: bold");
                Console.WriteLine("{0, 16}", "2: italic");
                Console.WriteLine("{0, 19}", "3: underline");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    switch (n)
                    {
                        case 1:
                            {
                                if (font == Font.None)
                                {
                                    font |= Font.Bold;
                                    Console.WriteLine("Параметры надписи: {0}", Font.Bold);
                                }
                                else if (font == Font.Bold)
                                {
                                    font &= Font.None;
                                    Console.WriteLine("Параметры надписи:{0}", Font.None);
                                }
                                else if (font == Font.Italic)
                                {
                                    font = ~(Font.Bold | Font.Italic);
                                    Console.WriteLine("Параметры надписи: {0}, {1}", Font.Bold, Font.Italic);
                                }
                                else if (font == (~(Font.Bold | Font.Italic)))
                                {
                                    font = Font.Italic;
                                    Console.WriteLine("Параметры надписи: {0}", Font.Italic);
                                }
                                else if (font == Font.Underline)
                                {
                                    font = ~(Font.Bold ^ Font.Underline);
                                    Console.WriteLine("Параметры надписи: {0}, {1}", Font.Bold, Font.Underline);
                                }
                                else if (font == ~(Font.Bold ^ Font.Underline))
                                {
                                    font = Font.Underline;
                                    Console.WriteLine("Параметры надписи:{0}", Font.Underline);
                                }
                                else if (font == ~(Font.Italic ^ Font.Underline))
                                {
                                    font |= Font.Bold;
                                    Console.WriteLine("Параметры надписи: {0}, {1}, {2}", Font.Bold, Font.Italic,           Font.Underline);
                                }
                                else if (font == (~(Font.Italic ^ Font.Underline) | Font.Bold))
                                {
                                    font ^= Font.Bold;
                                    Console.WriteLine("Параметры надписи: {0}, {1}", Font.Italic, Font.Underline);
                                }

                                break;
                            }

                        case 2:      
                            {
                                if (font == Font.None)
                                {
                                    font |= Font.Italic;
                                    Console.WriteLine("Параметры надписи: {0}", Font.Italic);
                                }
                                else if (font == Font.Italic)
                                {
                                    font &= Font.None;
                                    Console.WriteLine("Параметры надписи: {0}", Font.None);
                                }
                                else if (font == Font.Bold)
                                {
                                    font = ~(Font.Bold | Font.Italic);
                                    Console.WriteLine("Параметры надписи: {0}, {1}", Font.Bold, Font.Italic);
                                }
                                else if (font == (~(Font.Bold | Font.Italic)))
                                {
                                    font = Font.Bold;
                                    Console.WriteLine("Параметры надписи: {0}", Font.Bold);
                                }
                                else if (font == Font.Underline)
                                {
                                    font = ~(Font.Italic ^ Font.Underline);
                                    Console.WriteLine("Параметры надписи:{0}, {1}", Font.Italic, Font.Underline);
                                }
                                else if (font == ~(Font.Italic ^ Font.Underline))
                                {
                                    font = Font.Underline;
                                    Console.WriteLine("Параметры надписи: {0}", Font.Underline);
                                }
                                else if (font == ~(Font.Bold ^ Font.Underline))
                                {
                                    font |= Font.Italic;
                                    Console.WriteLine("Параметры надписи: {0}, {1}, {2}", Font.Bold, Font.Italic,           Font.Underline);
                                }
                                else if (font == (~(Font.Bold ^ Font.Underline) | Font.Italic))
                                {
                                    font ^= Font.Italic;
                                    Console.WriteLine("Параметры надписи:{0}, {1}", Font.Bold, Font.Underline);
                                }

                                break;
                            }

                        case 3:
                            {
                                if (font == Font.None)
                                {
                                font |= Font.Underline;
                                Console.WriteLine("Параметры надписи:{0}", Font.Underline);
                                }
                                else if (font == Font.Underline)
                                {
                                font &= Font.None;
                                Console.WriteLine("Параметры надписи: {0}", Font.None);
                                }
                                else if (font == Font.Bold)
                                {
                                    font = ~(Font.Bold ^ Font.Underline);
                                    Console.WriteLine("Параметры надписи: {0}, {1}", Font.Bold, Font.Underline);
                                }
                                else if (font == ~(Font.Bold ^ Font.Underline))
                                {
                                    font = Font.Bold;
                                    Console.WriteLine("Параметры надписи: {0}", Font.Bold);
                                }
                                else if (font == Font.Italic)
                                {
                                    font = ~(Font.Italic ^ Font.Underline);
                                    Console.WriteLine("Параметры надписи: {0}, {1}", Font.Italic, Font.Underline);
                                }
                                else if (font == ~(Font.Italic ^ Font.Underline))
                                {
                                    font = Font.Italic;
                                    Console.WriteLine("Параметры надписи: {0}", Font.Italic);
                                }
                                else if (font == (~(Font.Bold | Font.Italic)))
                                {
                                    font |= Font.Underline;
                                    Console.WriteLine("Параметры надписи: {0}, {1}, {2}", Font.Bold, Font.Italic,           Font.Underline);
                                }
                                else if (font == (~(Font.Bold | Font.Italic) | Font.Underline))
                                {
                                    font ^= Font.Underline;
                                    Console.WriteLine("Параметры надписи: {0}, {1}", Font.Bold, Font.Italic);
                                }

                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Error, please, enter 1, 2 or 3");
                }
            }
        }

        public static void Main(string[] args)
        {
            FontAdjustment();
        }
    }
}
