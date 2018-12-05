using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Triangle
{
   public class Triangle
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            if (a + b <= c || b + c <= a || a + c <= b)
            {
                throw new ArgumentException("Triangle doesn't exist because sum of two sides should be greater than the third side");
            }
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public double GetA
            => this.a;

        public double GetB
            => this.b;

        public double GetC
            => this.c;

        public double Perimetr
            => this.a + this.b + this.c;

        public double Square
        {
            get
            {
                double p = this.Perimetr / 2;
                return Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
            }
        }
    }
}
