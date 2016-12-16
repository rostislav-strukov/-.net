using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterInheritens
{
    class PrintRed : Printer
    {
        public new void Print(string word)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(word);
        }
    }
}
