using System;
using OnionArchitectureExample.Domain.Entities;

namespace OnionArchitectureExample.Application.Abstraction
{
	public interface IProductService
	{
		public List<Product> GetProducts();
	}
}

