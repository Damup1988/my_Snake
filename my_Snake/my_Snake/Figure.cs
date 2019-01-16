using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Snake
{
    class Figure
    {
        protected List<Point> pList; //declare our list for lines
        // protected - to grant access to the variable fot other classes

        public void LineDraw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
