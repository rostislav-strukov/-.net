using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWorks
{
    class Security : BaseWorker
    {
        private const uint DAY_COEF = 2; // коефициент тарифа сверхурочных часов
        private const uint NIGHT_COEF = 3; // коефициент за ночные
        private const uint LIMIT_HOURS = 8; // лимит отработанных часов за день

        private uint _additionalHoursDay = 0; // дневные сверхурочные часы
        private uint _additionalHoursNight = 0; // ночные сверхурочные чассы
        private decimal _additionalTariffDay = 0; //тариф за дневные сверхурочные
        private decimal _additionalTariffNight = 0; //тариф за ночные сверхурочные
        private decimal _bonusPayment = 0; // общая премия

        public Security(decimal Tariff) : base(Tariff)
        {
            GetSecurity();
        }
        public void GetSecurity()
        {
            Console.WriteLine($"Лимит отработанных часов за день: {LIMIT_HOURS} ");
            Console.WriteLine("Введите дополнительные чассы переработки дневные для охраника");
            _additionalHoursDay = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Введите дополнительные чассы переработки ночные для охраника");
            _additionalHoursNight = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Колличество дневных часов = {_additionalHoursDay}, колличество ночных чассов {_additionalHoursNight};");
            Console.WriteLine($"Общее колличество часов {LIMIT_HOURS + _additionalHoursDay + _additionalHoursNight};");
        }
        public override decimal CalculateSalary()
        {
            _additionalTariffDay = Tariff * DAY_COEF;
            _additionalTariffNight = Tariff * NIGHT_COEF;
            _bonusPayment = (_additionalTariffDay * _additionalHoursDay) + (_additionalHoursNight * _additionalTariffNight);
            return base.CalculateSalary() + _bonusPayment;
        }
    }
}
