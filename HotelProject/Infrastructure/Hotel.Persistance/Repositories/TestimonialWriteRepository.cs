using System;
using Hotel.Application.Repositories;
using Hotel.Domain.Entities;
using Hotel.Persistance.Contexts;

namespace Hotel.Persistance.Repositories
{
	public class TestimonialWriteRepository : WriteRepository<Testimonial>, ITestimonialWriteRepository
    {
        public TestimonialWriteRepository(HotelDbContext context) : base(context)
        {

        }
    }

}

