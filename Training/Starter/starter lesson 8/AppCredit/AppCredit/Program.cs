using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter sum of payment");
            decimal payment = Convert.ToDecimal(Console.ReadLine());
            int countPayment = Convert.ToInt32(Console.ReadLine());
            decimal credit = 700;

            while (payment < credit)
            {
                CalculateCredit(ref payment, ref countPayment);

                Console.WriteLine("Debet is {0} = ", credit - payment);
            }

            if (payment == credit)
            {
                Console.WriteLine("Debet is done");
            }
            if (payment > credit)
            {
                Console.WriteLine("Overpayment = {0}", payment - credit);
            }
 
            Console.ReadLine();
        }
        static void CalculateCredit(ref decimal payment, ref int countPayment)
        {
            if (countPayment > 1)
            {
                payment = Convert.ToDecimal(Console.ReadLine());
                countPayment = Convert.ToInt32(Console.ReadLine());
                payment += payment;
            }
        }

    }
}
