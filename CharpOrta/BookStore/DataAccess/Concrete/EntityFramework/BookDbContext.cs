using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class BookDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=BookStroe; Trusted_Connection=true;"); //Server = 175.142.2.12
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Laungage> BookLaungages { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<City> Citys { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<BookImage> BookImages { get; set; }




    }
}
