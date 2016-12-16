using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] revArray = new int[] { 1, 2, 3, 4, 5, 6, 10, 8, 2 };

            //Array result = Reverce(revArray);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            SubArray(revArray, 2, 15);
        }

        static Array Reverce(int[] revArray)
        {
            int start;

            for (int i = 0, j = revArray.Length - 1; i < j; i++, j--)
            {
                start = revArray[i];
                revArray[i] = revArray[j];
                revArray[j] = start;
                Console.WriteLine(revArray[i]);
            }
            
            return revArray;
        }

        static int[] SubArray(int[] revArray, int index, int count)
        {
            int[] destArr = new int[count];

            int j = 0;

            for (int i = 0; i < destArr.Length; i++)
            {
                if (revArray.Length > index)
                {
                    destArr[j] = revArray[index];
                    Console.WriteLine(destArr[j]);
                } else
                {
                    destArr[j] = 1;
                }
                index++;
                j++;
            }
            Console.WriteLine("-----");
            foreach (var item in destArr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----");
            return destArr;          
        }
    }
}
