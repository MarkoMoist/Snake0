using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeOOP
{
    class Figure
    {
        protected List<Point> pointList;

        public void Draw()
        {
            foreach (Point point in pointList)
            {
                point.Draw();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
