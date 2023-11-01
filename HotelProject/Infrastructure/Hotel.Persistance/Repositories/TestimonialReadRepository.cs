using System;
using Hotel.Application.Repositories;
using Hotel.Domain.Entities;
using Hotel.Persistance.Contexts;

namespace Hotel.Persistance.Repositories
{
	public class TestimonialReadRepository : ReadRepository<Testimonial>, ITestimonialReadRepository
    {
        public TestimonialReadRepository(HotelDbContext context) : base(context)
        {

        }
    }

}

