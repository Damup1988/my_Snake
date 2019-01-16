using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Snake
{
    class TheSnake : Figure
    {

        public TheSnake(Point tail,int snake_lenght,Directions direct)// It's a constructor
        {
            pList = new List<Point>(); // New list for the snake
            for(int i=0;i<=snake_lenght;i++)
            {
                Point p = new Point(tail);
                p.Move(i,direct);
                pList.Add(p);
            }
        }
    }
}
