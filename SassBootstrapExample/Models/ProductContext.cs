namespace SassBootstrapExample.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProductContext : DbContext
    {
        public ProductContext()
            : base("name=ProductContext")
        {
        }

       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
