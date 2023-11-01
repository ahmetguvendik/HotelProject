using System;
using Hotel.Application.Repositories;
using MediatR;

namespace Hotel.Application.CQRS.Queries.Staff.GetAllStaff
{
	public class GetAllStaffQueryHandler : IRequestHandler<GetAllStaffQueryRequest,IQueryable<Domain.Entities.Staff>>
	{
        private readonly IStaffReadRepository _staffReadRepository;
		public GetAllStaffQueryHandler(IStaffReadRepository staffReadRepository)
		{
            _staffReadRepository = staffReadRepository;
		}

        public async Task<IQueryable<Domain.Entities.Staff>> Handle(GetAllStaffQueryRequest request, CancellationToken cancellationToken)
        {
            var values = _staffReadRepository.GetAll();
            return values;
        }
    }
}

