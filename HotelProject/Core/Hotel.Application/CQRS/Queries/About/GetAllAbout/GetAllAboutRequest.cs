using System;
using MediatR;

namespace Hotel.Application.CQRS.Queries.About.GetAllAbout
{
	public class GetAllAboutRequest : IRequest<IQueryable<Domain.Entities.About>>
	{
		
	}
}

