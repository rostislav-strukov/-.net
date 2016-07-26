using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I'm console calculate if you need calculate operation please enter number do you need \n1. Multiply (*) \n2. Division (/) \n3. Sum (+) \n4. Subtraction (-) \n5. Remineder of division (%) \n6. Powering");
            string _iVal = Console.ReadLine();

            switch (_iVal)
            {
                case "1":
                    Console.WriteLine("Please enter first multiplier");
                    double _iMultiplierFirst = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter second multiplier");
                    double _iMultiplierSecond = Convert.ToDouble(Console.ReadLine());
                    Multiply(_iMultiplierFirst, _iMultiplierSecond);
                    Console.WriteLine("Result of Product: " + ' ' + Multiply(_iMultiplierFirst, _iMultiplierSecond));
                    break;
                //case 2:
                //case 3:
                //case 4:
                //case 5:
                //case 6:
                default:
                    break;
            }
            Console.ReadKey();
        }
        static double Multiply(double _iMultiplierFirst, double _iMultiplierSecond)
        {
            double _iMultiply = _iMultiplierFirst * _iMultiplierSecond;
            return _iMultiply;
        }

        static string Control(string _iVal)
        {
            foreach (char i in _iVal)
            {
                if (!Char.IsDigit(_iVal[i]))
                {
                    continue;
                } else
                {
                    Console.WriteLine("Please");
                }
            }
            
        }
    }
}
