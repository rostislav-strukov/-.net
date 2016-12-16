using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterInheritens
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new PrintRed();
            
            printer.Print("Hello");
            printer.PrintTest();

            PrintRed printer1 = new PrintRed();
            Printer pr = (Printer)printer1;

            pr.Print("wevc");
        }
    }
}