using System;
using Hotel.Application.Repositories;
using MediatR;

namespace Hotel.Application.CQRS.Queries.Room.GetAllRoom
{
	public class GetAllRoomQueryHandler : IRequestHandler<GetAllRoomQueryRequest,IQueryable<Domain.Entities.Room>>
	{
        private readonly IRoomReadRepository _roomReadRepository;
		public GetAllRoomQueryHandler(IRoomReadRepository roomReadRepository)
		{
            _roomReadRepository = roomReadRepository;
		}

        public async Task<IQueryable<Domain.Entities.Room>> Handle(GetAllRoomQueryRequest request, CancellationToken cancellationToken)
        {
            var value = _roomReadRepository.GetAll();
            return value;
        }
    }
}

