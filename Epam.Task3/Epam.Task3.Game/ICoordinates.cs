using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Game
{
    public interface ICoordinates
    {
        double GetX
        {
            get;
        }

        double GetY
        {
            get;
        }

        void SetCoordinates(double x, double y);
    }
}
