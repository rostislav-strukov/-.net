using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ининциализируем переменные
            string _iName;

            Console.WriteLine("Hello, please enter you name");

            _iName = Console.ReadLine();

            Console.WriteLine(_iName + ' ' + "please choose do you wont to by");
            

            Product Tablet = new Product();

            Tablet.Id = 1;
            Tablet.GetName = "Tablet";
            Tablet.Prise = 100.25m;

            Product Tv = new Product();

            Tv.Id = 2;
            Tv.GetName = "TV";
            Tv.Prise = 150.85m;

            Product Phone = new Product();

            Phone.Id = 3;
            Phone.GetName = "Phone";
            Phone.Prise = 120.65m;

            Product Mouse = new Product();

            Mouse.Id = 4;
            Mouse.GetName = "Mouse";
            Mouse.Prise = 25.78m;

            Product DeskTop = new Product();

            DeskTop.Id = 5;
            DeskTop.GetName = "DeskTop";
            DeskTop.Prise = 250.89m;

            Console.WriteLine("--------------- Products ---------------");
            Console.WriteLine("{0}.{1}{2}", Tablet.Id, Tablet.GetName, Tablet.Prise);
            Console.WriteLine("{0}.{1}{2}", Phone.Id, Phone.GetName, Phone.Prise);
            Console.WriteLine("{0}.{1}{2}", Mouse.Id, Mouse.GetName, Mouse.Prise);
            Console.WriteLine("{0}.{1}{2}", Tv.Id, Tv.GetName, Tv.Prise);
            Console.WriteLine("{0}.{1}{2}", DeskTop.Id, DeskTop.GetName, DeskTop.Prise);
            Console.ReadKey();
        }  
    }

    class Product
    {
        private uint id;
        private string name;
        private decimal price;

        public uint Id
        {
            get { return id; }
            set { id = value; }
        }

        public string GetName
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Prise
        {
            get { return price; }
            set { price = value; }
        }
    }
}
