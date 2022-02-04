using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeOOP
{
    class HorisontalLine : Figure
    {

        public HorisontalLine(int xLeft, int xRight, int y, char symb)
        {
            pointList = new List<Point>();

            for (int i = xLeft; i <= xRight; i++)
            {
                Point p = new Point(i, y, symb);
                pointList.Add(p);
            }

            // ##########

    }        
}
