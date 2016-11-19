namespace Entity_Start
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }
        public virtual DbSet<Product> TableProduct { get; set; }
        public virtual DbSet<Order> TableOrder { get; set; }
        
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}