using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeOOP
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            HorisontalLine top = new HorisontalLine(0, 80, 0, '#');
            VerticalLine left = new VerticalLine(0, 25, 0, '#');
            HorisontalLine bottom = new HorisontalLine(0, 80, 25, '$');
            VerticalLine right = new VerticalLine(0, 25, 80, '$');

            VerticalLine obstracle = new VerticalLine(10, 13, 50, '%');

            wallList.Add(top);
            wallList.Add(left);
            wallList.Add(bottom);
            wallList.Add(right);
            wallList.Add(obstracle);

        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach(var point in pointList)
            {
                if (figure.IsHit(point))
                {
                    return true;
                }
            }

            return false;
        }
        
        public bool IsHit(Point point)
        {
            foreach(var p in pointList)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
