using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";

            char[] chr = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                chr[i] = str[i]; 

                Console.WriteLine("Char: {0} dec {1:D}, hex {2:X}", chr[i], (int)chr[i], (int)chr[i]);
            }

            Console.ReadKey();
        }
    }
}
