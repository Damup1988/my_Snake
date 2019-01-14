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
            int x1 = 1, y1 = 3;
            char sym1 = '*';
            Draw(x1, y1, sym1);

            int x2 = 3, y2 = 5;
            char sym2 = '#';
            Draw(x2, y2, sym2);


            ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
            SetCursorPosition(x, y);
            WriteLine(sym);
        }
    }
}