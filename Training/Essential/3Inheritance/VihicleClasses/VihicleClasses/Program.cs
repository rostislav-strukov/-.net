using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VihicleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane();

            Vehicle vehicle = plane as Vehicle;

            plane.price = 250000;
            plane.countPassengers = 300;
        }
    }
}
