using DataAcsess.Concrete.EntityFramework.Mappings;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DataAcsess.Concrete.EntityFramework
{
    public class NortwindContext : DbContext
    {
        public NortwindContext()
        {
            Database.SetInitializer<NortwindContext>(null);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            //Db mableri buraya eklemeliyiz
        }
    }
}
