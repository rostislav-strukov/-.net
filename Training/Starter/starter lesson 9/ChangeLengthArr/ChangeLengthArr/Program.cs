using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeLengthArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 3, 4, 5, 7 };

            AddItem(array, 2);
          
        }

        static void AddItem(int[] array, int value)
        {
            int[] newArr = new int[array.Length + 1];

            for (int i = 0; i < array.Length + 1; i++)
            {
                if (i == 0)
                {
                    newArr[i] = value;
                }
                if ((i > 0) && (i <= array.Length))
                {
                    newArr[i] = array[i - 1];
                }
            }

            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
