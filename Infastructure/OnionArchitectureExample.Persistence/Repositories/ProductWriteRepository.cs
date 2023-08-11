using System;
using OnionArchitectureExample.Application.Repositories;
using OnionArchitectureExample.Domain.Entities;
using OnionArchitectureExample.Persistence.Contexts;

namespace OnionArchitectureExample.Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ETicaretAPIDbContex contex) : base(contex)
        {
        }
    }
}

