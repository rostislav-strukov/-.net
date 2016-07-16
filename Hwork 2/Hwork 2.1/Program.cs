using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            // compute area of a circle
            Console.Write("Enter radius mm: ");

            Double _Radius = Convert.ToDouble(Console.ReadLine());
            Double _Pi = 3.14;
            Double _Result;

            _Result = _Pi * Math.Pow(_Radius, 2);

            Console.WriteLine("Area of a circle = {0}", _Result);

            // compute area of a sphere
            _Result = (4 * _Pi * Math.Pow(_Radius, 3))/3;

            Console.WriteLine("Area of a sphere = {0}", _Result);

            // compute area of a rectangle
            Console.Write("Enter width of rectangle mm: ");

            Double _Width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height of rectangle mm: ");

            Double _Height = Convert.ToDouble(Console.ReadLine());

            _Result = _Width * _Height;

            Console.WriteLine("Area of a rectangle = {0}", _Result);

            // compute area of a parallelepiped
            Console.Write("Enter width parallelepiped mm: ");

            Double Width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height parallelepiped mm: ");

            Double Height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter length parallelepiped mm ");

            Double Length = Convert.ToDouble(Console.ReadLine());

            _Result = _Width * _Height * Length;

            Console.WriteLine("Area of a parallelepiped mm = {0}", _Result);
            Console.ReadKey();


        }
    }
}
