using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diapason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check please");
            int check =Convert.ToInt32(Console.ReadLine());

            CheckDiapason(check);

            Console.ReadKey();
        }

        static void CheckDiapason(int check)
        {
            switch (check)
            {
                case 1 - 10:
                    Console.WriteLine("You are right");
                    break;
            }
        }
    }
}
