using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace my_Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
            WriteLine("A new point creating"); // It's an empty contsructor
        }

        public Point(int _x, int _y, char _sym) // It's a contsructor
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Draw()
        {
            SetCursorPosition(x, y);
            WriteLine(sym);
        } //Our draw function
    }
}