using System;
using Hotel.Application.Repositories;
using Hotel.Domain.Entities;
using Hotel.Persistance.Contexts;

namespace Hotel.Persistance.Repositories
{
	public class ServiceWriteRepository : WriteRepository<Service>, IServiceWriteRepository
    {
        public ServiceWriteRepository(HotelDbContext context) : base(context)
        {

        }
    }

}

