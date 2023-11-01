using System;
using Hotel.Application.Repositories;
using MediatR;

namespace Hotel.Application.CQRS.Queries.Service.GetAllService
{
	public class GetAllServiceQueryHandler : IRequestHandler<GetAllServiceQueryRequest,IQueryable<Domain.Entities.Service>>
	{
        private readonly IServiceReadRepository _serviceReadRepository;
		public GetAllServiceQueryHandler(IServiceReadRepository serviceReadRepository)
		{
            _serviceReadRepository = serviceReadRepository;
		}

        public async Task<IQueryable<Domain.Entities.Service>> Handle(GetAllServiceQueryRequest request, CancellationToken cancellationToken)
        {
            var values = _serviceReadRepository.GetAll();
            return values;
        }
    }
}

