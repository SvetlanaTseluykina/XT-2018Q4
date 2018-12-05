using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Game
{
    public class Enemy : ICoordinates, IMove, ISetName
    {
        private string nameOfEnemy;
        private double enemyCoordX;
        private double enemyCoordY;

        public Enemy(Rectangle rectangle, Obstacle obstacle, double x, double y)
        {
            if (x >= rectangle.GetX1 && y >= rectangle.GetY1 && y <= rectangle.GetY2 && x <= rectangle.GetX2 && x != obstacle.GetX && y != obstacle.GetY)
            {
                this.enemyCoordX = x;
                this.enemyCoordY = y;
            }
            else
            {
                this.enemyCoordX = rectangle.GetX1;
                this.enemyCoordY = rectangle.GetY2;
            }
        }

        public double GetX
            => this.enemyCoordX;

        public double GetY
            => this.enemyCoordY;

        public void SetCoordinates(double x, double y)
        {
            this.enemyCoordX = x;
            this.enemyCoordY = y;
        }

        public void SetName(string name)
        {
            this.nameOfEnemy = name;
        }

        public void Go(Rectangle rectangle)
        {
            if ((this.enemyCoordX + 1) <= rectangle.GetX2)
            {
                this.enemyCoordX++;
            }
            else
            {
                this.enemyCoordX--;
            }
        }
    }
}
