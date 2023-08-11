using System;
using Microsoft.EntityFrameworkCore;
using OnionArchitectureExample.Domain.Entities;
using OnionArchitectureExample.Domain.Entities.Common;

namespace OnionArchitectureExample.Persistence.Contexts
{
    public class ETicaretAPIDbContex : DbContext
    {
        public ETicaretAPIDbContex(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Deneme> Denemes { get; set; }
        //Amacımız savechanges async her tetikeldniğinde ınsert ise create date update ise update date column-
        //larını doldurmaktır
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //entityler üzerinde yapılan değişikkikleri ya da yeni eklenen verilerin yakalanmasını sağlayan properydir.
            //update operasyonlarında Track edilen verilerin yakalanıp elde edilmesini sağlar s
            var datas =ChangeTracker.Entries<BaseEntity>();
            foreach(var item in datas)
            {
                // _ şeklinde bir atama yaparsam hernagi bir değişkene değer atamasını istemiyorrum demek
                _ = item.State switch
                {
                    EntityState.Added => item.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => item.Entity.UpdatedDate = DateTime.UtcNow

                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
    
}

