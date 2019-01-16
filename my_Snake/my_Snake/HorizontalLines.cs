using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace my_Snake
{
    class HorizontalLines
    {
        List<Point> pList; //declare our list for lines

        public HorizontalLines(int xLeft,int xRight, int y, char sym)
        {
            pList = new List<Point>(); //create new object of List class
            //Point p1 = new Point(4, 4, '*'); //point 1
            //Point p2 = new Point(5, 4, '*'); //point 2
            //Point p3 = new Point(6, 4, '*'); //point 3

            //pList.Add(p1); //
            //pList.Add(p2); // Adding ours point to the pList
            //pList.Add(p3); //

            for(int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void LineDraw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
