using System;
using Microsoft.EntityFrameworkCore;
using OnionArchitectureExample.Domain.Entities.Common;

namespace OnionArchitectureExample.Application.Repositories
{
	public interface IRepository<T> where T: BaseEntity
	{
		public DbSet<T> Table { get; }
	}
}

