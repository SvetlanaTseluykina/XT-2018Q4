using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Game
{
    public class Game : ICoordinates, IMove, ISetName
    {
        private Enemy enemy1;
        private Enemy enemy2;
        private Enemy enemy3;
        private Obstacle obstacle;
        private Bonus bonus1;
        private Rectangle rectangle;
        private string playerName;
        private double playerXCoord;
        private double playerYCoord;

        public Game(double x1, double y1, double x2, double y2, double x, double y)
        {
            this.rectangle = new Rectangle(x1, y1, x2, y2);
            this.obstacle = new Obstacle(this.rectangle, x2 - x, y2 - y);
            this.enemy1 = new Enemy(this.rectangle, this.obstacle, x1 + 1, y1 + 1);
            this.enemy2 = new Enemy(this.rectangle, this.obstacle, x1 + 2, y2 + 2);
            this.enemy3 = new Enemy(this.rectangle, this.obstacle, x1 + 3, y2 + 3);
            this.bonus1 = new Bonus(this.rectangle, this.obstacle, x2 - 1, y2 - 1);
            if (x >= this.rectangle.GetX1 && y >= this.rectangle.GetY1 && y <= this.rectangle.GetY2 && x <= this.rectangle.GetX2 && x != this.obstacle.GetX && y != this.obstacle.GetY && x != this.enemy1.GetX && y != this.enemy1.GetY && x != this.enemy2.GetX && y != this.enemy2.GetY && x != this.enemy3.GetX && y != this.enemy3.GetY)
            {
                this.playerXCoord = x;
                this.playerYCoord = y;
            }
            else
            {
                this.playerXCoord = this.rectangle.GetX1;
                this.playerYCoord = this.rectangle.GetY1;
            }
        }

        public double GetX
            => this.playerXCoord;

        public double GetY
            => this.playerYCoord;

        public void SetCoordinates(double x, double y)
        {
            this.playerXCoord = x;
            this.playerYCoord = y;
        }

        public void SetName(string name)
        {
            this.playerName = name;
        }

        public void Go(Rectangle rectangle)
        {
            int numOfBonus = 1;
            while (numOfBonus > 0)
            {
                if (this.playerXCoord == this.bonus1.GetX && this.playerYCoord == this.bonus1.GetY)
                {
                    numOfBonus--;
                }
                else if (this.playerXCoord < this.bonus1.GetX && this.playerYCoord < this.bonus1.GetY)
                {
                    if (this.playerXCoord + 1 != this.enemy1.GetX + 1 && this.playerXCoord + 1 != this.enemy2.GetX - 1 && this.playerXCoord + 1 != this.enemy3.GetX - 1 && this.playerXCoord + 1 != this.obstacle.GetX)
                    {
                        this.playerXCoord++;
                        this.enemy1.Go(rectangle);
                        this.enemy2.Go(rectangle);
                        this.enemy3.Go(rectangle);
                    }
                    else if (this.playerYCoord + 1 != this.enemy1.GetY + 1 && this.playerYCoord + 1 != this.enemy2.GetY - 1 && this.playerYCoord + 1 != this.enemy3.GetY - 1 && this.playerYCoord + 1 != this.obstacle.GetY)
                    {
                        this.playerYCoord++;
                        this.enemy1.Go(rectangle);
                        this.enemy2.Go(rectangle);
                        this.enemy3.Go(rectangle);
                    }
                    else
                    {
                        this.playerXCoord++;
                        this.playerYCoord++;
                        this.enemy1.Go(rectangle);
                        this.enemy2.Go(rectangle);
                        this.enemy3.Go(rectangle);
                    }
                }
                else if (this.playerXCoord > this.bonus1.GetX && this.playerYCoord < this.bonus1.GetY)
                {
                    if (this.playerXCoord - 1 != this.enemy1.GetX - 1 && this.playerXCoord - 1 != this.enemy2.GetX - 1 && this.playerXCoord - 1 != this.enemy3.GetX - 1 && this.playerXCoord - 1 != this.obstacle.GetX)
                    {
                        this.playerXCoord--;
                        this.enemy1.Go(rectangle);
                        this.enemy2.Go(rectangle);
                        this.enemy3.Go(rectangle);
                    }
                    else if (this.playerYCoord + 1 != this.enemy1.GetY + 1 && this.playerYCoord + 1 != this.enemy2.GetY + 1 && this.playerYCoord + 1 != this.enemy3.GetY + 1 && this.playerYCoord + 1 != this.obstacle.GetY)
                    {
                        this.playerYCoord++;
                        this.enemy1.Go(rectangle);
                        this.enemy2.Go(rectangle);
                        this.enemy3.Go(rectangle);
                    }
                    else
                    {
                        this.playerXCoord--;
                        this.playerYCoord++;
                        this.enemy1.Go(rectangle);
                        this.enemy2.Go(rectangle);
                        this.enemy3.Go(rectangle);
                    }
                }
                else if (this.playerXCoord < this.bonus1.GetX && this.playerYCoord > this.bonus1.GetY)
                {
                    if (this.playerXCoord + 1 != this.enemy1.GetX + 1 && this.playerXCoord + 1 != this.enemy2.GetX + 1 && this.playerXCoord + 1 != this.enemy3.GetX + 1 && this.playerXCoord + 1 != this.obstacle.GetX)
                    {
                        this.playerXCoord++;
                        this.enemy1.Go(rectangle);
                        this.enemy2.Go(rectangle);
                        this.enemy3.Go(rectangle);
                    }
                    else if (this.playerYCoord - 1 != this.enemy1.GetY - 1 && this.playerYCoord - 1 != this.enemy2.GetY - 1 && this.playerYCoord - 1 != this.enemy3.GetY - 1 && this.playerYCoord - 1 != this.obstacle.GetY)
                    {
                        this.playerYCoord--;
                        this.enemy1.Go(rectangle);
                        this.enemy2.Go(rectangle);
                        this.enemy3.Go(rectangle);
                    }
                    else
                    {
                        this.playerXCoord++;
                        this.playerYCoord--;
                        this.enemy1.Go(rectangle);
                        this.enemy2.Go(rectangle);
                        this.enemy3.Go(rectangle);
                    }
                }
                else if (this.playerXCoord != this.bonus1.GetX || this.playerYCoord != this.bonus1.GetY)
                {
                    if (this.playerXCoord + 1 != this.enemy1.GetX + 1 && this.playerXCoord + 1 != this.enemy2.GetX + 1 && this.playerXCoord + 1 != this.enemy3.GetX + 1 && this.playerXCoord + 1 != this.obstacle.GetX)
                    {
                        this.playerXCoord++;
                        this.enemy1.Go(rectangle);
                        this.enemy2.Go(rectangle);
                        this.enemy3.Go(rectangle);
                    }
                    else if (this.playerXCoord - 1 != this.enemy1.GetX - 1 && this.playerXCoord - 1 != this.enemy2.GetX - 1 && this.playerXCoord - 1 != this.enemy3.GetX - 1 && this.playerXCoord - 1 != this.obstacle.GetX)
                    {
                        this.playerXCoord--;
                        this.enemy1.Go(rectangle);
                        this.enemy2.Go(rectangle);
                        this.enemy3.Go(rectangle);
                    }
                    else if (this.playerYCoord - 1 != this.enemy1.GetY - 1 && this.playerYCoord - 1 != this.enemy2.GetY - 1 && this.playerYCoord - 1 != this.enemy3.GetY - 1 && this.playerYCoord - 1 != this.obstacle.GetY)
                    {
                        this.playerYCoord--;
                        this.enemy1.Go(rectangle);
                        this.enemy2.Go(rectangle);
                        this.enemy3.Go(rectangle);
                    }
                    else
                    {
                        this.playerYCoord--;
                    }
                }
            }
        }
    }
}
