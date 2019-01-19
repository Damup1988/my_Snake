using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Snake
{
    class Food
    {
        int x, y; //our params of garden - width and lenth
        char sym; //how our fruit looks like

        //We create an exemplar of Random class
        //We need it as we should create each new apple at new random point
        Random rnd = new Random();

        //It's a constructor
        //Here we get garden size and how an apple looks ($) when we create
        //an object of Food class
        public Food(int x,int y, char sym) 
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        //A method for creation new apples each time when the snake eats
        //Where n and m are new coordinats of new apple
        public Point CreateFood()
        {
            int n = rnd.Next(2, x - 2);
            int m = rnd.Next(2, y - 2);
            return new Point(n, m, sym);
        }
    }
}
