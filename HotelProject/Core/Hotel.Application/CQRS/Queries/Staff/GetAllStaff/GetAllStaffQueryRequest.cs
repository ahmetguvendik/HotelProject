using System;
using MediatR;

namespace Hotel.Application.CQRS.Queries.Staff.GetAllStaff
{
	public class GetAllStaffQueryRequest : IRequest<IQueryable<Domain.Entities.Staff>>
	{
		
	}
}

