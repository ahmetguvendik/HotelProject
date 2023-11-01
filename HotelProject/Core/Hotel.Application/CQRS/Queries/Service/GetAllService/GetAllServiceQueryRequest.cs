using System;
using MediatR;

namespace Hotel.Application.CQRS.Queries.Service.GetAllService
{
	public class GetAllServiceQueryRequest : IRequest<IQueryable<Domain.Entities.Service>>
	{

	}
}

