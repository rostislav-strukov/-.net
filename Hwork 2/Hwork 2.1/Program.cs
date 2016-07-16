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

            double _iRadius = Convert.ToDouble(Console.ReadLine());
            double _iPi = 3.14;
            double _iResult;

            _iResult = _iPi * Math.Pow(_iRadius, 2);

            Console.WriteLine("Area of a circle = {0}", _iResult);

            // compute area of a sphere
            _iResult = (4 * _iPi * Math.Pow(_iRadius, 3))/3;

            Console.WriteLine("Area of a sphere = {0}", _iResult);

            // compute area of a rectangle
            Console.Write("Enter width of rectangle mm: ");

            double _iWidth = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height of rectangle mm: ");

            double _iHeight = Convert.ToDouble(Console.ReadLine());

            _iResult = _iWidth * _iHeight;

            Console.WriteLine("Area of a rectangle = {0}", _iResult);

            // compute area of a parallelepiped
            Console.Write("Enter width parallelepiped mm: ");

            double _Width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height parallelepiped mm: ");

            double _Height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter length parallelepiped mm ");

            double _Length = Convert.ToDouble(Console.ReadLine());

            _iResult = _Width * _Height * _Length;

            Console.WriteLine("Area of a parallelepiped mm = {0}", _iResult);
            Console.ReadKey();


        }
    }
}
