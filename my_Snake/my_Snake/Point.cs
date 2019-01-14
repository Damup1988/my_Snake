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

        public void Draw()
        {
            SetCursorPosition(x, y);
            WriteLine(sym);
        }
    }
}