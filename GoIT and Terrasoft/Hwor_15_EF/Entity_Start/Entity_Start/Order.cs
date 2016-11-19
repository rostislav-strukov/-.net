using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Start
{
    public class Order
    {
        //public Order()
        //{
        //    Products = new HashSet<Product>();
        //}
        public int Id { get; set; }

        public string Customer { get; set; }

        public int Quantity { get; set; }
        public int? ProductId { get; set; }
        public decimal? TotalPrice { get { return Product.ProdPrice * Quantity; } set { } }
        
        public Product Product { get; set; }
        ICollection<Product> product { get; set; }
    }
}
