using System;
using OnionArchitectureExample.Domain.Entities.Common;

namespace OnionArchitectureExample.Application.Repositories
{
	public interface IWriteRepository<T>: IRepository<T> where T: BaseEntity
	{
		public Task<bool> AddAsync(T model);
		public Task<bool> AddRangeAsync(List<T> model);
        public bool Remove(T model);
        public Task<bool> RemoveAsync(Guid id); //bool dönmemizin nedeni işlemler başarılıysa true diğer türlü false
        public bool RemoveRange(List<T> datas);
        public bool Update(T model);
		public Task<int> SaveChanges();
	}
}

