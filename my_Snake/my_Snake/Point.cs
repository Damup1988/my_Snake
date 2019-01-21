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

        public Point(int x, int y, char sym) //It's a contsructor for 3 params
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point(Point p) //It's a constructor for new point
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Draw()
        {
            try
            {
                SetCursorPosition(x, y);
                WriteLine(sym);
            }
            catch (ArgumentOutOfRangeException)
            {
                SetCursorPosition(40,12);
                WriteLine("Game over!");
            }
        } //Our draw function

        //Remove our start point
        internal void Clear()
        {
            sym = ' ';
            Draw();
        }

        //A method to check if we meet an apple on our way
        //We compare our current point's coordinats with the apple's coordinats
        //So if we meet an apple the metod returns true
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Move(int step, Directions dir) //Our move function
        {
            if (dir == Directions.LEFT)
            {
                x = x - step;
            }
            if (dir == Directions.UP)
            {
                y = y - step;
            }
            if (dir == Directions.DOWN)
            {
                y = y + step;
            }
            if (dir == Directions.RIGHT)
            {
                x = x + step;
            }
        }
    }
}