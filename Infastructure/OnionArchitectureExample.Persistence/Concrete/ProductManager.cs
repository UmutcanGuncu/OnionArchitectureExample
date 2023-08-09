using System;
using OnionArchitectureExample.Application.Abstraction;
using OnionArchitectureExample.Domain.Entities;

namespace OnionArchitectureExample.Persistence.Concrete
{
    public class ProductManager : IProductService
    {
        public List<Product> GetProducts()
         => new()
         {
             new() {
                 Id= Guid.NewGuid(),
                 Name="Macbook Air M2",
                 CreatedDate=DateTime.Now,
                 Price = 42000,
                 Stock = 50
             },
             new() {
                 Id= Guid.NewGuid(),
                 Name="Macbook Pro M2 14 İnch",
                 CreatedDate=DateTime.Now,
                 Price = 60000,
                 Stock = 40
             },
             new() {
                 Id= Guid.NewGuid(),
                 Name="Macbook Air M1",
                 CreatedDate=DateTime.Now,
                 Price = 28000,
                 Stock = 30
             }
         };
    }
}

