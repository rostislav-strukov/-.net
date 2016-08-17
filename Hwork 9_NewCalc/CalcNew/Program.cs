using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcNew
{

    public delegate decimal CalculateEvent(decimal _operand1, decimal _operand2);

    public class Calculate
    {
        private decimal _operand1 = 0;
        private decimal _operand2 = 0;

        public decimal Operand1 { get { return _operand1; } set { _operand1 = value; } }
        public decimal Operand2 { get { return _operand2; } set { _operand2 = value; } }
        

        public event CalculateEvent calculateEvent;

      
        public void FigureEvent()
        {
            if (calculateEvent != null)
            {
                calculateEvent.Invoke(_operand1, _operand2);
            }
        }

        public void GetCalculate()
        {
            while (true)
            {
                Console.WriteLine("Please choose operation:\r\n 1 - Multiply - (*)\r\n 2 - Division - (/)\r\n 3 - Sum (+)\r\n 4 - Substraction (-)");

                string _operation = Console.ReadLine();

                switch (_operation)
                {
                    case "1":
                        calculateEvent += Multiply;
                        FigureEvent();
                        break;
                    case "2":
                        calculateEvent += Division;
                        FigureEvent();
                        break;
                    case "3":
                        calculateEvent += Sum;
                        FigureEvent();
                        break;
                    case "4":
                        calculateEvent += Substraction;
                        FigureEvent();
                        break;
                    default:
                        Console.WriteLine("You didn't choose, please try again!");
                        return;
                }
            }
        }

        static private decimal Multiply(decimal _operand1, decimal _operand2)
        {
            Console.WriteLine($"RESULT MULTIPLY = { _operand1 * _operand2 }");

            return _operand1 * _operand2;
        }
        static private decimal Division(decimal _operand1, decimal _operand2)
        {
            Console.WriteLine($"RESULT DIVISION = { _operand1 / _operand2 }");

            return _operand1 / _operand1;
        }
        static private decimal Sum(decimal _operand1, decimal _operand2)
        {
            Console.WriteLine($"RESULT SUM = { _operand1 + _operand2 }");

            return _operand1 + _operand2;
        }
        static private decimal Substraction(decimal _operand1, decimal _operand2)
        {
            Console.WriteLine($"RESULT SUBSTRACTION = { _operand1 - _operand2 }");

            return _operand2 - _operand2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();

            Console.WriteLine("Hello! Please Enter first number:");
            calc.Operand1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hello! Please Enter second number:");
            calc.Operand2 = Convert.ToDecimal(Console.ReadLine());

            calc.GetCalculate();

            Console.ReadKey();
        }
    }
}