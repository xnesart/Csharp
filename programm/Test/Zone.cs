using System;

namespace programm.Test
{
    public class Zone
    {
        public List<Point> Points { get; set; }

        public Zone()
        {
            Points = new();
        }

        public void AddPoint(Point point)
        {
            Points.Add(point);
        }

        public int GetIndexByPoint(Point point)
        {
            for (int i = 0; i < Points.Count; i++)
            {
                if (point.X == Points[i].X && point.Y == Points[i].Y)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}