using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VectorGraphicsEditor
{
    public class Line : Figure
    {
        private double x2;
        private double y2;

        public Line(double x1, double y1, double x2, double y2, bool checkX1, bool checkY1, bool checkX2, bool checkY2) : base(x1, y1, checkX1, checkY1)
        {
            if (!checkX2 || !checkY2)
            {
                throw new Exception("Error! Coordinate (coordinates) is (are) incorrect");
            }

            this.x2 = x2;
            this.y2 = y2;
        }

        public override string TypeOfFigure
            => "line";

        public double GetLine
            => Math.Sqrt(((this.x2 - this.GetX) * (this.x2 - this.GetX)) + ((this.y2 - this.GetY) * (this.y2 - this.GetY)));
    }
}
