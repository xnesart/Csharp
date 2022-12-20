using System;

namespace programm.Test
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(int value)
        {
            X = value;
            Y = value;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}

