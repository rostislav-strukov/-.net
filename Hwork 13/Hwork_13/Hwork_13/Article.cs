using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork_13
{
    class Article
    {
        private int _id;
        private string _name;
        private decimal _priсe = 0;
        private int _valueCount;
        private decimal _discount;
        private decimal _sum;
        private int _sold;

        public int Id {get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public decimal Price { get { return _priсe; } set { _priсe = value; } }
        public int ValueCount { get { return _valueCount; } set { _valueCount = value; } }
        public decimal Discount { get { return _discount; } set { _discount = value; } }
        public decimal Sum { get { return _sum; } set { _sum = (_discount * _priсe) * _sold; } }
        public int Sold { get { return _sold; } set { _sold = value; } }

        public Article(int idArg, string nameArg, decimal priceArg, int valueCountArg, decimal discountArg, decimal sumArg, int soldArg)
        {
            Id = idArg;
            Name = nameArg;
            Price = priceArg;
            ValueCount = valueCountArg;
            Discount = discountArg;
            Sum = sumArg;
            Sold = soldArg;
        }

        public Article() { }
    }
}
