using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWorks
{
    class BaseWorker : AEmployee
    {
        private uint _worekedHours = 0;
        private decimal _tariff = 0;
        private decimal _salary = 0;
        private uint worekedHours;

        public BaseWorker(decimal tariff)
        {
            Tariff = tariff;
        }

        public BaseWorker(decimal tariff, uint worekedHours) : this(tariff)
        {
            this.worekedHours = worekedHours;
        }

        public override decimal Salary
        { get { return CalculateSalary(); } }

        public override decimal Tariff
        { get { return _tariff; } set { _tariff = value; } }

        public override uint WorkedHours
        { get { return _worekedHours; } set { _worekedHours = value; } }

        public override decimal CalculateSalary()
        {
            _salary = WorkedHours * Tariff;

            return _salary;
        }
    }
}
