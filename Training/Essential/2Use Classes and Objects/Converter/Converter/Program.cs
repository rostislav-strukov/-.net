using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Converter converter = new Converter();
            CallConverter();
        }

        static void CallConverter()
        {
            Converter converter = new Converter(2, 3, 4);
            string switch_on = Console.ReadLine();

            switch (switch_on)
            {
                case "1":
                    converter.ConvertRub(25, 20);
                    break;
                //default:
            }
        }
    }
}
