using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalc
{
    class Program
    {
        enum Operation { Plus = '+', Minus = '-', Div = '/', Mult = '*', wrongOperation = 0 };
        static void Main(string[] args)
        {
                double _iBuffer = 0;
                double _iOperand = 0;
                Operation curentOperation;
                Console.WriteLine("Please enter number:");

                while (!CheckFigures(Console.ReadLine(), out _iBuffer))
                    Console.WriteLine("Is wrong please enter the number");

                while (true)
                {
                    curentOperation = GetOperation(Console.ReadLine()[0]);

                    if (CheckFigures(Console.ReadLine(), out _iOperand))
                    {
                        switch (curentOperation)
                        {
                            case Operation.Div:
                                _iBuffer /= _iOperand;
                                break;
                            case Operation.Mult:
                                _iBuffer *= _iOperand;
                                break;
                            case Operation.Plus:
                                _iBuffer += _iOperand;
                                break;
                            case Operation.Minus:
                                _iBuffer -= _iOperand;
                                break;
                            case Operation.wrongOperation:
                                return;
                        }
                        Console.WriteLine("rezult: {0}", _iBuffer);
                    }
                    else
                        Console.WriteLine("Please enter number in's not right");
                }
            }
            static Double Plus(Double arr1, Double arr2)
            {
            return arr1 + arr2;
        }
        static Double Minus(Double arr1, Double arr2)
        {
            return arr1 - arr2;
        }
        static Double Div(Double arr1, Double arr2)
        {
            return arr1 / arr2;
        }
        static Double Mult(Double arr1, Double arr2)
        {
            return arr1 * arr2;
        }
        private static bool CheckFigures(string str, out double rez)
        {
            rez = 0;
            return double.TryParse(str, out rez);
        }
        private static Operation GetOperation(char ch)
        {
            if (ch == '/')
            {
                return Operation.Div;
            }
            if (ch == '*')
            {
                return Operation.Mult;
            }
            if (ch == '+')
            {
                return Operation.Plus;
            }
            if (ch == '-')
            {
                return Operation.Minus;
            }
            return Operation.wrongOperation;
        }
    }
}
