using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public double Area { get; private set; }

        public double Perimetr { get; private set; }

        public Rectangle() { }
        public Rectangle(double _Argside1, double _Argside2)
        {
            Side1 = _Argside1;
            Side2 = _Argside2;
        }

        public double AreaCalc(double _Argside1, double _Argside2)
        {
            return Area = _Argside1 * _Argside2;
        }

        public double PerimetrCalc (double _Argside1, double _Argside2)
        {
            return Perimetr = _Argside1 + _Argside2;
        }
    }
}
