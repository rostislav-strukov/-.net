using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLogicandOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            double _iMin = 16.5;
            double _iMax = 18.7;
            double _iResult;

            // operate sum
            _iResult = _iMax + _iMin;

            Console.WriteLine("Variable 1 _iMax {0}", _iMax);
            Console.WriteLine("Variable 2 _iMin {0}", _iMin);
            Console.WriteLine("sum {0}", _iResult);

            // operate substraction
            _iResult = _iMax - _iMin;

            Console.WriteLine("substraction {0}", _iResult);

            //operate multiplate
            _iResult = _iMax * _iMin;

            Console.WriteLine("multiplate {0}", _iResult);

            // operate division with double
            _iResult = _iMax / _iMin;

            Console.WriteLine("division with double {0}", _iResult);

            //operate division with integer
            int a = 7;
            int b = 3;
            int _Result;

            _Result = a / b;

            Console.WriteLine("division with integer {0}", _Result);

            _Result = a % b;

            Console.WriteLine("remineder of division {0}", _Result);

            //operate comparison 

            bool result;

            result = _iMax > _iMin;

            Console.WriteLine("_iMax bigger than _iMin it is {0}",  result);

            result = _iMax < _iMin;

            Console.WriteLine("_iMax smaller than _iMin it is {0}", result);

            result = _iMax >= _iMin;

            Console.WriteLine("_iMax bigger  than _iMin or exactly it is {0}", result);

            result = _iMax <= _iMin;

            Console.WriteLine("_iMax smaller than _iMin or exactly it is {0}", result);

            result = _iMax != _iMin;

            Console.WriteLine("_iMax not exactly _iMin it is {0}", result);

            result = _iMax == _iMin;

            Console.WriteLine("_iMax equaly _iMin it is {0}", result);

            //logic operates

            bool _iValue = true;
            bool _iEmpty = false;
            bool _iTask; 

            _iTask = _iEmpty && _iValue;

            Console.WriteLine("_iValue = true");
            Console.WriteLine("_iEmpty = false");
            Console.WriteLine("_iValue && (and) _iEmty = {0}", _iTask);

            _iTask = _iEmpty || _iValue;

            Console.WriteLine("_iValue || (or) _iEmty = {0}", _iTask);

            _iTask = _iEmpty ^ _iValue;

            Console.WriteLine("_iValue ^ (out - or) _iEmty = {0}", _iTask);
            Console.ReadKey();
        }
    }
}
