using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Ring
{
    public class Ring : RoundShape
    {
        private double innerRadius;

        public Ring(double x, double y, double radius, double innerRadius) : base(x, y, radius)
        {
            this.innerRadius = innerRadius;
        }

        public double GetInnerRadius
            => this.innerRadius;

        public override double Square
            => Math.PI * ((this.GetRad * this.GetRad) - (this.innerRadius * this.innerRadius));

        public override double Length 
            => 2 * Math.PI * (this.GetRad + this.innerRadius);
    }
}
