using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            TheSnake snake = new TheSnake(p,7,Directions.RIGHT);
            snake.LineDraw();

            //we create an exemplar of Food - our garden, where our snake lives and eats
            //We send size of the garden 80x25 and some symbol that describes an apple ($)
            Food apple_garden = new Food(80, 25, '$');
            Point apple = apple_garden.CreateFood();
            apple.Draw();

            while (true)
            {
                if(snake.Eat(apple))
                {
                    apple = apple_garden.CreateFood();
                    apple.Draw();
                    snake.LineDraw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (KeyAvailable)
                {
                    ConsoleKeyInfo key = ReadKey(true);
                    snake.ButtonIsPressed(key.Key);
                }
            }
        }
    }
}