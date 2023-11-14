using System;
using Hotel.Application.Repositories;
using Hotel.Domain.Entities;
using Hotel.Persistance.Contexts;

namespace Hotel.Persistance.Repositories
{
	public class BookingReadRepository : ReadRepository<Booking>, IBookingReadRepository
    {
        public BookingReadRepository(HotelDbContext context) : base(context)
        {

        }
    }

}

