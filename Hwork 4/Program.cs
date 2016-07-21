using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalc
{
    class Program
    {
        // создаём операцию перечесления для удобства перебора методов
        enum Operation { wrongOperation, Multiply = '*', Division = '/', Sum = '+', Substraction = '-' };

        static void Main(string[] args)
        {
            double _preOperand = 0;
            double _postOperand = 0;

            Operation _signOperation;

            Console.WriteLine("Please enter the number: ");

            while (!CheckOperation(Console.ReadLine(), out _preOperand))
            {
                Console.WriteLine("Wrong symbol, please enter the number");
            }

            while (true)
            {
                Console.WriteLine("Please enter operation would will you do (+ - / *)");
                _signOperation = GetSign(Console.ReadLine()[0]);

                if (CheckOperation(Console.ReadLine(), out _preOperand))
                {
                    switch (_signOperation)
                    {
                        case Operation.Division:
                            _preOperand /= _postOperand;
                            break;
                        case Operation.Multiply:
                            _preOperand *= _postOperand;
                            break;
                        case Operation.Substraction:
                            _preOperand -= _postOperand;
                            break;
                        case Operation.Sum:
                            _preOperand += _postOperand;
                            break;
                        default:
                            Console.WriteLine("Wrong Operation");
                            return;
                    }
                    Console.WriteLine("You are great, result is {0}", _preOperand);
                }
                else
                {
                    Console.WriteLine("Is wrong please enter the number");
                }
            }
        }
        private static bool CheckOperation(string _iSign, out double _iResult)
        {
            _iResult = 0;
            return double.TryParse(_iSign, out _iResult);
        }
        private double Multiply(double _val1, double _val2)
        {
            return _val1 * _val2;
        }
        private double Division(double _val1, double _val2)
        {
            return _val1 / _val2;
        }
        private double Sum(double _val1, double _val2)
        {
            return _val1 + _val2;
        }
        private double Substraction(double _val1, double _val2)
        {
            return _val1 - _val2;
        }

        private static Operation GetSign(char _iSign)
        {
            if (_iSign == '/')
            {
                return Operation.Division;
            }
            if (_iSign == '*')
            {
                return Operation.Multiply;
            }
            if (_iSign == '+')
            {
                return Operation.Sum;
            }
            if (_iSign == '-')
            {
                return Operation.Substraction;
            }
            return Operation.wrongOperation;
        }
    }
}
