using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Game
{
    public class Rectangle
    {
        private Line width;
        private Line height;

        public Rectangle(double x1, double y1, double x2, double y2)
        {
            this.height = new Line(x1, y1, x1, y2);
            this.width = new Line(x1, y1, x2, y1);
        }

        public double GetX1
            => this.height.GetX1;

        public double GetX2
            => this.width.GetX2;

        public double GetY1
            => this.height.GetY1;

        public double GetY2
            => this.height.GetY2;

        public double GetHeight
            => this.height.GetLine;

        public double GetWidth
           => this.width.GetLine;
    }
}
