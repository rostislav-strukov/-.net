using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFigure
{
    class Figure
    {
        double length = 0;
        double perimetr = 0;

        Point A;
        Point B;
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            A = new Point(-2, 4, "side1");
            B = new Point(5, 4, "side2");
            C = new Point(9, 2, "side3");
            D = new Point(9, -2, "side4");
            E = new Point(-3, -4, "side5");
        }

        public Figure()
        {
            //A = new Point();
        }

        public Figure(Point A)
        {
            A = A;
        }

        //public double LengthSide(Point A, Point B)
        //{
        //    _dLength = (A.Side1 * 3) + (A.Side2 * 3);

        //    Console.WriteLine("Lingth Figure: {0}", _dLength);

        //    return _dLength;
        //}

        public void PerimetrCalculator()
        {
            perimetr = Math.Sqrt(Math.Pow((A.Point1 - B.Point2), 2) + Math.Pow((A.Point2 + B.Point2), 2));

            Console.WriteLine(perimetr);
        }
    }
}
