using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 5;
            //MyMethod(i);
            //Console.WriteLine(i);
            /*factorial(5);*/

            //char[,] h = new char[2, 4] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            //char[,] h = new char[2, 4] { { 'a', 'b', 'c', 'd' }, { 'e', 'f', 'g', 'h' } };
            //char[,] h = new char[2, 4] { { 'a', 'b' }, { 'c', 'd' }, { 'e', 'f' }, { 'g', 'h' } };
            //char[,] h = new char[2, 4] { { 'a', 'b', 'c', 'd' 'e', 'f', 'g', 'h' } };

            //int[,] array = new int[4][5];
            //Console.WriteLine(array.Length);
            //int[,] array = new int[4, 5];
            //Console.WriteLine(array.Length);
            //int operand = 3;
            //int result = Method(out operand);
            //Console.WriteLine("{0}; {1};", operand, result);
        }

        static int Method(out int a) { a = 2; return a * 2; }

        //static void MyMethod(int i)
        //{
        //    i = i - 1;
        //    Console.Write(i);
        //    if (i > 0)

        //        MyMethod(i);

        //    //Console.Write(i);
        //}

        //static int factorial(int i)
        //{
        //    int result;

        //    if (i == 1)
        //        return 1;
        //    result = factorial(i - 1) * i;
        //    Console.WriteLine(result);
        //    return result;
        //}

    }
}
