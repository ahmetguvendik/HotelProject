using System;
using MediatR;

namespace Hotel.Application.CQRS.Queries.Room.GetAllRoom
{
	public class GetAllRoomQueryRequest : IRequest<IQueryable<Domain.Entities.Room>>
	{

	}
}

