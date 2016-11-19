using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWorks
{
    public class Accountant
    {
        public Accountant()
        {
            Console.WriteLine("Привет я бухгалтер, готов к работе!");
        }

        public decimal GetCalculateSalary(AEmployee worker)
        {
            if (worker is Doctor)
            {
                worker = worker as Doctor;

            }
            if (worker is SampleWorker)
            {
                worker = worker as SampleWorker;

            }
            if (worker is Psychologist)
            {
                worker = worker as Psychologist;

            }
            if (worker is Security)
            {
                worker = worker as Security;

            }
            return worker.Salary;
        }
    }
}
