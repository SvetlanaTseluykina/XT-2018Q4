using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VectorGraphicsEditor
{
    public class Rectangle
    {
        private Line ab;
        private Line bc;
        private Line cd;
        private Line ad;

        public Rectangle(double x1, double y1, double x2, double y2, bool checkX1, bool checkY1, bool checkX2, bool checkY2)
        {
            this.ab = new Line(x1, y1, x1, y2, checkX1, checkY1, checkX2, checkY2);
            this.bc = new Line(x1, y2, x2, y2, checkX1, checkY2, checkX2, checkY2);
            this.cd = new Line(x2, y1, x2, y2, checkX2, checkY1, checkX2, checkY2);
            this.ad = new Line(x1, y1, x2, y1, checkX1, checkY1, checkX2, checkY1);
        }

        public string TypeOfFigure
            => "rectangle";

        public double GetAB
            => this.ab.GetLine;

        public double GetBC
            => this.bc.GetLine;

        public double GetCD
            => this.cd.GetLine;

        public double GetAD
            => this.ad.GetLine;

        public double GetSquare
            => this.ab.GetLine * this.bc.GetLine;
    }
}
