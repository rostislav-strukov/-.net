using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWorks
{
    sealed class Trainee : BaseWorker
    {
        private const float BONUS_HOURS = 1.5f;

        private decimal _bonusSalary = 0;

        public Trainee(decimal tariff, uint _workedHours) : base(tariff, _workedHours) { }
        public override decimal CalculateSalary()
        {
            _bonusSalary = Tariff * (decimal)BONUS_HOURS;
            return base.CalculateSalary() + _bonusSalary;
        }
       
    }
}