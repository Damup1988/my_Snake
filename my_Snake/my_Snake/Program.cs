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
            //Windows size
            SetWindowSize(80,25);
            SetBufferSize(82,26);

            //Borders drawing
            Walls walls = new Walls(78,23);
            walls.Draw();

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
                //We check if the snake hits walls or himself
                if(walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                //We check if the snake meets an apple
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

                //We check if a player presses a button (up,down,left,right)
                if (KeyAvailable)
                {
                    ConsoleKeyInfo key = ReadKey(true);
                    snake.ButtonIsPressed(key.Key);
                }
            }
        }
    }
}