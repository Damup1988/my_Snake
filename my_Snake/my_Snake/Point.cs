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
            WriteLine("A new point creating"); //It's an empty contsructor
        }

        public Point(int _x, int _y, char _sym) //It's a contsructor for 3 params
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p) //It's a constructor for one param
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Draw()
        {
            SetCursorPosition(x, y);
            WriteLine(sym);
        } //Our draw function

        public void Move(int step, Directions dir) //Our move function
        {
            if (dir == Directions.LEFT)
            {
                x = x - step;
            }
            if (dir == Directions.UP)
            {
                y = y + step;
            }
            if (dir == Directions.DOWN)
            {
                y = y - step;
            }
            if (dir == Directions.RIGHT)
            {
                x = x + step;
            }
        }
    }
}