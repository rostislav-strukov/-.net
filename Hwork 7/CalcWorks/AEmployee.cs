using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWorks
{
    public abstract class AEmployee
    {
        private uint _worekedHours;
        private decimal _tariff;
        private decimal _salary;

        public abstract uint WorkedHours { get; set; }
        public abstract decimal Tariff { get; set; }
        public abstract decimal Salary { get; }
        public abstract decimal CalculateSalary();
    }
}
