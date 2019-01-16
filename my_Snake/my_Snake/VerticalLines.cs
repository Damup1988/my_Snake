using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Snake
{
    class VerticalLines
    {
        List<Point> pList; //declare our list for lines

        public VerticalLines(int yBelow, int yAbove, int x, char sym)
        {
            pList = new List<Point>(); //create new object of List class
           
            for (int y= yBelow; y <= yAbove; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void LineDraw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
