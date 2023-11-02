using System;
using MediatR;

namespace Hotel.Application.CQRS.Queries.Testimonial.GetAllTestimonial
{
	public class GetAllTestimonialQueryRequest : IRequest<IQueryable<Domain.Entities.Testimonial>>
	{
		
	}
}

