using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Game
{
    public class Obstacle : ICoordinates, ISetName
    {
        private string nameOfObstacle;
        private double obstacleCoordX;
        private double obstacleCoordY;

        public Obstacle(Rectangle rectangle, double x, double y)
        {
            if (x >= rectangle.GetX1 && y >= rectangle.GetY1 && y <= rectangle.GetY2 && x <= rectangle.GetX2)
            {
                this.obstacleCoordX = x;
                this.obstacleCoordY = y;
            }
            else
            {
                this.obstacleCoordX = rectangle.GetX2;
                this.obstacleCoordY = rectangle.GetY2;
            }
        }

        public double GetX
            => this.obstacleCoordX;

        public double GetY
            => this.obstacleCoordY;

        public void SetCoordinates(double x, double y)
        {
            this.obstacleCoordX = x;
            this.obstacleCoordY = y;
        }

        public void SetName(string name)
        {
            this.nameOfObstacle = name;
        }
    }
}
