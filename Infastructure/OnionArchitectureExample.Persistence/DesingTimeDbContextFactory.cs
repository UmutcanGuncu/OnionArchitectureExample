using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using OnionArchitectureExample.Persistence.Contexts;

namespace OnionArchitectureExample.Persistence
{
    public class DesingTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretAPIDbContex>
    {

        public ETicaretAPIDbContex CreateDbContext(string[] args)
        {
           

            DbContextOptionsBuilder<ETicaretAPIDbContex> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configurations.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}

