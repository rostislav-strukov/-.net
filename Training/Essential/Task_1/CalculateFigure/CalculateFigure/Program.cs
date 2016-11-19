using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure();
            Point pn = new Point();

            pn.Side1 = 15;
            pn.Side2 = 10;

            Point pb = new Point();

            pb.Side1 = 8;
            pb.Side1 = 10;

            figure.PerimetrCalculator();
            figure.LengthSide(pn, pb);

            Console.ReadKey();

        }
    }
}
