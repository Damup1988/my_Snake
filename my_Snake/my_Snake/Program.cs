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
            SetWindowSize(80,25);
            SetBufferSize(82,26);

            //Borders drawing
            HorizontalLines HorAboveLine = new HorizontalLines(0, 78, 0, '#');
            HorizontalLines HorBelowLine = new HorizontalLines(0, 78, 24, '#');
            VerticalLines VerLeftLine = new VerticalLines(0, 24, 0, '#');
            VerticalLines VerRightLine = new VerticalLines(0, 24, 78, '#');

            HorAboveLine.LineDraw();
            HorBelowLine.LineDraw();
            VerLeftLine.LineDraw();
            VerRightLine.LineDraw();

            //Start point drawing
            Point p = new Point(4,5,'*');
            p.Draw();
        }
    }
}