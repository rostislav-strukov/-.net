using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AppLiambda
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            myClass.GetValue();

            Console.ReadKey();
        }
    }

    public delegate void MyDelegate();

    class MyClass
    {
        MyDelegate myDelegate;

        private string _enterValue = null;
        private string _chek = null;
        private double _number = 0;
        private double _numberPow = 0;

        //public string EnterValue { get { return _enterValue; } set { _enterValue = value; } }
        //public string Check { get { return _chek; } set { _chek = value; } }
        //public double Number { get { return _number; } set { _number = value; } }
        //public double NumberPow { get { return _numberPow; } set { _numberPow = value; } }


        public void GetValue()
        {
            Console.WriteLine("Please enter the text or number");
            _enterValue = Console.ReadLine();
            while (true)
            {
                if (!Double.TryParse(_enterValue, out _number))
                {
                    Console.WriteLine("Please enter 1 if you write value in file or enter 2 on screen");
                    _chek = Console.ReadLine();
                    switch (_chek)
                    {
                        case "1":
                            myDelegate = delegate { File.WriteAllText(@"D:\-.net\Hwork 10_Liambda\file\Dictionary.txt", _enterValue); };
                            myDelegate();
                            Console.WriteLine("Text wrote in file");
                            break;
                        case "2":
                            myDelegate = delegate { Console.WriteLine($"You are write ({_enterValue})"); };
                            myDelegate();
                            break;
                        default:
                            Console.WriteLine("Please try again 1 or 2");
                            return;
                    }
                }
                else if (Double.TryParse(_enterValue, out _number))
                {
                    _numberPow = Math.Pow(_number, 2);
                    Console.WriteLine("Please enter 1 if you write in file or enter 2 on screen");
                    _chek = Console.ReadLine();
                    switch (_chek)
                    {
                        case "1":
                            myDelegate = delegate { File.WriteAllText(@"D:\-.net\Hwork 10_Liambda\file\Dictionary.txt", Convert.ToString(_numberPow)); };
                            myDelegate();
                            Console.WriteLine("Text wrote in file");
                            break;
                        case "2":
                            myDelegate = delegate { Console.WriteLine($"You are write number ({ _numberPow})"); };
                            myDelegate();
                            break;
                        default:
                            Console.WriteLine("Please try again 1 or 2");
                            return;
                    }
                } else
                {
                    Console.WriteLine("Please write text or number");
                    Console.ReadKey();
                    GetValue();
                }
            }
        }
    }
}
