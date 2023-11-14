using System;
using Hotel.Application.Repositories;
using Hotel.Domain.Entities;
using Hotel.Persistance.Contexts;

namespace Hotel.Persistance.Repositories
{
	public class BookingWriteRepository : WriteRepository<Booking>, IBookingWriteRepository
    {
        public BookingWriteRepository(HotelDbContext context) : base(context)
        {

        }
    }

}

