using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWorks
{
    class Psychologist : BaseWorker
    {
        private const uint QUONTATY_PACIENT = 8; // общее колличество пациентов
        private const decimal COEF_BONUS = 1.2m; // коефициент премии за каждого дополнительного пациента

        private uint _additionalPacient = 0; // дополнительные пациенты
        private decimal _additionalTariff = 0; // тариф за дополнительного пациента
        private decimal _bunusPayment = 0; // общая премия за дополнительных пациентов

        public Psychologist(decimal Tariff) : base(Tariff)
        {
            GetPacient();
        }
        public override decimal Salary { get { return base.Salary; } }

        private void GetPacient()
        {
            Console.WriteLine($"Норма пациентов за день: {QUONTATY_PACIENT} ;");
            Console.WriteLine("Укажите дополнительных пациентов: ");
            _additionalPacient = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Теперь у Вас {_additionalPacient} дополнительных пациенти \n Общее колличество пациентов составляет {_additionalPacient + QUONTATY_PACIENT}");
        }
        public override decimal CalculateSalary()
        {
            _additionalTariff = Tariff * COEF_BONUS;
            _bunusPayment = _additionalPacient * _additionalTariff;
            return base.CalculateSalary() + _bunusPayment;
        }

    }
}
