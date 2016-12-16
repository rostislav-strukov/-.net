using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 5;

            Factorial(count);
        }

        static int Factorial(int count)
        {
            int factorial;

            if (count <= 0)
                return 1;

            factorial = count * Factorial(count - 1);

            Console.WriteLine(factorial);

            return factorial;
        }
    }
}
