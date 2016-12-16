using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] random = new int[] { 1, -2, 3, 4, -8, -15, 20 };
            int result = 0;
            int average = 0;

            Console.WriteLine(random.Max());
            Console.WriteLine(random.Min());

            for (int i = 0; i < random.Length; i++)
            {
                result += random[i];
                Console.WriteLine(result);

                if (random[i] < 0)                {
                    Console.WriteLine(random[i]);
                }
            }


            average = result / random.Length;

            Console.WriteLine(average);

        }
    }
}
