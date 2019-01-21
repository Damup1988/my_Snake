using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Snake
{
    class TheSnake : Figure
    {
        Directions _direct; //The way where the snake moves

        public TheSnake(Point tail,int snake_lenght,Directions direct)// It's a constructor
        {
            _direct = direct;
            pList = new List<Point>(); // New list for the snake
            for(int i=0;i<=snake_lenght;i++)
            {
                Point p = new Point(tail);
                p.Move(i,_direct);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First(); // To find out where head is
            pList.Remove(tail); //We should always delete the tail while the snake is moving
            Point head = GetNextPoint(); //We found out the next point of the snake
            pList.Add(head); //Add to the list a point where the head is now

            tail.Clear(); 
            head.Draw();
        }

        //A method to check if the snake meets an apple
        internal bool Eat(Point apple)
        {
            Point head = GetNextPoint();
            if (head.IsHit(apple))
            {
                apple.sym = head.sym;
                pList.Add(apple);
                return true;
            }
            else
                return false;
        }

        //We found out the next point of the snake because
        //we should know her nex step that depends on her direction and size of the step
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1,_direct);
            return nextPoint;
        }

        //A method to check if the snake hits his tail
        internal bool IsHitTail()
        {
            var head = pList.Last();
            for(int i=0; i <= pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }

        public void ButtonIsPressed(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow && _direct != Directions.RIGHT)
                _direct = Directions.LEFT;
            if (key == ConsoleKey.RightArrow && _direct != Directions.LEFT)
                _direct = Directions.RIGHT;
            if (key == ConsoleKey.UpArrow && _direct != Directions.DOWN)
                _direct = Directions.UP;
            if (key == ConsoleKey.DownArrow && _direct != Directions.UP)
                _direct = Directions.DOWN;
        }
    }
}
