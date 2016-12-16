using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Converter
    {
        public decimal Usd { get; set; }
        public decimal Eur { get; set; }
        public decimal Rub { get; set; }

        public Converter() { }

        public Converter(decimal usd, decimal eur, decimal rub)
        {
            Usd = usd;
            Eur = eur;
            Rub = rub;
        }

        public void Menu()
        {
            Console.WriteLine("If you need convert UAH -> USD enter 1 or USD - UAH enter 2");
            
        }

        //public decimal ConvertUsd()
        //{

        //}

        public decimal ConvertRub(decimal sumUah, decimal sumRub)
        {
            decimal result = 0;
            string switch_on = Console.ReadLine();

            switch (switch_on)
            {
                case "1":
                    result = sumUah * Rub;
                    return result;
                case "2":
                    result = sumRub / Rub;
                    return result;
                default:
                    Console.WriteLine("please enter right number");
                    break;
            }
            return result;
        }

        //public decimal ConvertEur()
        //{
            
        //}
    }
}
