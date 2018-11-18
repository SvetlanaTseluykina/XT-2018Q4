using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Simple
{
    class Program
    {
        public void Simple(int N)
        {
            if (N == 1 || N == 2)
            {
                Console.WriteLine("Число не является простым");
                return;
            }
            bool fl = false;
            for (int i = 2; i != N; i++)
            {
                if (N % i == 0)
                {
                    fl = true;
                    break;
                }
            }
            if (fl) Console.WriteLine("Число не является простым");
            else Console.WriteLine("Число является простым");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int N = Int32.Parse(Console.ReadLine());
            Program program = new Program();
            program.Simple(N);
        }
    }
}