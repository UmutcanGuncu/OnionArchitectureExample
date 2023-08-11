using System;
using OnionArchitectureExample.Application.Repositories;
using OnionArchitectureExample.Domain.Entities;
using OnionArchitectureExample.Persistence.Contexts;

namespace OnionArchitectureExample.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ETicaretAPIDbContex context) : base(context)
        {
        }
    }
}

