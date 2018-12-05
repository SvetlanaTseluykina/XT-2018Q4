using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Ring
{
    public abstract class RoundShape
    {
        private double x;
        private double y;
        private double radius;

        public RoundShape(double x, double y, double radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public double GetX => this.x;

        public double GetY => this.y;

        public double GetRad => this.radius;

        public virtual double Length
            => 2 * Math.PI * this.radius;

        public virtual double Square
            => Math.PI * this.radius * this.radius;
    }
}
