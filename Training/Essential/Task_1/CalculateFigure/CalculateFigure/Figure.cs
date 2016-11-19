using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFigure
{
    class Figure
    {
        double _dLength = 0;
        double _dPerimetr = 0;

        Point A = null;
        Point B = null;
        public Figure(Point A, Point B)
        {
            A = new Point();
            B = new Point();
        }

        public Figure()
        {
            A = new Point();
        }

        public double LengthSide(Point A, Point B)
        {
            _dLength = (A.Side1 * 3) + (A.Side2 * 3);

            Console.WriteLine("Lingth Figure: {0}", _dLength);

            return _dLength;
        }

        public void PerimetrCalculator()
        {
            _dPerimetr = A.Side1 * A.Side2;

            Console.WriteLine($"{A.FigureName} {_dPerimetr}");
        }
    }
}
