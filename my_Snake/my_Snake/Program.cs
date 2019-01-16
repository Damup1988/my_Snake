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
            Point point1 = new Point(1, 3, '*');
            point1.Draw();

            Point point2 = new Point(3, 5, '#');

            Point point3 = new Point(4, 6, '!');
            Point point4 = new Point(5, 7, '@');
            Point point5 = new Point(6, 8, '#');
            Point point6 = new Point(7, 9, '$');

            point2.Draw();

            List<int> numList = new List<int>();
            numList.Add(2);
            numList.Add(5);
            numList.Add(7);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)
            {
                WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(point1);
            pList.Add(point2);
            pList.Add(point3);
            pList.Add(point4);
            pList.Add(point5);
            pList.Add(point6);

            List<char> charList = new List<char>();
            charList.Add('*');
            charList.Add('#');
            charList.Add('$');
            charList.Add('%');

            char sym1 = charList[0];
            char sym2 = charList[1];
            char sym3 = charList[2];
            char sym4 = charList[3];

            foreach (int j in charList)
            {
                WriteLine(j);
            }

            ReadLine();
        }
    }
}