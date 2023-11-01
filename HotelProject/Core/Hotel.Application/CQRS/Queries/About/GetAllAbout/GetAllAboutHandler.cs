using System;
using Hotel.Application.Repositories;
using MediatR;

namespace Hotel.Application.CQRS.Queries.About.GetAllAbout
{
	public class GetAllAboutHandler : IRequestHandler<GetAllAboutRequest,IQueryable<Domain.Entities.About>>
	{
        private readonly IAboutReadRepository _aboutReadRepository;
		public GetAllAboutHandler(IAboutReadRepository aboutReadRepository)
		{
            _aboutReadRepository = aboutReadRepository;
		}

        public async Task<IQueryable<Domain.Entities.About>> Handle(GetAllAboutRequest request, CancellationToken cancellationToken)
        {
            var values = _aboutReadRepository.GetAll();
            return values;
        }
    }
}

