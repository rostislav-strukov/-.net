using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine("Создаем доктора");
            Console.WriteLine("Введите тариф доктора");
            decimal _tariff = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите колличество отработанных часов доктора");
            uint _hours = Convert.ToUInt32(Console.ReadLine());
            Doctor doctor = new Doctor(_tariff, _hours);
            Console.WriteLine(new String('-', 40));

            Console.WriteLine(new String('-', 40));
            Console.WriteLine("Создаем доктора психов");
            Console.WriteLine("Введите тариф доктора психов");
            _tariff = Convert.ToDecimal(Console.ReadLine());
            Psychologist doctorPsy = new Psychologist(_tariff);
            Console.WriteLine(new String('-', 40));

            Console.WriteLine(new String('-', 40));
            Console.WriteLine("Создаем сторожа");
            Console.WriteLine("Введите тариф сторожа");
            _tariff = Convert.ToDecimal(Console.ReadLine());
            Security security = new Security(_tariff);
            Console.WriteLine(new String('-', 40));

            Console.WriteLine(new String('-', 40));
            Console.WriteLine("Создаём обычного работника");
            Console.WriteLine("Введите тариф обычного работника");
            _tariff = Convert.ToDecimal(Console.ReadLine());
            SampleWorker sampleWorker = new SampleWorker(_tariff);
            Console.WriteLine(new String('-', 40));

            Console.WriteLine(new String('-', 40));
            Console.WriteLine("Создаём стажёра");
            Console.WriteLine("Привет всем работникам, я стажёр хочу быть .NET Developer'ом");
            Console.WriteLine("Укажите тариф стажёра");
            _tariff = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Укажите количество отработанных часов стажёра: ");
            _hours = Convert.ToUInt32(Console.ReadLine());
            Trainee student = new Trainee(_tariff, _hours);
            Console.WriteLine(new String('-', 40));

            Console.WriteLine(new String('=', 40));
            Console.WriteLine("Создаем бухгалтера");

            Accountant accontant = new Accountant();

            Console.WriteLine($"Зарплата Доктора = {accontant.GetCalculateSalary(doctor)}");
            Console.WriteLine($"Зарплата Доктора психов = {accontant.GetCalculateSalary(doctorPsy)}");
            Console.WriteLine($"Зарплата Обычного работника = {accontant.GetCalculateSalary(sampleWorker)}");
            Console.WriteLine($"Зарплата Охранника = {accontant.GetCalculateSalary(security)}");
            Console.WriteLine($"Зарплата Стажёра = {accontant.GetCalculateSalary(student)}");
            Console.WriteLine(new String('=', 40));


            Console.ReadKey();
        }
    }
}
