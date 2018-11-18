using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Sequence
{
    class Program
    {
        public string Seq(int N)
        {
            string str = "";
            for (int i = 1; i != N; i++)
            {
                str += i + "," + " ";
            }
            str += N;
            return str;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int N = Int32.Parse(Console.ReadLine());
            Program program = new Program();
            Console.WriteLine(program.Seq(N));
        }
    }
}