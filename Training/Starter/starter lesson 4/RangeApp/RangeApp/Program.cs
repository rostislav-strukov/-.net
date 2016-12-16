using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand = 25;

            Range<int> range = new Range<int>(0, 50, false, false);
            range.Contains(operand);
           
            Console.ReadKey();
        }
    }
}
