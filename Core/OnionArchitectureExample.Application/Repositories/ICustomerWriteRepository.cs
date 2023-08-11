using System;
using OnionArchitectureExample.Domain.Entities;

namespace OnionArchitectureExample.Application.Repositories
{
	public interface ICustomerWriteRepository:IWriteRepository<Customer>
	{
	}
}

