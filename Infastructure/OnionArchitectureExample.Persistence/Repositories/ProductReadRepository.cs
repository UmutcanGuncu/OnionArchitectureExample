using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using OnionArchitectureExample.Application.Repositories;
using OnionArchitectureExample.Domain.Entities;
using OnionArchitectureExample.Persistence.Contexts;

namespace OnionArchitectureExample.Persistence.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(ETicaretAPIDbContex context) : base(context)
        {
        }
    }
}

