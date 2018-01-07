using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yDown, int yUp, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yDown; y <= yUp; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
