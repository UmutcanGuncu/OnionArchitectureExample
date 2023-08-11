using System;
using OnionArchitectureExample.Application.Repositories;
using OnionArchitectureExample.Domain.Entities;
using OnionArchitectureExample.Persistence.Contexts;

namespace OnionArchitectureExample.Persistence.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(ETicaretAPIDbContex contex) : base(contex)
        {
        }
    }
}

