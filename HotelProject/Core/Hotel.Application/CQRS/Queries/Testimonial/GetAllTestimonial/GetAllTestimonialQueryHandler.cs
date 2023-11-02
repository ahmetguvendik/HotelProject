using System;
using Hotel.Application.Repositories;
using MediatR;

namespace Hotel.Application.CQRS.Queries.Testimonial.GetAllTestimonial
{
	public class GetAllTestimonialQueryHandler : IRequestHandler<GetAllTestimonialQueryRequest,IQueryable<Domain.Entities.Testimonial>>
	{
        private readonly ITestimonialReadRepository _testimonialReadRepository;
		public GetAllTestimonialQueryHandler(ITestimonialReadRepository testimonialReadRepository)
		{
            _testimonialReadRepository = testimonialReadRepository;
		}

        public async Task<IQueryable<Domain.Entities.Testimonial>> Handle(GetAllTestimonialQueryRequest request, CancellationToken cancellationToken)
        {
            var value = _testimonialReadRepository.GetAll();
            return value;
        }
    }
}

