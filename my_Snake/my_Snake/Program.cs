using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace my_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 3, '*');
            point1.Draw();

            Point point2 = new Point(3, 5, '#');
            point2.Draw();

            List<Point> pList = new List<Point>();
            pList.Add(point1);
            pList.Add(point2);

            HorizontalLines Hline1 = new HorizontalLines(5, 10, 8, '#');
            Hline1.LineDraw();

            VerticalLines Vline1 = new VerticalLines(5, 10, 15, '#');
            Vline1.LineDraw();

            ReadLine();
        }
    }
}