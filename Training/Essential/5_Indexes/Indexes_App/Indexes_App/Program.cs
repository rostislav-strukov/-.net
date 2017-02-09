using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexes_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 30, 8, 3, 6, 5, 0, 2, 6, 4, 9, 10, 8, 20, -1, 25, -2, 2, 4, 5, 8 };

            int max = array[0];
            int min = max;

            //int min = 
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    
                }
                if (array[i] < min)
                {
                    min = array[i];
                    
                }
               
            }
            Console.WriteLine("Min " + min);
            Console.WriteLine("Max " + max);
            Console.ReadLine();
        }
    }
}
