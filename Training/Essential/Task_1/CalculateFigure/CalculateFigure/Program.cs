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
            Point A = new Point(-2, 4, "side1");
            Point B = new Point(5, 4, "side2");
            Figure figure = new Figure(A, B);

            figure.PerimetrCalculator();

            Console.ReadKey();
        }
    }
}
