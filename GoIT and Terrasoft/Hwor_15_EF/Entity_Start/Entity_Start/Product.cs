namespace Entity_Start
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("Product")]
    public class Product
    {
        public int Id { get; set; }

        public string NameProd { get; set; }

        public decimal ProdPrice { get; set; }

        ICollection<Order> Order { get; set; }
    }
}
