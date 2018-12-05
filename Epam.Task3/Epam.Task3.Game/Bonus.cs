using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Game
{
    public class Bonus : ICoordinates, ISetName
    {
        private string nameOfBonus;
        private double bonusCoordX;
        private double bonusCoordY;

        public Bonus(Rectangle rectangle, Obstacle obstacle, double x, double y)
        {
            if (x >= rectangle.GetX1 && y >= rectangle.GetY1 && y <= rectangle.GetY2 && x <= rectangle.GetX2 && x != obstacle.GetX && y != obstacle.GetY)
            {
                this.bonusCoordX = x;
                this.bonusCoordY = y;
            }
            else
            {
                this.bonusCoordX = rectangle.GetX2;
                this.bonusCoordY = rectangle.GetY1;
            }
        }

        public double GetX
            => this.bonusCoordX;

        public double GetY
            => this.bonusCoordY;

        public void SetCoordinates(double x, double y)
        {
            this.bonusCoordX = x;
            this.bonusCoordY = y;
        }

        public void SetName(string name)
        {
            this.nameOfBonus = name;
        }
    }
}