using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWorks
{
    class SampleWorker : BaseWorker
    {
        private const uint ADD_COEF = 2; // коефициент тарифа сверхурочных часов
        private const uint LIMIT_HOURS = 8; // лимит отработанных часов

        private uint _additionalHours = 0; // сверхурочные часы
        private decimal _additionalTariff = 0; //тариф сверхурочные
        private decimal _bonusPayment = 0; // общая премия

        public SampleWorker(decimal Tariff) : base(Tariff)
        {
            GetSampleWorker();
        }
        public void GetSampleWorker()
        {
            Console.WriteLine($"Лимит отработанных часов: {LIMIT_HOURS} ");
            Console.WriteLine("Введите дополнительные чассы переработки для простого работника");
            _additionalHours = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Колличество часов (лимит работы)= {LIMIT_HOURS}");
            Console.WriteLine($"Общее колличество часов {LIMIT_HOURS + _additionalHours};");
        }
        public override decimal CalculateSalary()
        {
            _additionalTariff = Tariff * ADD_COEF;
            _bonusPayment = _additionalTariff * _additionalHours;
            return base.CalculateSalary() + _bonusPayment;
        }
    }
}
