using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            rectangle.Side1 = 10.258;
            rectangle.Side2 = 25.359;

            rectangle.AreaCalc(rectangle.Side1, rectangle.Side2);
            rectangle.PerimetrCalc(rectangle.Side1, rectangle.Side2);

            Console.WriteLine(rectangle.AreaCalc(rectangle.Side1, rectangle.Side2));
            Console.WriteLine(rectangle.PerimetrCalc(rectangle.Side1, rectangle.Side2));

            Console.ReadKey();
        }
    }
}
