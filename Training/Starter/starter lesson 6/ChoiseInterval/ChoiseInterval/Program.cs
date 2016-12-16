using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiseInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 18;
            int result = 0;

            for (int i = a + 1; i < b; i++)
            {
                result += i;         
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
