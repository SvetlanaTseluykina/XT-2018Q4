using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VectorGraphicsEditor
{
    public class Ring
    {
        private Round round;
        private double innerRadius;

        public Ring(double x, double y, double radius, double innerRadius, bool checkX, bool checkY, bool checkRadius, bool checkInnerRadius)
        {
            if (innerRadius < 0 || innerRadius >= radius)
            {
                throw new Exception("Error! 0 <= inner radius < radius");
            }
            else if (!checkInnerRadius)
            {
                throw new Exception("Error! Inner radius is not a number");
            }
            else
            {
                this.round = new Round(x, y, radius, checkX, checkY, checkRadius);
                this.innerRadius = innerRadius;
            }   
        }

        public string TypeOfFigure
           => "ring";

        public double GetCenterX
            => this.round.GetX;

        public double GetCenterY
            => this.round.GetY;

        public double GetRadius
            => this.round.GetRadius;

        public double GetInnerRadius
            => this.innerRadius;

        public double Square
            => Math.PI * ((this.round.GetRadius * this.round.GetRadius) - (this.innerRadius * this.innerRadius));
    }
}
