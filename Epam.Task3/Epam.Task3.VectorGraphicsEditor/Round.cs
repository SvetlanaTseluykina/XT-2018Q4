using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VectorGraphicsEditor
{
    public class Round : Figure
    {
        private double radius;

        public Round(double x, double y, double radius, bool checkX, bool checkY, bool checkRad) : base(x, y, checkX, checkY)
        {
            if (!checkRad)
            {
                throw new Exception("Error! the radius is not a number");
            }
            else if (radius < 0)
            {
                throw new Exception("Error! Radius < 0");
            }
            else
            {
                this.radius = radius;
            }
        }

        public override string TypeOfFigure 
            => "round";

        public double GetRadius
            => this.radius;
    }
}
