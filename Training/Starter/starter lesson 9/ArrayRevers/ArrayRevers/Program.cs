using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRevers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] repository = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int i = 0;
            Array.Reverse(repository);
            while (i < repository.Length)
            {
                Console.WriteLine(repository[i]);
                i++;
            }
        }
    }
}
