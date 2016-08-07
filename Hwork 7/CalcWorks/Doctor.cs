using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWorks
{
    class Doctor : BaseWorker
    {
        private const uint CURED_COEF = 10; // коєфициент премии за 1 вылеченного

        private uint _totalPacient = 0; // общее кол-во пациентов
        private uint _curedPacient = 0; // колличество вылеченных пациентов

        protected uint TotalPacient { get { return _totalPacient; } set { _totalPacient = value; } }
        protected uint CuredPacient { get { return _curedPacient; } set { _curedPacient = value; } }

        public Doctor(decimal Tariff, uint WorekedHours) : base(Tariff, WorekedHours)
        {
            SetCuredPacient();
            SetTotalPacient();
        }
        private void SetTotalPacient()
        {
            Console.WriteLine("Укажите общее колличество пациентов: ");
            _totalPacient = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Общее колличество пациентов {_totalPacient}");
        }

        private void SetCuredPacient()
        {
            Console.WriteLine("Укажите колличество вылеченных пациентов: ");
            _curedPacient = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Общее колличество пациентов {_curedPacient}");
        }

        public decimal GetCuredPacient()
        {
            return _curedPacient * CURED_COEF;
        }

        public override decimal CalculateSalary()
        {
            return base.CalculateSalary() + GetCuredPacient();
        }
        
    }
}
