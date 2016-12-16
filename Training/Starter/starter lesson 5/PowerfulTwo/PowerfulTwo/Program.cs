using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerfulTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = CheckValue(8);
            Console.WriteLine(check);
        }

        static bool CheckValue(int a)
        {
            return /*a > 0 &&*/ (a & (a - 1)) == 0;
        }
    }
}
