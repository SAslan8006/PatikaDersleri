﻿using ETicaret.Domain.Entities;
using ETicaret.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistence.Contexts
{
    public class ETicaretDBContext : DbContext
    {
        public ETicaretDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Domain.Entities.File> Files { get; set; }
        public DbSet<ProductImageFile> ProductImageFiles { get; set; }
        public DbSet<InvoiceFile> InvoiceFiles { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //ChangeTracker:  Entityler üzerinde yapılan değişikliklerini yada yeni eklenen verilerini yakalanmasaını sağlar. Track edilen verileri yakalayıp elde etmemizi sağlar.
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                _= data.State switch
                { 
                    EntityState.Added=>data.Entity.CreatedDate=DateTime.UtcNow,
                    EntityState.Modified=>data.Entity.UpdatedDate=DateTime.UtcNow,
                    _=>DateTime.UtcNow
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
