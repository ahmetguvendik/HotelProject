using System;
using Hotel.Application.Repositories;
using Hotel.Domain.Entities;
using Hotel.Persistance.Contexts;

namespace Hotel.Persistance.Repositories
{
	public class SubscribeReadRepository : ReadRepository<Subscribe>, ISubscribeReadRepository
    {
        public SubscribeReadRepository(HotelDbContext context) : base(context)
        {

        }
    }
}

