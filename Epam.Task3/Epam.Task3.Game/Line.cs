using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Game
{
    public class Line
    {
        private double x1;
        private double y1;
        private double x2;
        private double y2;

        public Line(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public double GetX1
            => this.x1;

        public double GetX2
            => this.x2;

        public double GetY1
            => this.y1;

        public double GetY2
            => this.y2;

        public double GetLine
            => Math.Sqrt(((this.x2 - this.x1) * (this.x2 - this.x1)) + ((this.y2 - this.y1) * (this.y2 - this.y2)));
    }
}
