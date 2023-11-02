using System;
using Hotel.Application.Repositories;
using Hotel.Domain.Entities;
using Hotel.Persistance.Contexts;

namespace Hotel.Persistance.Repositories
{
	public class SubscribeWriteRepository : WriteRepository<Subscribe>, ISubscribeWriteRepository
    {
        public SubscribeWriteRepository(HotelDbContext context) : base(context)
        {

        }
    }
}

