using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Snake
{
    class Walls : Figure
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            //Borders drawing
            HorizontalLines HorAboveLine = new HorizontalLines(0, mapWidth - 2, 0, '#');
            HorizontalLines HorBelowLine = new HorizontalLines(0, mapWidth - 2, mapHeight - 1, '#');
            VerticalLines VerLeftLine = new VerticalLines(0, mapHeight - 1, 0, '#');
            VerticalLines VerRightLine = new VerticalLines(0, mapHeight - 1, mapWidth - 2, '#');

            wallList.Add(HorAboveLine);
            wallList.Add(HorBelowLine);
            wallList.Add(VerLeftLine);
            wallList.Add(VerRightLine);
        }

        //If we hit a wall (checking)
        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        //A method foe walls drawing
        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.LineDraw();
            }
        }
    }
}
