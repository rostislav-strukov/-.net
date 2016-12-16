using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryVariant
{
    class Program
    {
        static void Main(string[] args)
        {
            int countClient = 8;

            int countVariant = 1;

            do
            {
                countVariant *= countClient;

                --countClient;
            } while (countClient > 0);

            Console.WriteLine(countVariant);
        }
    }
}
