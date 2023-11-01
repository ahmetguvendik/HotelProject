using System;
using Hotel.Application.Repositories;
using Hotel.Domain.Entities;
using Hotel.Persistance.Contexts;

namespace Hotel.Persistance.Repositories
{
	public class StaffWriteRepository : WriteRepository<Staff>, IStaffWriteRepository
    {
        public StaffWriteRepository(HotelDbContext context) : base(context)
        {

        }
    }

}

