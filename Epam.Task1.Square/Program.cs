using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Square
{
    class Program
    {
        public void Square(int N)
        {
            int i = 0;
            while (i != N)
            {
                if (i == N / 2)
                {
                    for (int j = 0; j != N; j++)
                    {
                        if (j == N / 2) Console.Write(' ');
                        else Console.Write('*');
                    }
                }
                else
                {
                    for (int j = 0; j != N; j++)
                        Console.Write('*');
                }
                Console.Write("\n");
                i++;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int N = Int32.Parse(Console.ReadLine());
            Program program = new Program();
            program.Square(N);
        }
    }
}