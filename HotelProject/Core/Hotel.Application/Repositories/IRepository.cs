using System;
using System.Collections.Generic;
using Hotel.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Application.Repositories
{
	public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}

