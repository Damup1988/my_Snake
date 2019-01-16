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

        public void LineDraw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
