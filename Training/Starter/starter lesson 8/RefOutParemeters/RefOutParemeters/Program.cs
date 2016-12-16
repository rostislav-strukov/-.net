using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutParemeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter operand1");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operand2");
            int operand2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operand3");
            int operand3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----");
            int sum = Calculate(ref operand1, ref operand2, ref operand3);

            Console.WriteLine(operand1);
            Console.WriteLine(operand2);
            Console.WriteLine(operand3);
            Console.WriteLine("----");
            Console.WriteLine(sum);

            Console.ReadKey();
        }

        static int Calculate(ref int operand1, ref int operand2, ref int operand3)
        {
            operand1 /= 5;
            operand2 /= 5;
            operand3 /= 5;

            int sum = operand1 + operand2 + operand3;
            return sum;
        }
    }
}
