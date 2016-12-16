using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserReadOnly
{
    class User
    {
        private string name;
        private uint age;
        private string parol;
        private readonly string date;

        public User() { }

        public User(string ArgName, uint ArgAge, string ArgParol, string ArgDate)
        {
            name = ArgName;
            age = ArgAge;
            parol = ArgParol;
            date = ArgDate;
        }

        public void ShowValue()
        {
            Console.WriteLine(new string('-', 10));
            Console.WriteLine(name);
            Console.WriteLine(new string('-', 10));
            Console.WriteLine(age);
            Console.WriteLine(new string('-', 10));
            Console.WriteLine(parol);
            Console.WriteLine(new string('-', 10));
            Console.WriteLine(date);
            Console.WriteLine(new string('-', 10));
        }
    }
}
