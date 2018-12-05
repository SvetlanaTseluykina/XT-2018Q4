using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VectorGraphicsEditor
{
    public class Circle 
    {
        private Round round;

        public Circle(double x, double y, double radius, bool checkX, bool checkY, bool checkRadius)
        {
            this.round = new Round(x, y, radius, checkX, checkY, checkRadius);
        }

        public double GetCenterX
            => this.round.GetX;

        public double GetCenterY
            => this.round.GetY;

        public string TypeOfFigure
            => "circle";

        public double GetRadius
            => this.round.GetRadius;

        public double GetSquare
            => Math.PI * this.round.GetRadius * this.round.GetRadius;
    }
}
