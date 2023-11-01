using System;
using Hotel.Application.Repositories;
using Hotel.Domain.Entities;
using Hotel.Persistance.Contexts;

namespace Hotel.Persistance.Repositories
{
	public class StaffReadRepository : ReadRepository<Staff>, IStaffReadRepository
    {
        public StaffReadRepository(HotelDbContext context) : base(context)
        {

        }
    }


}

