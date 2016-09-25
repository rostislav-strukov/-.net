namespace Entity_Start
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HubDB : DbContext
    {
        public HubDB()
            : base("name=HubDB")
        {
        }

        public virtual DbSet<Order> TableOrder { get; set; }
        public virtual DbSet<Product> TableProduct { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>()
        //        .Property(e => e.NameProd)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Product>()
        //        .Property(e => e.ProdPrice)
        //        .IsFixedLength();
        //}
    }
}
