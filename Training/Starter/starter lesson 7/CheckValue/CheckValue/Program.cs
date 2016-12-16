using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer value:");
            int enterValue = Convert.ToInt32(Console.ReadLine());

            ChekPosNeg(enterValue);
            CheckSimpleValue(enterValue);

            Console.ReadKey();
        }

        static void ChekPosNeg(int enterValue)
        {
            if (enterValue > 0)
                Console.WriteLine("Positive Value");
            else
                Console.WriteLine("Negative value");
        }

        static void CheckSimpleValue(int enterValue)
        {
            string name = enterValue % 2 != 0 ? "Simple Value" : "Complex Value";

            Console.WriteLine(name);
        }
    }
}
