using System;
using System.Linq.Expressions;
using OnionArchitectureExample.Domain.Entities.Common;

namespace OnionArchitectureExample.Application.Repositories
{
	public interface IReadRepository<T> : IRepository<T> where T: BaseEntity
	{
		public IQueryable<T> GetList(bool tracking = true);
		public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);
		public Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);
		public Task<T> GetByIdAsync(Guid id, bool tracking = true);
	}
}

