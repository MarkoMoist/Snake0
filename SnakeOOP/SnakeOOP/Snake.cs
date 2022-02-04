using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeOOP
{
    class Snake : Figure
    {
        Direction direction;
        private int i;

        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pointList = new List<Point>();
            for(int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pointList.Add(p);
            }
        }

        public void Move()
        {
            Point tail = pointList.First();
            pointList.Remove(tail);
            tail.Clear();

            Point head = GetNextPoint();
            pointList.Add(head);
            head.Draw();

        }

        public void GetNextPoint()
        {
            Point head = pointList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKeys(ConsoleKey Key)
        {
            if(Key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            } else if (Key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            } else if(Key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            } else if(Key = ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
        }

        internal void HandleKeys(object key)
        {
            throw new NotImplementedException();
        }

        //*********

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.symb = head.symb;
                pointList.Add(food);
                return true;
            } else
            {
                return false;
            }
        }

        public int IsHitTail()
        {
            Point head = pointList.Last();
            for (int i = 0; i < pointList.Count; -2; i++)
            {
                if (head.IsHit(pointList[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
