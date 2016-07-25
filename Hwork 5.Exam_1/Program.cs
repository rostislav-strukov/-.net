﻿using System;
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
            Console.WriteLine("{0, 2}.{1, -20}:{2, 5:N}$", Tablet.Id, Tablet.GetName, Tablet.Prise);
            Console.WriteLine("{0, 2}.{1, -20}:{2, 5:N}$", Phone.Id, Phone.GetName, Phone.Prise);
            Console.WriteLine("{0, 2}.{1, -20}:{2, 5:N}$", Mouse.Id, Mouse.GetName, Mouse.Prise);
            Console.WriteLine("{0, 2}.{1, -20}:{2, 5:N}$", Tv.Id, Tv.GetName, Tv.Prise);
            Console.WriteLine("{0, 2}.{1, -20}:{2, 5:N}$", DeskTop.Id, DeskTop.GetName, DeskTop.Prise);
            Console.WriteLine("----------------------------------------");

            List<Product> parts = new List<Product>();

            parts.Add(Tablet);
            parts.Add(Tv);
            parts.Add(Phone);
            parts.Add(Mouse);
            parts.Add(DeskTop);

            Console.WriteLine("Please, Select product");

            while (true)
            {
                char _iEnter = (char)Console.ReadKey().Key;

                switch (_iEnter)
                {
                    case '1':
                        int Tablets;
                        Tablets = parts[0].Count++;
                        Console.WriteLine("You just selected - Tablet");
                        Console.WriteLine("Quontaty {0}", Tablets);
                        break;
                    case '2':
                        parts[1].Count++;
                        Console.WriteLine("You just selected - Tv");
                        break;
                    case '3':
                        parts[2].Count++;
                        Console.WriteLine("You just selected - Phone");
                        break;
                    case '4':
                        parts[3].Count++;
                        Console.WriteLine("You just selected - Mouse");
                        break;
                    case '5':
                        parts[4].Count++;
                        Console.WriteLine("You just selected - DeskTop");
                        break;
                    default:
                        Console.WriteLine("Unknown Product");
                        break;
                }

                Console.WriteLine("Please enter Q or q get total price");

                if (_iEnter == 'Q' || _iEnter == 'q')
                {
                    Console.WriteLine("You've been ended to choose products");
                    break;
                }
            }
           
            ShowCount(parts);

            Console.ReadKey();
        }

        private static void ShowCount(List<Product> lst)
        {
            foreach (Product i in lst)
            {
                Console.WriteLine($"{i.GetName} {i.Count}");
                
            }
            foreach (Product j in lst)
            {
                if (j.Count > 0)
                {
                    for (int i = 0; i < j.Count; i++)
                    {
                        j.TotalPrice += j.Prise;
                        
                    }
                    Console.WriteLine($"{j.GetName} {j.TotalPrice}");
                }
                //j.GetSum += j.TotalPrice;

                //Console.WriteLine($"{j.GetSum}");
            }
        }
    }

    class Product
    {
        private uint id;
        private string name;
        private decimal price;
        private int count;
        private decimal totalPrice;
        private decimal sum;

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

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public decimal TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        public decimal GetSum
        {
            get { return sum; }
            set { sum = value; }
        }
    }
}
