using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Round
{
   public class Round
    {
        private double x;
        private double y;
        private double radius;

        public Round(double x, double y, double rad)
        {
            this.x = x;
            this.y = y;
            this.radius = rad;
        } 

        public double GetX => this.x;

        public double GetY => this.y;

        public double GetRad => this.radius;

        public double Length
            => 2 * Math.PI * this.radius;

        public double Square
            => Math.PI * this.radius * this.radius;
    }
}
