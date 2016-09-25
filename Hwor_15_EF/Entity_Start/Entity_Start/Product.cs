namespace Entity_Start
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int IdProduct { get; set; }

        public string NameProd { get; set; }

        public decimal ProdPrice { get; set; }
    }
}
