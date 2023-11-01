using System;
using Hotel.Application.Repositories;
using Hotel.Domain.Entities;
using Hotel.Persistance.Contexts;

namespace Hotel.Persistance.Repositories
{
	public class ServiceReadRepository : ReadRepository<Service>, IServiceReadRepository
    {
        public ServiceReadRepository(HotelDbContext context) : base(context)
        {

        }
    }

}

