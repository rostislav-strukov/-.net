using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFigure
{
    class Point
    {
        private int point1;
        private int point2;
        private string side;

        public int Point1 { get { return point2; } }
        public int Point2 { get { return point2; } }
        public string SideName { get { return side; } set { side = value; } }
        public Point() { }
        public Point(int ArgPoint1, int ArgPoint2, string ArgFigureName)
        {
            point1 = ArgPoint1;
            point2 = ArgPoint2;
            SideName = ArgFigureName;
        }
    }
}
