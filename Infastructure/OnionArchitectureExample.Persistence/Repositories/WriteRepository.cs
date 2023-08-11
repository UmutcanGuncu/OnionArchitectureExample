using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using OnionArchitectureExample.Application.Repositories;
using OnionArchitectureExample.Domain.Entities.Common;
using OnionArchitectureExample.Persistence.Contexts;

namespace OnionArchitectureExample.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly ETicaretAPIDbContex _contex;

        public WriteRepository(ETicaretAPIDbContex contex)
        {
            _contex = contex;
        }

        public DbSet<T> Table => _contex.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entry = await Table.AddAsync(model);
            return entry.State == EntityState.Added;
        }
        

        public async Task<bool> AddRangeAsync(List<T> model)
        {
            await Table.AddRangeAsync(model);
            return true;
        }

        public bool Remove(T model) //Remove'ın async i yok
        {
            EntityEntry<T> entry=  Table.Remove(model);
            return entry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            T value = await Table.FirstOrDefaultAsync(x => x.Id == id);
            return Remove(value); //remove fonksiyonunu çağırdık
        }

        public bool RemoveRange(List<T> datas)
        {
           Table.RemoveRange(datas);
           return true;
        }

        public async Task<int> SaveChanges()
            => await _contex.SaveChangesAsync();

        public bool Update(T model)
        {
            EntityEntry<T> entry =  Table.Update(model);
            return entry.State == EntityState.Modified;
        }
    }
}

