using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace my_Snake
{
    class HorizontalLines : Figure //Inheritance
    {
        public HorizontalLines(int xLeft,int xRight, int y, char sym)
        {
            pList = new List<Point>(); //create new object of List class
           

            for(int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
