using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Start
{
    [Table("Order")]
    public partial class Order
    {
        public int Id { get; set; }

        public string NameProd { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
