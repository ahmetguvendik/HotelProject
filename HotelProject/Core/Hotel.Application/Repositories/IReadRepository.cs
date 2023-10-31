using System;
using Hotel.Domain.Entities;

namespace Hotel.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        Task<T> GetById(string id);
    }
}

