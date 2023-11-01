using System;
using Hotel.Domain.Entities;

namespace Hotel.Application.Repositories
{
	public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
	{
        Task AddAsync(T model);
        bool Remove(T model);
        Task<bool> RemoveAsync(string id);
        Task SaveAsync();
    }
}

