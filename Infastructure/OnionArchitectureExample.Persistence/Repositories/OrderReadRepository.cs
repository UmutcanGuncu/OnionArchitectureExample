using System;
using OnionArchitectureExample.Application.Repositories;
using OnionArchitectureExample.Domain.Entities;
using OnionArchitectureExample.Persistence.Contexts;

namespace OnionArchitectureExample.Persistence.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(ETicaretAPIDbContex context) : base(context)
        {
        }
    }
}

