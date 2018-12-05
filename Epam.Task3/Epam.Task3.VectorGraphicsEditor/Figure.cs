using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VectorGraphicsEditor
{
    public abstract class Figure
    {
        private double x;
        private double y;

        protected Figure(double x, double y, bool checkX, bool checkY)
        {
            if (!checkX)
            {
                throw new Exception("Error! x is not a number");
            }
            else if (!checkY)
            {
                throw new Exception("Error! y is not a number");
            }
            else
            {
                this.x = x;
                this.y = y;
            } 
        }

        public double GetX
            => this.x;

        public double GetY
            => this.y;

        public virtual string TypeOfFigure
            => "Figure";
    }
}
