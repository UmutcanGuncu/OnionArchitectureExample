using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using OnionArchitectureExample.Application.Repositories;
using OnionArchitectureExample.Domain.Entities.Common;
using OnionArchitectureExample.Persistence.Contexts;

namespace OnionArchitectureExample.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ETicaretAPIDbContex _context;

        public ReadRepository(ETicaretAPIDbContex context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>(); //T türüne ait ilgili nesneyi döndürür

        

        public IQueryable<T> GetList(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return query;
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query =  Table.AsQueryable();
            if (!tracking)
            {
               query = Table.AsNoTracking();
             
            }
            return await query.FirstOrDefaultAsync(method);

        }
            

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
            => Table.Where(method);
        public async Task<T> GetByIdAsync(Guid id, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query= Table.AsNoTracking();
            }
            return await query.FirstOrDefaultAsync(data => data.Id == id);
        }
           
    }
}

